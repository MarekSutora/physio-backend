using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Statistics.Response
{
    public class ServiceTypeAppointmentsCountDto
    {
        public string ServiceTypeName { get; set; }
        public int FinishedAppointmentsCount { get; set; }
    }
}
