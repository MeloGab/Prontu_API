using Prontu_API.Models.Enum;

namespace Prontu_API.Models.Entities
{
    public class UserAdmModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string CPF { get; set; }
        public string Address { get; set; }
        public string ClinicName { get; set; }
        public string ClinicImage { get; set; }
        public DateTime DateofBirth { get; set; }
        public RoleEnum Role { get; set; }
        public DateTime TokenCreateDate { get; set; } = DateTime.Now;
    }
}
