using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class DurationCost
    {
        public int Id { get; set; }
        public int DurationMinutes { get; set; }
        public decimal Cost { get; set; }

        public List<ServiceType> ServiceTypes { get; } = [];
        public List<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; } = [];

    }
}
