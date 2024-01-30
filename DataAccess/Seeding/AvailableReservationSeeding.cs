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
                new AvailableReservation { Id = 1, Capacity = 1, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 8, 0, 0) },
                new AvailableReservation { Id = 2, Capacity = 2, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 10, 0, 0) },
                new AvailableReservation { Id = 3, Capacity = 3, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 12, 0, 0) },
                new AvailableReservation { Id = 4, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 14, 0, 0) },
                new AvailableReservation { Id = 5, Capacity = 5, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 16, 0, 0) },
                new AvailableReservation { Id = 6, Capacity = 6, ReservedAmount = 0, Date = new DateTime(2024, 1, 30, 16, 0, 0) },
                new AvailableReservation { Id = 7, Capacity = 1, ReservedAmount = 0, Date = new DateTime(2024, 2, 1, 8, 0, 0) },
                new AvailableReservation { Id = 8, Capacity = 2, ReservedAmount = 0, Date = new DateTime(2024, 2, 1, 10, 0, 0) },
                new AvailableReservation { Id = 9, Capacity = 3, ReservedAmount = 0, Date = new DateTime(2024, 2, 1, 11, 0, 0) },
                new AvailableReservation { Id = 10, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 2, 1, 12, 0, 0) },
                new AvailableReservation { Id = 11, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 2, 1, 12, 30, 0) },
                new AvailableReservation { Id = 12, Capacity = 5, ReservedAmount = 0, Date = new DateTime(2024, 2, 1, 14, 35, 0) },
                new AvailableReservation { Id = 13, Capacity = 1, ReservedAmount = 0, Date = new DateTime(2024, 2, 1, 16, 5, 0) },
                new AvailableReservation { Id = 14, Capacity = 2, ReservedAmount = 0, Date = new DateTime(2024, 3, 1, 7, 0, 0) },
                new AvailableReservation { Id = 15, Capacity = 10, ReservedAmount = 0, Date = new DateTime(2024, 3, 1, 8, 0, 0) },
                new AvailableReservation { Id = 16, Capacity = 1, ReservedAmount = 0, Date = new DateTime(2024, 3, 1, 9, 0, 0) },
                new AvailableReservation { Id = 17, Capacity = 2, ReservedAmount = 0, Date = new DateTime(2024, 3, 1, 13, 0, 0) }
                // Continue adding the rest of the generated Reservations
            );
        }

    }
}
