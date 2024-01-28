using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeding
{
    public static class AvailableAppointmentActivityTypeSeeding
    {
        public static void SeedAvailableAppointmentActivityTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableAppointmentActivityType>().HasData(
                new AvailableAppointmentActivityType { AvailableAppointmentId = 1, ActivityTypeId = 1 },
            new AvailableAppointmentActivityType { AvailableAppointmentId = 1, ActivityTypeId = 2 },
            new AvailableAppointmentActivityType { AvailableAppointmentId = 2, ActivityTypeId = 1 },
            new AvailableAppointmentActivityType { AvailableAppointmentId = 2, ActivityTypeId = 3 }
            // Continue adding the rest of the generated appointments
            );
        }
    }
}
