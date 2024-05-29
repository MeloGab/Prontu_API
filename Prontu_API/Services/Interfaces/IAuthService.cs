using Prontu_API.Dto;
using Prontu_API.Models.Response;

namespace Prontu_API.Services.Interfaces
{
    public interface IAuthService
    {
        Task<Response<UserCreateDto>> Register(UserCreateDto userRegister);
    }
}