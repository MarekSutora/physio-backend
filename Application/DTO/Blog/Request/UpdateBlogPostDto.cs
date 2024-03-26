using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Blog.Request
{
    public class UpdateBlogPostDto
    {
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string HTMLContent { get; set; }
        public string KeywordsString { get; set; }
        public string Author { get; set; }
        public string MainImageUrl { get; set; }
        public string Slug { get; set; }
        public bool IsHidden { get; set; }
    }
}
