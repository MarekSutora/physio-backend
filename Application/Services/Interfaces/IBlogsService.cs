using Shared.DTO.Blog.Request;
using Shared.DTO.Blog.Response;

namespace Application.Services.Interfaces
{
    public interface IBlogsService
    {
        Task<IEnumerable<BlogPostDto>> GetBlogPostsAsync();
        Task CreateBlogPostAsync(CreateBlogPostDto createBlogPostDto);
        Task UpdateBlogPostAsync(UpdateBlogPostDto updateBlogPostDto);
        Task DeleteBlogPostAsync(DeleteBlogPostDto deleteBlogPostDto);
        Task HideBlogPostAsync(HideBlogPostDto hideBlogPostDto);
        Task<BlogPostDto> GetBlogPostByIdAsync(int id);
        Task<BlogPostDto> GetBlogPostBySlugAsync(string slug);
        Task<IEnumerable<BlogPostDto>> GetNonHiddenBlogPostsAsync();
        Task IncrementBlogPostViewCountAsync(string slug);
    }
}
