using diploma_thesis_backend.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace diploma_thesis_backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
