using DataAccess.Model.Entities;
namespace DataAccess.Model.Entities
{
    public class AvailableAppointmentActivityType
    {
        public int AvailableAppointmentId { get; set; }
        public int ActivityTypeId { get; set; }
        public AvailableAppointment AvailableAppointment { get; set; } = null!;

        public ActivityType ActivityType { get; set; } = null!;
    }
}