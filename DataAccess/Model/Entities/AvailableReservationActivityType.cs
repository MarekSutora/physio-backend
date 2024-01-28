using DataAccess.Model.Entities;
namespace DataAccess.Model.Entities
{
    public class AvailableReservationActivityType
    {
        public int AvailableReservationId { get; set; }
        public int ActivityTypeId { get; set; }
        public AvailableReservation AvailableReservation { get; set; } = null!;

        public ActivityType ActivityType { get; set; } = null!;
    }
}