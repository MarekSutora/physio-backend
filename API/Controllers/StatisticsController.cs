using Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace diploma_thesis_backend.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("statistics")]
    [Produces("application/json")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;
        private readonly ILogger<StatisticsController> _logger;

        public StatisticsController(IStatisticsService statisticsService, ILogger<StatisticsController> logger)
        {
            _statisticsService = statisticsService;
            _logger = logger;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("appointments-service-types")]
        public async Task<IActionResult> GetServiceTypesFinishedAppointmentsCountsAsync()
        {
            _logger.LogInformation("Fetching service type monthly finished appointments counts for all time (statistics).");
            try
            {
                var statistics = await _statisticsService.GetServiceTypesFinishedAppointmentsCountsAsync();

                if (statistics != null && statistics.Any())
                {
                    _logger.LogInformation("Service type monthly finished appointments counts successfully retrieved.");
                    return Ok(statistics);
                }
                else
                {
                    _logger.LogInformation("No service type monthly finished appointments counts found.");
                    return NotFound("Nenašli sa žiadne údaje o počte dokončených stretnutí podľa typov služieb za mesiac.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching service type monthly finished appointments counts.");
                return BadRequest("Chyba pri získavaní štatistík služieb.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("revenue")]
        public async Task<IActionResult> GetTotalRevenueStatisticsAsync()
        {
            _logger.LogInformation("Fetching total revenue statistics for all finished appointments.");
            try
            {
                var revenueStatistics = await _statisticsService.GetTotalRevenueStatisticsAsync();

                if (revenueStatistics != null)
                {
                    _logger.LogInformation("Total revenue statistics successfully retrieved.");
                    return Ok(revenueStatistics);
                }
                else
                {
                    _logger.LogInformation("No total revenue statistics found.");
                    return NotFound("Nenašli sa žiadne štatistiky celkových príjmov.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching total revenue statistics.");
                return BadRequest("Chyba pri získavaní štatistík celkových príjmov.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("new-clients-trend")]
        public async Task<IActionResult> GetNewClientsTrendAsync()
        {
            _logger.LogInformation("Fetching new clients trend statistics.");
            try
            {
                var newClientsTrend = await _statisticsService.GetNewClientsTrendAsync();

                if (newClientsTrend != null && newClientsTrend.Any())
                {
                    _logger.LogInformation("New clients trend statistics successfully retrieved.");
                    return Ok(newClientsTrend);
                }
                else
                {
                    _logger.LogInformation("No new clients trend statistics found.");
                    return NotFound("Nenašli sa žiadne štatistiky trendov nových klientov.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching new clients trend.");
                return BadRequest("Chyba pri získavaní štatistík trendu nových klientov.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("blog-posts-views")]
        public async Task<IActionResult> GetBlogPostViewsStatsAsync()
        {
            _logger.LogInformation("Fetching blog post views statistics.");
            try
            {
                var blogPostViewsStats = await _statisticsService.GetBlogPostViewsStatsAsync();

                if (blogPostViewsStats != null && blogPostViewsStats.Any())
                {
                    _logger.LogInformation("Blog post views statistics successfully retrieved.");
                    return Ok(blogPostViewsStats);
                }
                else
                {
                    _logger.LogInformation("No blog post views statistics found.");
                    return NotFound("Nenašli sa žiadne štatistiky zobrazení článkov blogu.");

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching blog post views statistics.");
                return BadRequest("Chyba pri získavaní štatistík zobrazení článkov blogu.");
            }
        }
    }
}
