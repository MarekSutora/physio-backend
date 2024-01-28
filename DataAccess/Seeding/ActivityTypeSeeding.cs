using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataSeeding
{
    public static class ActivityTypeSeeding
    {
        public static void SeedActivityTypes(this ModelBuilder builder)
        {
            builder.Entity<ActivityType>().HasData(
                new ActivityType { Id = 1, Name = "Konzultácia", Description = "Individuálna konzultácia", NormalCost = 60, Duration = 30, HexColor = "#007bff" },
                new ActivityType { Id = 2, Name = "Fyzioterapia", Description = "Terapeutická fyzioterapia", NormalCost = 50, Duration = 60, HexColor = "#28a745" },
                new ActivityType { Id = 3, Name = "Masáž", Description = "Relaxačná masáž", NormalCost = 40m, Duration = 45, HexColor = "#dc3545" },
                new ActivityType { Id = 4, Name = "Rehabilitácia", Description = "Rehabilitačné cvičenia", NormalCost = 40, Duration = 60, HexColor = "#ffc107" }
            );
        }
    }
}
