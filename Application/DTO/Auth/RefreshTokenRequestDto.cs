using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Auth
{
    public class RefreshTokenRequestDto
    {
        [Required(ErrorMessage = "Attribute RefreshToken is required.")]
        [StringLength(500, ErrorMessage = "Attribute RefreshToken must be less than or equal to 500 characters.")]
        public string RefreshToken { get; set; }
    }
}