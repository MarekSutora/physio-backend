using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Statistics.Response
{
    public class ServiceTypeMonthlyStatisticsDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string ServiceTypeName { get; set; }
        public int FinishedAppointmentsCount { get; set; }
        public string HexColor { get; set; }
    }
}
