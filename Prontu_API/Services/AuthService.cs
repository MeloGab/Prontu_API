using Prontu_API.Data;
using Prontu_API.Dto;
using Prontu_API.Models.Entities;
using Prontu_API.Models.Interfaces;
using Prontu_API.Models.Response;
using Prontu_API.Services.Interfaces;

namespace Prontu_API.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IPassHashService _passwordHash;

        public AuthService(ApplicationDbContext context,IPassHashService passwordHash)
        {
            _context = context;
            _passwordHash = passwordHash;
        }

        public async Task<Response<UserCreateDto>> Register(UserCreateDto userRegister)
        {
            Response<UserCreateDto> responseService = new Response<UserCreateDto>();

            try
            {
                if (!UserEmailExist(userRegister))
                {
                    responseService.Date = null;
                    responseService.Mensage = "This data is already resgistered ";
                    responseService.Status = false;
                    return responseService;
                }

                _passwordHash.CreatePassHash(userRegister.Password, out byte[] passwordHash, out byte[] passwordSalt);

                UserAdmModel users = new UserAdmModel()
                {
                    Name = userRegister.Name,
                    Email = userRegister.Email,
                    Role = userRegister.Role,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    CPF = userRegister.CPF,
                    Address = userRegister.Address,
                    ClinicName = userRegister.ClinicName,
                    ClinicImage = userRegister.ClinicImage,
                    DateofBirth = userRegister.DateofBirth,
                };

                _context.Add(users);
                await _context.SaveChangesAsync();

                responseService.Status = true;
                responseService.Mensage = "User created successfully";
            }
            catch (Exception ex)
            {
                responseService.Date = null;
                responseService.Mensage = ex.Message;
                responseService.Status = false;
                return responseService;
            }

            return responseService;
        }

        public bool UserEmailExist(UserCreateDto userRegister)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == userRegister.Email || x.Name == userRegister.Name);

            if (user != null) return false;
            return true;
        }

    }
}
