using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.DTO.Blog.Request;
using Shared.DTO.Blog.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace diploma_thesis_backend.Controllers
{
    [Route("/blog-posts")]
    [ApiController]
    [Produces("application/json")]
    public class BlogPostsController : ControllerBase
    {
        private readonly IBlogsService _blogService;
        private readonly ILogger<BlogPostsController> _logger;

        public BlogPostsController(IBlogsService blogService, ILogger<BlogPostsController> logger)
        {
            _blogService = blogService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlogPost([FromBody] CreateBlogPostDto createBlogPostDto)
        {
            try
            {
                await _blogService.CreateBlogPostAsync(createBlogPostDto);
                return Ok("Blog post created successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating blog post");
                return StatusCode(500, "An error occurred while creating the blog post");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlogPost(int id, [FromBody] UpdateBlogPostDto updateBlogPostDto)
        {
            try
            {
                updateBlogPostDto.Id = id; // Ensure the ID is set correctly
                await _blogService.UpdateBlogPostAsync(updateBlogPostDto);
                return Ok("Blog post updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating blog post");
                return StatusCode(500, "An error occurred while updating the blog post");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogPosts()
        {
            try
            {
                IEnumerable<BlogPostDto> blogPosts = await _blogService.GetBlogPostsAsync();
                return Ok(blogPosts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving blog posts");
                return StatusCode(500, "An error occurred while retrieving the blog posts");
            }
        }

        [HttpPost("hide/{id}")]
        public async Task<IActionResult> HideBlogPost(int id)
        {
            try
            {
                var hideBlogPostDto = new HideBlogPostDto { Id = id };
                await _blogService.HideBlogPostAsync(hideBlogPostDto);
                return Ok("Blog post hidden successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error hiding blog post");
                return StatusCode(500, "An error occurred while hiding the blog post");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogPost(int id)
        {
            try
            {
                var deleteBlogPostDto = new DeleteBlogPostDto { Id = id };
                await _blogService.DeleteBlogPostAsync(deleteBlogPostDto);
                return Ok("Blog post deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting blog post");
                return StatusCode(500, "An error occurred while deleting the blog post");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogPostById(int id)
        {
            try
            {
                var blogPost = await _blogService.GetBlogPostByIdAsync(id);
                if (blogPost != null)
                {
                    return Ok(blogPost);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving blog post with ID {BlogPostId}", id);
                return StatusCode(500, "An error occurred while retrieving the blog post");
            }
        }

        [HttpGet("by-slug/{slug}")]
        public async Task<IActionResult> GetBlogPostBySlugAsync(string slug)
        {
            try
            {
                var blogPost = await _blogService.GetBlogPostBySlugAsync(slug);
                if (blogPost != null)
                {
                    return Ok(blogPost);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving blog post with title {BlogPostTitle}", slug);
                return StatusCode(500, "An error occurred while retrieving the blog post");
            }
        }

        [HttpGet("non-hidden")]
        public async Task<IActionResult> GetNonHiddenBlogPosts()
        {
            try
            {
                IEnumerable<BlogPostDto> blogPosts = await _blogService.GetNonHiddenBlogPostsAsync();
                return Ok(blogPosts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving non-hidden blog posts");
                return StatusCode(500, "An error occurred while retrieving the non-hidden blog posts");
            }
        }

        [HttpPut("{slug}/increment-view-count")]
        public async Task<IActionResult> IncrementBlogPostViewCount(string slug)
        {
            try
            {
                await _blogService.IncrementBlogPostViewCountAsync(slug);
                return Ok("Blog post view count incremented successfully.");
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogError(ex, "Blog post not found for slug: {Slug}", slug);
                return NotFound("Blog post not found.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error incrementing blog post view count for slug: {Slug}", slug);
                return StatusCode(500, "An error occurred while incrementing the blog post view count");
            }
        }

    }
}
