using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
