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
        public string Title { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<BlogKeyword> BlogKeywordss { get; } = new List<BlogKeyword>();
    }
}
