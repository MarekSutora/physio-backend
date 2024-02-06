using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Shared.DTO.Reservations;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationsService _reservationService;

        public ReservationsController(IReservationsService reservationService)
        {
            _reservationService = reservationService;
        }

        // GET /available-reservations
        [HttpGet("available-reservations")]
        public async Task<IActionResult> GetAvailableReservations()
        {
            try
            {
                var reservationsWithActivities = await _reservationService.GetAvailableReservationsWithServiceTypesAsync();

                if (reservationsWithActivities.Any())
                {
                    return Ok(reservationsWithActivities);
                }
                else
                {
                    return NotFound("No available reservations with service types found.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception details here

                // Return a generic error message to the client
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation([FromBody] CreateReservationDto createReservationDto)
        {
            try
            {
                var result = await _reservationService.CreateReservationAsync(createReservationDto);
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

                // Return a generic error message to the client
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}
