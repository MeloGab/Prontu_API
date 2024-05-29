using Prontu_API.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace Prontu_API.Dto
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "The User is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Email is required"), EmailAddress(ErrorMessage = "Email invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Password is required")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password field does not match")]
        public string ConfirmPassword { get; set; }

        public RoleEnum Role { get; set; }
    }
}
