using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class BlogPostKeyword
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; } = null!;
    }
}
