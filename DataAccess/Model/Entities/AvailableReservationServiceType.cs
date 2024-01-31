using DataAccess.Model.Entities;
namespace DataAccess.Model.Entities
{
    public class AvailableReservationServiceType
    {
        public int AvailableReservationId { get; set; }
        public int ServiceTypeId { get; set; }
        public AvailableReservation AvailableReservation { get; set; } = null!;
        public ServiceType ServiceType { get; set; } = null!;
    }
}