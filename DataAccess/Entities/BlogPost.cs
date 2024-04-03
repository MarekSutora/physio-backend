using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string HTMLContent { get; set; }
        public string Author { get; set; }
        public string KeywordsString { get; set; }
        public string MainImageUrl { get; set; }
        public bool IsHidden { get; set; } = false;
        public int ViewCount { get; set; } = 0;
    }
}
