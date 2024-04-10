namespace DataAccess.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public DateTime StartTime { get; set; }

        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];
        public List<AppointmentServiceTypeDurationCost> AppointmentServiceTypeDurationCosts { get; } = [];

        public AppointmentDetail? AppointmentDetail { get; set; }
    }
}
