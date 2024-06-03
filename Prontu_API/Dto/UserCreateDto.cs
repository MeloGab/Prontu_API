using Prontu_API.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Prontu_API.Dto
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "The User is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Email is required"), EmailAddress(ErrorMessage = "Email invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The CPF or CNPJ is required")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "The Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Clinic Name is required")]
        public string ClinicName { get; set; }

        public string ClinicImage { get; set; }

        [Required(ErrorMessage = "The Date of Birth is required")]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "The Password is required")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password field does not match")]
        public string ConfirmPassword { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoleEnum Role { get; set; }
    }
}
