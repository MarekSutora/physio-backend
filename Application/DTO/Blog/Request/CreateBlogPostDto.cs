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
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title must be less than or equal to 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Date published is required.")]
        public DateTime DatePublished { get; set; }
        [Required(ErrorMessage = "HTML content is required.")]
        public string HTMLContent { get; set; }
        [Required(ErrorMessage = "Author is required.")]
        [StringLength(100, ErrorMessage = "Author must be less than or equal to 100 characters.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Keywords string is required.")]
        [StringLength(300, ErrorMessage = "Keywords string must be less than or equal to 300 characters.")]
        public string KeywordsString { get; set; }
        [Required(ErrorMessage = "Main image URL is required.")]
        public string MainImageUrl { get; set; }
        public bool IsHidden { get; set; } = false;
    }
}
