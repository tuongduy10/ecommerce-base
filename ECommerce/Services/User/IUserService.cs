using ECommerce.Dtos.ResponseDto;
using ECommerce.Dtos.UserDto;
using System.Threading.Tasks;

namespace ECommerce.Services.User
{
    public interface IUserService
    {
        Task<Response<UserDto>> validateUser(SignInRequest request);
    }
}
