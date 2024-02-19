using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.Blog.Response
{
    public class BlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string HTMLContent { get; set; }
        public string KeywordsString { get; set; }
        public string Author { get; set; }
        public string MainImageUrl { get; set; }
        public bool IsHidden { get; set; } = false;
    }
}
