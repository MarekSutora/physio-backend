using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataSeeding
{
    public static class ServiceTypeSeeding
    {
        public static void SeedServiceTypes(this ModelBuilder builder)
        {
            //builder.Entity<ServiceType>().HasData(
            //    new ServiceType { Id = 1, Name = "Konzultácia", Description = "Individuálna konzultácia", Cost = 60, Duration = 30, HexColor = "#007bff" },
            //    new ServiceType { Id = 2, Name = "Fyzioterapia", Description = "Terapeutická fyzioterapia", Cost = 50, Duration = 60, HexColor = "#28a745" },
            //    new ServiceType { Id = 3, Name = "Masáž", Description = "Relaxačná masáž", Cost = 40m, Duration = 45, HexColor = "#dc3545" },
            //    new ServiceType { Id = 4, Name = "Rehabilitácia", Description = "Rehabilitačné cvičenia", Cost = 40, Duration = 60, HexColor = "#ffc107" }
            //);
        }
    }
}
