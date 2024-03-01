using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO.Statistics; // Assuming your DTOs are in this namespace
using System.Threading.Tasks;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet("service-types/monthly")]
        public async Task<IActionResult> GetServiceTypeMonthlyFinishedAppointmentsCountsAsync([FromQuery] int startYear = 2024)
        {
            try
            {
                _logger.LogInformation($"Fetching service type monthly finished appointments counts starting from the year {startYear}.");
                var statistics = await _statisticsService.GetServiceTypeMonthlyFinishedAppointmentsCountsAsync(startYear);
                return Ok(statistics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while fetching service type monthly finished appointments counts starting from the year {startYear}.");
                return StatusCode(500, "An unexpected error occurred. Please try again later.");
            }
        }

    }
}
