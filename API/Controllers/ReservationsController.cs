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

        // GET reservations?available=true&activityTypes=true
        [HttpGet]
        public async Task<IActionResult> GetReservations([FromQuery] bool available, [FromQuery] bool activityTypes)
        {
            if (available && activityTypes)
            {
                // Logic to get reservations that are available and include their associated activity types
                var reservationsWithActivities = await _reservationService.GetAvailableReservationsWithActivityTypesAsync();

                if (reservationsWithActivities.Any())
                {
                    return Ok(reservationsWithActivities);
                }
                else
                {
                    return NotFound("No available reservations with activity types found.");
                }
            }

            // If both query parameters are not true, you can decide what to do,
            // such as returning all reservations, returning a BadRequest, etc.
            return BadRequest("Both 'available' and 'activityTypes' must be set to true.");
        }
    }
}
