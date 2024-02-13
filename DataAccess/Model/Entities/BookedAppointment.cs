
namespace DataAccess.Model.Entities
{
    public class BookedAppointment
    {
        public int Id { get; set; }
        public DateTime AppointmentBookedDate { get; set; }

        public DateTime? CancellationDate { get; set; }

        public int AppointmentServiceTypeDurationCostId { get; set; }
        public AppointmentServiceTypeDurationCost AppointmentServiceTypeDurationCost { get; set; } = null!;


        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
