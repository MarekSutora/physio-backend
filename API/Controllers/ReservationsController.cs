using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Shared.DTO.Reservations;
using Shared.DTO.Reservations.Request;
using Application.Services.Implementation;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationsService _reservationsService;
        private readonly ILogger<ReservationsController> _logger;

        public ReservationsController(IReservationsService reservationsService, ILogger<ReservationsController> logger)
        {
            _reservationsService = reservationsService;
            _logger = logger;
        }

        // GET /api/available-reservations
        [HttpGet("available-reservations")]
        public async Task<IActionResult> GetAvailableReservations()
        {
            try
            {
                var availableReservations = await _reservationsService.GetAvailableReservationsAsync();

                // Assuming your service already returns DTOs, you can directly return the result
                return Ok(availableReservations);
            }
            catch (System.Exception ex)
            {
                // Log the exception and return an appropriate error response
                // This is a simple example, consider using a more detailed error handling strategy
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("available-reservations")]
        public async Task<IActionResult> CreateAvailableReservation([FromBody] CreateAvailableReservationDto createAvailableReservationDto)
        {
            try
            {
                var result = await _reservationsService.CreateAvailableReservationAsync(createAvailableReservationDto);
                if (result)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Failed to create reservation");
                }
            }
            catch (Exception ex)
            {
                // Log the exception details here
                _logger.LogError(ex, "Error creating reservation");
                // Return a generic error message to the client
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}

