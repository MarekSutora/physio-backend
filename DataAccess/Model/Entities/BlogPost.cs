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
        public required string Slug { get; set; }
        public required DateTime DatePublished { get; set; }
        public required string HTMLContent { get; set; }
        public required string Author { get; set; }
        public required string KeywordsString { get; set; }
        public required string MainImageUrl { get; set; }
        public required bool IsHidden { get; set; } = false;
        public int ViewCount { get; set; } = 0;
    }
}
