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
        [Required(ErrorMessage = "The title of the blog post is required.")]
        [StringLength(100, ErrorMessage = "The title must be less than 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The date when the blog post is published is required.")]
        public DateTime DatePublished { get; set; }

        [Required(ErrorMessage = "The HTML content of the blog post is required.")]
        public string HTMLContent { get; set; }

        [Required(ErrorMessage = "The author of the blog post is required.")]
        [StringLength(100, ErrorMessage = "The author's name must be less than 100 characters.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Keywords for the blog post are required.")]
        [StringLength(300, ErrorMessage = "The keywords string must be less than 300 characters.")]
        public string KeywordsString { get; set; }

        [Required(ErrorMessage = "The main image URL for the blog post is required.")]
        public string MainImageUrl { get; set; }

        public bool IsHidden { get; set; } = false;
    }
}
