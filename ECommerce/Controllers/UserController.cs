using ECommerce.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using Microsoft.Extensions.Logging;
using ECommerce.Services.User;
using Microsoft.Extensions.Options;
using ECommerce.Dtos.ResponseDto;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using ECommerce.Dtos.UserDto;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly AppSettings _appSettings;
        private readonly IUserService _userService;
        public UserController(
            ILogger<UserController> logger,
            IOptionsMonitor<AppSettings> optionsMonitor,
            IUserService userService) 
        {
            _logger = logger;
            _appSettings = optionsMonitor.CurrentValue;
            _userService = userService;
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(SignInRequest request)
        {
            var result = await _userService.validateUser(request);
            if (!result.isSuccess)
            {
                return BadRequest(result);
            }
            var user = result.data;
            return Ok(new SuccessResponse<UserDto>
            {
                status = "success",
                isSuccess = result.isSuccess,
                message = result.message,
                data = GenerateToken(user)
            });
        }
        private string GenerateToken(UserDto user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var secretKeyBytes = Encoding.UTF8.GetBytes(_appSettings.SecretKey);
            var description = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("id", user.userId.ToString()),
                    new Claim("tokenId", Guid.NewGuid().ToString()),
                    new Claim("fullName", user.userFullName),
                    new Claim("phone", user.userPhone),
                }),
                Expires = DateTime.UtcNow.AddHours(4),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha256Signature)
            };
            var createToken = jwtTokenHandler.CreateToken(description);
            var writeToken = jwtTokenHandler.WriteToken(createToken);
            return writeToken;
        }
    }
}
