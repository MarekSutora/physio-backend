using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BlogPostsViewsStats
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int ViewCount { get; set; }
    }
}
