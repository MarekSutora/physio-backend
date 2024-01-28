using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.DataSeeding
{
    public static class AvailableReservationSeeding
    {
        public static void SeedAvailableReservations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableReservation>().HasData(
                new AvailableReservation { Id = 1, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 8, 0, 0) },
                new AvailableReservation { Id = 2, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 10, 0, 0) },
                new AvailableReservation { Id = 3, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 12, 0, 0) },
                new AvailableReservation { Id = 4, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 14, 0, 0) },
                new AvailableReservation { Id = 5, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 16, 0, 0) }
                // Continue adding the rest of the generated Reservations
            );
        }

    }
}
