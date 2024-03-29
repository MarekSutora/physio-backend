using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Blog.Request
{
    public class CreateBlogPostDto
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }

        [Required]
        public string HTMLContent { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [StringLength(300)]
        public string KeywordsString { get; set; }

        [Required]
        public string MainImageUrl { get; set; }

        public bool IsHidden { get; set; } = false;
    }
}
