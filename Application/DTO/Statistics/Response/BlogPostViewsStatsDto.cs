using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Statistics.Response
{
    public class BlogPostViewsStatsDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int TotalViews { get; set; }
    }
}
