using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeding
{
    public static class AvailableReservationActivityTypeSeeding
    {
        public static void SeedAvailableReservationActivityTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableReservationActivityType>().HasData(
                new AvailableReservationActivityType { AvailableReservationId = 1, ActivityTypeId = 1 },
            new AvailableReservationActivityType { AvailableReservationId = 1, ActivityTypeId = 2 },
            new AvailableReservationActivityType { AvailableReservationId = 2, ActivityTypeId = 1 },
            new AvailableReservationActivityType { AvailableReservationId = 2, ActivityTypeId = 3 }
            // Continue adding the rest of the generated Reservations
            );
        }
    }
}
