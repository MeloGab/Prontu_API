using Prontu_API.Services.Interfaces;
using System.Security.Cryptography;

namespace Prontu_API.Services
{
    public class PassHashService : IPassHashService
    {
        public void CreatePassHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
