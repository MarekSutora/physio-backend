using Application.DTO.Blog.Request;
using Application.Services.Interfaces;
using Application.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
                    return NotFound("Žiadne články neboli nájdené.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all blog posts.");
                return BadRequest("Chyba pri načítavaní všetkých článkov.");
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
                    return NotFound($"Článok nebol nájdený.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving blog post with title {BlogPostTitle}", slug);
                return BadRequest("Pri načítavaní článku došlo k chybe.");
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
                    return NotFound("Neboli nájdené žiadne ne-skryté články.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving non-hidden blog posts");
                return BadRequest("Pri načítavaní ne-skrytých článkov došlo k chybe.");
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
                return Ok("Článok bol úspešne aktualizovaný.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating blog post with BlogPost.Slug = {slug}");
                return BadRequest("Pri aktualizácii článku došlo k chybe.");
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
                return Ok("Počet zobrazení článku bol úspešne zvýšený.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error incrementing blog post view count for slug: {slug}");
                return BadRequest("Pri zvyšovaní počtu zobrazení článku došlo k chybe.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{slug}")]
        public async Task<IActionResult> DeleteBlogPostAsync(string slug)
        {
            _logger.LogInformation($"Deleting blog post with BlogPost.Slug = {slug}");
            try
            {
                await _blogService.DeleteBlogPostAsync(slug);

                _logger.LogInformation($"Blog post deleted successfully with BlogPost.Slug = {slug}");
                return Ok("Článok bol úspešne vymazaný.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when deleting blog post with BlogPost.Slug = {slug}");
                return BadRequest("Pri mazaní článku došlo k chybe.");
            }
        }
    }
}
