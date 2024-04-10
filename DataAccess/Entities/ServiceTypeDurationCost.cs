namespace DataAccess.Entities
{
    public class ServiceTypeDurationCost
    {
        public int Id { get; set; }
        public int ServiceTypeId { get; set; }
        public int DurationCostId { get; set; }
        public ServiceType ServiceType { get; set; } = null!;
        public DurationCost DurationCost { get; set; } = null!;
        public DateTime DateFrom { get; set; } = DateTime.UtcNow.AddHours(1);
        public DateTime? DateTo { get; set; }


        public List<Appointment> Appointments { get; } = [];
        public List<AppointmentServiceTypeDurationCost> AppointmentServiceTypeDurationCosts { get; } = [];
    }
}
