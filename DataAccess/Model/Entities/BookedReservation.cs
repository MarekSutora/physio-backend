
namespace DataAccess.Model.Entities
{
    public class BookedReservation
    {
        public int Id { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime ReservationBookedDate { get; set; }
        public DateTime ReservationFinishedDate { get; set; }
        public string Note { get; set; }




        public int AvailableReservationServiceTypeDCId { get; set; }
        public AvailableReservationServiceTypeDc? AvailableReservationServiceTypeDc { get; set; } = null!;


        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
