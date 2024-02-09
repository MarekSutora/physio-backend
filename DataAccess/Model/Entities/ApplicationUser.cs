using Microsoft.AspNetCore.Identity;

namespace DataAccess.Model.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public DateTime RegisteredDate { get; set; }


        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        //public ICollection<BlogPost> BlogPosts { get; } = new List<BlogPost>();
    }
}