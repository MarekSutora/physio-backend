using Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.DTO.Blog.Request;
using Application.DTO.Blog.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Utilities;

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

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetBlogPostsAsync()
        {
            _logger.LogInformation("Retrieving all blog posts.");
            try
            {
                var blogPosts = await _blogService.GetBlogPostsAsync();
                if (blogPosts != null && blogPosts.Any())
                {
                    _logger.LogInformation("All blog posts retrieved successfully.");
                    return Ok(blogPosts);
                }
                else
                {
                    _logger.LogWarning("No blog posts found.");
                    return NotFound("No blog posts found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all blog posts.");
                return BadRequest("Error retrieving all blog posts.");
            }
        }

        [AllowAnonymous]
        [HttpGet("{slug}")]
        public async Task<IActionResult> GetBlogPostBySlugAsync(string slug)
        {
            _logger.LogInformation($"Retrieving blog post with title {slug}");
            try
            {
                var blogPost = await _blogService.GetBlogPostBySlugAsync(slug);
                if (blogPost != null)
                {
                    _logger.LogInformation($"Successfully retrieved blog post for slug = {slug}");
                    return Ok(blogPost);
                }
                else
                {
                    _logger.LogWarning($"Blog post for slug = {slug} not found");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving blog post with title {BlogPostTitle}", slug);
                return BadRequest("An error occurred while retrieving the blog post");
            }
        }

        [AllowAnonymous]
        [HttpGet("non-hidden")]
        public async Task<IActionResult> GetNonHiddenBlogPostsAsync()
        {
            try
            {
                var blogPosts = await _blogService.GetNonHiddenBlogPostsAsync();

                if (blogPosts != null && blogPosts.Any())
                {
                    _logger.LogInformation("Retrieved non-hidden blog posts");
                    return Ok(blogPosts);
                }
                else
                {
                    _logger.LogInformation("No non-hidden blog posts found");
                    return NotFound("No non-hidden blog posts found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving non-hidden blog posts");
                return BadRequest("An error occurred while retrieving the non-hidden blog posts");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateBlogPostAsync([FromBody] CreateBlogPostDto createBlogPostDto)
        {
            _logger.LogInformation("Creating new blog post.");

            try
            {
                await _blogService.CreateBlogPostAsync(createBlogPostDto);

                _logger.LogInformation("Blog post created successfully.");
                return Ok("Nový článok úspešne vytvorený.");
            }
            catch (AlreadyExistsException ex)
            {
                _logger.LogError(ex, "Error creating new blog post.");
                return BadRequest("Článok s týmto názvom už existuje.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating new blog post.");
                return BadRequest("Pri vytváraní článku nastala chyba.");
            }
        }


        [Authorize(Roles = "Admin")]
        [HttpPut("{slug}")]
        public async Task<IActionResult> UpdateBlogPostAsync(string slug, [FromBody] UpdateBlogPostDto updateBlogPostDto)
        {
            _logger.LogInformation($"Updating blog post with BlogPost.Slug = {slug}");
            try
            {
                updateBlogPostDto.Slug = slug;
                await _blogService.UpdateBlogPostAsync(updateBlogPostDto);

                _logger.LogInformation($"Blog post updated successfully with BlogPost.Slug = {slug}");
                return Ok("Blog post updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating blog post with BlogPost.Slug = {slug}");
                return BadRequest("Error updating blog post.");
            }
        }

        [AllowAnonymous]
        [HttpPut("{slug}/increment-view-count")]
        public async Task<IActionResult> IncrementBlogPostViewCountAsync(string slug)
        {
            _logger.LogInformation($"Incrementing blog post view count for slug: {slug}");
            try
            {
                await _blogService.IncrementBlogPostViewCountAsync(slug);

                _logger.LogInformation($"Blog post view count incremented successfully for slug: {slug}");
                return Ok("Blog post view count incremented successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error incrementing blog post view count for slug: {slug}");
                return BadRequest("An error occurred while incrementing the blog post view count");
            }
        }

        [AllowAnonymous]
        [HttpDelete("{slug}")]
        public async Task<IActionResult> DeleteBlogPostAsync(string slug)
        {
            _logger.LogInformation($"Deleting blog post with BlogPost.Slug = {slug}");
            try
            {
                await _blogService.DeleteBlogPostAsync(slug);

                _logger.LogInformation($"Blog post deleted successfully with BlogPost.Slug = {slug}");
                return Ok("Blog post deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when deleting blog post with BlogPost.Slug = {slug}");
                return BadRequest("Error when deleting the blog post");
            }
        }
    }
}
