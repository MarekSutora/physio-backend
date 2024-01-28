using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.DataSeeding
{
    public static class AvailableAppointmentSeeding
    {
        public static void SeedAvailableAppointments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableAppointment>().HasData(
                new AvailableAppointment { Id = 1, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 8, 0, 0) },
                new AvailableAppointment { Id = 2, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 10, 0, 0) },
                new AvailableAppointment { Id = 3, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 12, 0, 0) },
                new AvailableAppointment { Id = 4, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 14, 0, 0) },
                new AvailableAppointment { Id = 5, Capacity = 4, ReservedAmount = 0, Date = new DateTime(2024, 1, 29, 16, 0, 0) }
                // Continue adding the rest of the generated appointments
            );
        }

    }
}
