using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Auth
{

    public class LoginRequestDto
    {

        [Required(ErrorMessage = "Attribute Email is required.")]
        [EmailAddress(ErrorMessage = "Attribute Email is not a valid Email Adress.")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
