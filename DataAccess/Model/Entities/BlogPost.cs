using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime? date { get; set; }
        public int? BlogId { get; set; }
        public Blog? Blog { get; set; }

        //public string ApplicationUserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }

        public ICollection<BlogPostKeyword> BlogPostKeywords { get; } = new List<BlogPostKeyword>();
    }
}
