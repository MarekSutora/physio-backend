using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class DurationCost
    {
        public int Id { get; set; }
        public int DurationMinutes { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Cost { get; set; }

        public List<ServiceType> ServiceTypes { get; } = [];
        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];
    }
}
