using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Reservations
{
    public class ActivityTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NormalCost { get; set; }
        public int Duration { get; set; }
        public string HexColor { get; set; }
    }
}
