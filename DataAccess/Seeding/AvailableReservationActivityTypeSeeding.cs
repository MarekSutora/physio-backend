using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Seeding
{
    public static class AvailableReservationActivityTypeSeeding
    {
        public static void SeedAvailableReservationActivityTypes(this ModelBuilder modelBuilder)
        {
            var availableReservationActivityTypes = new List<AvailableReservationActivityType>();

            // Assuming AvailableReservations IDs range from 1 to 17 and ActivityType IDs range from 1 to 4
            for (int availableReservationId = 1; availableReservationId <= 17; availableReservationId++)
            {
                var assignedActivityTypes = new HashSet<int>();

                // Ensure each AvailableReservation has between 1 to 3 ActivityTypes
                int numberOfActivityTypes = new Random().Next(1, 4);
                for (int i = 0; i < numberOfActivityTypes; i++)
                {
                    int activityTypeId;
                    do
                    {
                        activityTypeId = new Random().Next(1, 5); // ActivityType IDs 1 to 4
                    }
                    while (!assignedActivityTypes.Add(activityTypeId)); // Ensure no duplicates

                    availableReservationActivityTypes.Add(new AvailableReservationActivityType
                    {
                        AvailableReservationId = availableReservationId,
                        ActivityTypeId = activityTypeId
                    });
                }
            }

            modelBuilder.Entity<AvailableReservationActivityType>().HasData(availableReservationActivityTypes.ToArray());
        }
    }
}
