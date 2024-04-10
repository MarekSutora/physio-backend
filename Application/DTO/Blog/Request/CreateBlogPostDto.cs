
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Blog.Request
{
    public class CreateBlogPostDto
    {
        [Required(ErrorMessage = "Attribute Title is required.")]
        [StringLength(100, ErrorMessage = "Attribute Title must be less than or equal to 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Attribute DatePublished is required.")]
        public DateTime DatePublished { get; set; }
        [Required(ErrorMessage = "Attribute HTMLContent is required.")]
        public string HTMLContent { get; set; }
        [Required(ErrorMessage = "Attribute Author is required.")]
        [StringLength(100, ErrorMessage = "Attribute Author must be less than or equal to 100 characters.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Attribute KeywordsString is required.")]
        [StringLength(300, ErrorMessage = "Keywords KeywordsString be less than or equal to 300 characters.")]
        public string KeywordsString { get; set; }
        [Required(ErrorMessage = "Attribute MainImageURL is required.")]
        public string MainImageUrl { get; set; }
        public bool IsHidden { get; set; } = false;
    }
}
