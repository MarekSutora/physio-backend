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
    [Produces("application/json")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentsService _appointmentsService;
        private readonly IAuthService _authService;
        private readonly ILogger<AppointmentsController> _logger;

        public AppointmentsController(IAppointmentsService appointmentsService, IAuthService authService, ILogger<AppointmentsController> logger)
        {
            _appointmentsService = appointmentsService;
            _authService = authService;
            _logger = logger;
        }

        [HttpGet("unbooked")]
        public async Task<IActionResult> GetUnbookedAppointmentsAsync()
        {
            try
            {
                var appointments = await _appointmentsService.GetUnbookedAppointmentsAsync();
                return Ok(appointments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri získavaní neobsadených termínov.");
                return BadRequest("Chyba pri získavaní neobsadených termínov.");
            }
        }

        [HttpPost("unbooked")]
        public async Task<IActionResult> CreateAppointmentAsync([FromBody] CreateAppointmentDto createAppointmentDto)
        {
            try
            {
                await _appointmentsService.CreateAppointmentAsync(createAppointmentDto);
                return Ok("Termín úspešne vytvorený.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri vytváraní nového termínu.");
                return BadRequest("Chyba pri vytváraní nového termínu.");
            }
        }


        [HttpPost("booked/{clientId}")]
        public async Task<IActionResult> CreateClientBookedAppointmentAsync(int clientId, [FromBody] CreateBookedAppointmentDto clientBookedAppointmentDto)
        {
            try
            {
                var jwtUserId = User.FindFirstValue("userId");
                var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
                if (!userRoles.Contains("Admin") && !await _authService.VerifyClientByIdAsync(clientId, jwtUserId))
                {
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var userId = User.FindFirst(JwtRegisteredClaimNames.Name)?.Value;
                await _appointmentsService.CreateBookedAppointmentAsync(clientBookedAppointmentDto, userId);
                return Ok("Termín úspešne rezervovaný klientom.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri vytváraní rezervácie klientom.");
                return BadRequest("Chyba pri vytváraní rezervácie klientom.");
            }
        }

        [HttpDelete("booked/{bookedAppointmentId}")]
        public async Task<IActionResult> DeleteBookedAppointmentAsync(int bookedAppointmentId)
        {
            try
            {
                await _appointmentsService.DeleteBookedAppointmentAsync(bookedAppointmentId);
                return Ok("Termín úspešne zrušený.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri zrušení termínu.");
                return StatusCode(500, "Chyba pri zrušení termínu.");
            }
        }

        [HttpDelete("{appointmentId}")]
        public async Task<IActionResult> DeleteAppointmentAsync(int appointmentId)
        {
            try
            {
                await _appointmentsService.DeleteAppointmentAsync(appointmentId);
                return Ok("Termín úspešne vymazaný.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri vymazávaní termínu s Id.");
                return StatusCode(500, "Chyba pri vymazávaní termínu.");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointmentByIdAsync(int id)
        {
            try
            {
                var appointment = await _appointmentsService.GetAppointmentByIdAsync(id);
                if (appointment != null)
                {
                    return Ok(appointment);
                }
                else
                {
                    return NotFound("Termín nebol nájdený.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri získavaní termínu s ID {AppointmentId}", id);
                return StatusCode(500, "Chyba pri získavaní termínu.");
            }
        }

        [HttpPut("{id}/details")]
        public async Task<IActionResult> UpdateAppointmentDetailsAsync(int id, [FromBody] AppointmentDetailDto updateAppointmentExerciseDetailsDto)
        {
            try
            {
                await _appointmentsService.UpdateAppointmentDetailsAsync(id, updateAppointmentExerciseDetailsDto);
                return Ok("Appointment exercise details updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating appointment exercise details.");
                return StatusCode(500, "Failed to update appointment exercise details.");
            }
        }

        [HttpPut("booked/{id}/finish")]
        public async Task<IActionResult> FinishBookedAppointmentAsync(int id)
        {
            try
            {
                await _appointmentsService.FinishBookedAppointmentAsync(id);
                return Ok("Appointment finished successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error finishing appointment.");
                return StatusCode(500, "Failed to finish appointment.");
            }
        }

        [HttpGet("booked")] //todo admin only
        public async Task<IActionResult> GetBookedAppointmentsAsync()
        {
            try
            {
                var bookedAppointments = await _appointmentsService.GetBookedAppointmentsAsync();
                return Ok(bookedAppointments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving booked appointments");
                return BadRequest("Failed to retrieve booked appointments");
            }
        }

        [HttpGet("client/{clientId}/booked")]
        public async Task<IActionResult> GetClientBookedAppointmentsAsync(int clientId)
        {
            try
            {
                var jwtUserId = User.FindFirstValue("userId");
                var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
                if (!userRoles.Contains("Admin") && !await _authService.VerifyClientByIdAsync(clientId, jwtUserId))
                {
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var bookedAppointments = await _appointmentsService.GetBookedAppointmentsAsync(clientId);
                return Ok(bookedAppointments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving booked appointments");
                return BadRequest("Failed to retrieve booked appointments");
            }
        }


        [HttpGet("finished")] //todo admin only
        public async Task<IActionResult> GetAllFinishedAppointmentsAsync()
        {
            try
            {
                var finishedAppointments = await _appointmentsService.GetFinishedAppointmentsAsync();
                return Ok(finishedAppointments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving finished appointments");
                return BadRequest("Failed to retrieve finished appointments");
            }
        }

        [HttpGet("client/{clientId}/finished")]
        public async Task<IActionResult> GetClientFinishedAppointmentsAsync(int clientId)
        {
            try
            {
                var jwtUserId = User.FindFirstValue("userId");
                var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();

                var isAdmin = userRoles.Contains("Admin");
                var isClientVerified = await _authService.VerifyClientByIdAsync(clientId, jwtUserId);

                if (!isAdmin && !isClientVerified)
                {
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var finishedAppointments = await _appointmentsService.GetFinishedAppointmentsAsync(clientId);
                return Ok(finishedAppointments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving finished appointments");
                return BadRequest("Failed to retrieve finished appointments");
            }
        }
    }
}

