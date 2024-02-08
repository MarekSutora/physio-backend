using DataAccess.Model.Entities;

namespace DataAccess.Model.Entities
{
    public class AvailableReservationServiceTypeDc
    {
        public int Id { get; set; }
        public int ServiceTypeDurationCostId { get; set; }
        public int AvailableReservationId { get; set; }
        public ServiceTypeDurationCost ServiceTypeDurationCost { get; set; } = null!;
        public AvailableReservation AvailableReservation { get; set; } = null!;
    }
}