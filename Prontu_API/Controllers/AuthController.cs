using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prontu_API.Dto;
using Prontu_API.Services.Interfaces;

namespace Prontu_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authInterface;
        public AuthController(IAuthService authInterface)
        {
            _authInterface = authInterface;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(UserCreateDto userRegister)
        {
           var response = await _authInterface.Register(userRegister);
            return Ok(response);
        }

    }
}
