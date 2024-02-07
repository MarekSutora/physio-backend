using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class ServiceTypeDurationCost
    {
        public int Id { get; set; }

        public int DurationMinutes { get; set; }

        public decimal Cost { get; set; }

        public int ServiceTypeId { get; set; }

        [Comment("Property for statistics in case cost or duration gets updated")]
        public bool Active { get; set; }

        public ServiceType ServiceType { get; set; } = null!;

    }
}
