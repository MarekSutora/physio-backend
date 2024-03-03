using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string HexColor { get; set; }

        public required string Description { get; set; }

        public bool Active { get; set; } = true;

        public List<DurationCost> DurationCosts { get; } = [];

        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];
    }
}
