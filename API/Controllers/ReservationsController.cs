using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;

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
    }
}
