
namespace DataAccess.Model.Entities
{
    public class BookedAppointment
    {
        public int Id { get; set; }
        public DateTime AppointmentBookedDate { get; set; }

        public bool IsFinished { get; set; } = false;

        public int AppointmentServiceTypeDurationCostId { get; set; }
        public AppointmentServiceTypeDurationCost AppointmentServiceTypeDurationCost { get; set; } = null!;

        public AppointmentDetail? BookedAppointmentDetail { get; set; }

        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
