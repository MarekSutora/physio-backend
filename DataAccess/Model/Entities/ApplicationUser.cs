using Microsoft.AspNetCore.Identity;

namespace DataAccess.Model.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}