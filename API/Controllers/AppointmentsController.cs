using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Shared.DTO.Appointments;
using Shared.DTO.Appointments.Request;
using Application.Services.Implementation;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Shared.DTO.Appointments.Response;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentsService _appointmentsService;
        private readonly ILogger<AppointmentsController> _logger;

        public AppointmentsController(IAppointmentsService appointmentsService, ILogger<AppointmentsController> logger)
        {
            _appointmentsService = appointmentsService;
            _logger = logger;
        }

        [HttpGet("unbooked-appointments")]
        public async Task<IActionResult> GetUnbookedAppointmentsAsync()
        {
            try
            {
                var appointments = await _appointmentsService.GetUnbookedAppointmentsAsync();

                // Assuming your service already returns DTOs, you can directly return the result
                return Ok(appointments);
            }
            catch (System.Exception ex)
            {
                // Log the exception and return an appropriate error response
                // This is a simple example, consider using a more detailed error handling strategy
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("unbooked-appointments")]
        public async Task<IActionResult> CreateAppointmentAsync([FromBody] CreateAppointmentDto createAppointmentDto)
        {
            try
            {
                await _appointmentsService.CreateAppointmentAsync(createAppointmentDto);
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception details here
                _logger.LogError(ex, "Error creating Appointment.");
                // Return a generic error message to the client
                return BadRequest("Failed to create Appointment.");
            }
        }

        [HttpGet("booked-appointments")]
        public async Task<IActionResult> GetBookedAppointmentsAsync()
        {
            try
            {
                await _appointmentsService.GetBookedAppointmentsAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating Appointment");
                return BadRequest("Failed to create Appointment");
            }
        }

        [HttpPost("client-booked-appointments")]
        public async Task<IActionResult> CreateClientBookedAppointmentAsync([FromBody] ClientBookedAppointmentDto clientBookedAppointmentDto)
        {

            try
            {
                var User = HttpContext.User;
                var userId = User.FindFirst(JwtRegisteredClaimNames.Name)?.Value;
                await _appointmentsService.ClientCreateBookedAppointmentAsync(clientBookedAppointmentDto, userId);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating Appointment");
                return BadRequest("Failed to create Appointment");
            }
        }

        [HttpPost("admin-booked-appointments")]
        public async Task<IActionResult> CreateAdminBookedAppointmentAsync([FromBody] AdminBookedAppointmentDto adminBookedAppointmentDto)
        {
            try
            {
                await _appointmentsService.AdminCreateBookedAppointmentAsync(adminBookedAppointmentDto);
                return Ok("Admin booked appointment successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error booking appointment by admin.");
                return StatusCode(500, "Failed to book appointment by admin.");
            }
        }

        [HttpPut("booked-appointments/{bookedAppointmentId}")]
        public async Task<IActionResult> CancelAppointmentAsync(int bookedAppointmentId)
        {
            try
            {
                CancelBookedAppointmentDto cancelBookedAppointmentDto = new CancelBookedAppointmentDto
                {
                    BookedAppointmentId = bookedAppointmentId
                };

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get userId from claims
                var isAdmin = User.IsInRole("Admin"); // Check if user is in Admin role

                await _appointmentsService.CancelAppointmentAsync(cancelBookedAppointmentDto, userId, isAdmin);
                return Ok("Appointment cancelled successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.LogWarning(ex, "Unauthorized attempt to cancel appointment.");
                return Unauthorized("You are not authorized to cancel this appointment.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error cancelling appointment.");
                return StatusCode(500, "Failed to cancel appointment.");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAppointmentAsync([FromBody] DeleteAppointmentDto deleteAppointmentDto)
        {
            try
            {
                await _appointmentsService.DeleteAppointmentAsync(deleteAppointmentDto);
                return Ok("Appointment deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting appointment.");
                return StatusCode(500, "Failed to delete appointment.");
            }
        }
    }
}

