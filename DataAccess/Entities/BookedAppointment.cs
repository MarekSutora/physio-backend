namespace DataAccess.Entities
{
    public class BookedAppointment
    {
        public int Id { get; set; }
        public DateTime AppointmentBookedDate { get; set; }

        public bool IsFinished { get; set; } = false;
        public bool SevenDaysReminderSent { get; set; } = false;
        public bool OneDayReminderSent { get; set; } = false;

        public int AppointmentServiceTypeDurationCostId { get; set; }
        public AppointmentServiceTypeDurationCost AppointmentServiceTypeDurationCost { get; set; } = null!;

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
