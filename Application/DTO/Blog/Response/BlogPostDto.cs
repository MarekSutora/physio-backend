﻿

namespace Application.DTO.Blog.Response
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
        public string Slug { get; set; }
        public int ViewCount { get; set; } = 0;
    }
}
