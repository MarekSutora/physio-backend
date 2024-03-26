using Application.DTO.Blog.Request;
using Application.DTO.Blog.Response;

namespace Application.Services.Interfaces
{
    public interface IBlogsService
    {
        Task<IEnumerable<BlogPostDto>> GetBlogPostsAsync();
        Task CreateBlogPostAsync(CreateBlogPostDto createBlogPostDto);
        Task UpdateBlogPostAsync(UpdateBlogPostDto updateBlogPostDto);
        Task DeleteBlogPostAsync(string slug);
        Task<BlogPostDto?> GetBlogPostBySlugAsync(string slug);
        Task<IEnumerable<BlogPostDto>> GetNonHiddenBlogPostsAsync();
        Task IncrementBlogPostViewCountAsync(string slug);
    }
}
