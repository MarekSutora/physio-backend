using DataAccess.Model.Entities;

namespace DataAccess.Model.Entities
{
    public class AppointmentServiceTypeDurationCost
    {
        public int Id { get; set; }
        public int ServiceTypeDurationCostId { get; set; }
        public int AppointmentId { get; set; }
        public ServiceTypeDurationCost ServiceTypeDurationCost { get; set; } = null!;
        public Appointment Appointment { get; set; } = null!;

        public ICollection<BookedAppointment> BookedAppointments { get; set; } = new List<BookedAppointment>();
    }
}