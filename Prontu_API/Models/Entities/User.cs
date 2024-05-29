using Prontu_API.Models.Enum;

namespace Prontu_API.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public RoleEnum Role { get; set; }
        public DateTime TokenCreateDate { get; set; } = DateTime.Now;
    }
}
