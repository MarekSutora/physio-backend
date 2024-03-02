using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Statistics.Response
{
    public class NewClientsStatisticsDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int NewClientsCount { get; set; }
    }
}
