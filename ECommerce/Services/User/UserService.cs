using ECommerce.Context;
using ECommerce.Dtos.ResponseDto;
using ECommerce.Dtos.UserDto;
using System;
using System.Threading.Tasks;

namespace ECommerce.Services.User
{
    public class UserService : IUserService
    {
        private readonly ECommerceContext _DbContext;
        public UserService(ECommerceContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<Response<UserDto>> validateUser(SignInRequest request)
        {
            try
            {
                return new SuccessResponse<UserDto>("", null);
            }
            catch(Exception error)
            { 
                return new FailResponse<UserDto>("Lỗi: " + error.Message);
            }
        }
    }
}
