using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diploma_thesis_backend.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
