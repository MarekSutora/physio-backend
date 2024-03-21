using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Shared.DTO.Appointments.Request;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Shared.DTO.Appointments.Response;
using Microsoft.AspNetCore.Authorization;

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

        [AllowAnonymous]
        [HttpGet("unbooked")]
        public async Task<IActionResult> GetUnbookedAppointmentsAsync()
        {
            _logger.LogInformation("Retrieving unbooked appointments.");
            try
            {
                var appointments = await _appointmentsService.GetUnbookedAppointmentsAsync();

                if (appointments != null && appointments.Any())
                {
                    _logger.LogInformation("Unbooked appointments retrieved successfully.");
                    return Ok(appointments);
                }
                else
                {
                    _logger.LogInformation("No unbooked appointments found.");
                    return NotFound("No unbooked appointments found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when retrieving unbooked appointments.");
                return BadRequest("Error when retrieving unbooked appointments.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("unbooked")]
        public async Task<IActionResult> CreateAppointmentAsync([FromBody] CreateAppointmentDto createAppointmentDto)
        {
            _logger.LogInformation("Creating new appointment.");
            try
            {
                await _appointmentsService.CreateAppointmentAsync(createAppointmentDto);
                return Ok("New appointment successfully created.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when creating new appointment.");
                return BadRequest("Error when creating new appointment.");
            }
        }

        [Authorize]
        [HttpPost("booked/{clientId}")]
        public async Task<IActionResult> CreateClientBookedAppointmentAsync(int clientId, [FromBody] CreateBookedAppointmentDto clientBookedAppointmentDto)
        {
            _logger.LogInformation($"Retrieving booked appointments for Client with Client.Id = {clientId}.");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(clientId))
                {
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                await _appointmentsService.CreateBookedAppointmentAsync(clientBookedAppointmentDto, clientId);
                return Ok("Termín úspešne rezervovaný klientom.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when retrieving booked appointments for Client with ClientId = {clientId}.");
                return BadRequest("Error when retrieving booked appointments.");
            }
        }

        [Authorize]
        [HttpDelete("booked/{bookedAppointmentId}")]
        public async Task<IActionResult> DeleteBookedAppointmentAsync(int bookedAppointmentId)
        {
            _logger.LogInformation($"Deleting booked appointment with BookedAppointment.Id = {bookedAppointmentId}.");
            try
            {
                await _appointmentsService.DeleteBookedAppointmentAsync(bookedAppointmentId);
                return Ok("Termín úspešne zrušený.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when deleting booked appointment with BookedAppointment.Id = {bookedAppointmentId}.");
                return BadRequest("Error when deleting booked appointment.");
            }
        }

        [Authorize]
        [HttpDelete("{appointmentId}")]
        public async Task<IActionResult> DeleteAppointmentAsync(int appointmentId)
        {
            _logger.LogInformation($"Deleting appointment with Appointment.Id = {appointmentId}.");
            try
            {
                await _appointmentsService.DeleteAppointmentAsync(appointmentId);
                return Ok("Termín úspešne vymazaný.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when deleting appointment with Appointment.Id = {appointmentId}.");
                return BadRequest("Error when deleting appointment");
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointmentByIdAsync(int id)
        {
            _logger.LogInformation($"Retrieving appointment with Appointment.Id = {id}");
            try
            {
                var appointment = await _appointmentsService.GetAppointmentByIdAsync(id);
                if (appointment != null)
                {
                    _logger.LogInformation($"Appointment with Appointment.Id = {id} retrieved successfully.");
                    return Ok(appointment);
                }
                else
                {
                    _logger.LogInformation($"Appointment with Appointment.Id = {id} not found.");
                    return NotFound("Termín nebol nájdený.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when retrieving appointment with Appointment.Id = {id}");
                return BadRequest("Error when retrieving appointment");
            }
        }

        [Authorize]
        [HttpPut("{id}/details")]
        public async Task<IActionResult> UpdateAppointmentDetailsAsync(int id, [FromBody] AppointmentDetailDto appointmentDetailDto)
        {
            _logger.LogInformation($"Updating appointment details for appointment with Appointment.Id = {id}.");
            try
            {
                await _appointmentsService.UpdateAppointmentDetailsAsync(id, appointmentDetailDto);
                return Ok("Appointment exercise details updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when updating appointment details for appointment with Appointment.Id = {id}");
                return BadRequest("Error when updating appointment details");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("booked/{id}/finish")]
        public async Task<IActionResult> FinishBookedAppointmentAsync(int id)
        {
            _logger.LogInformation($"Finishing booked appointment with BookedAppointment.Id = {id}.");
            try
            {
                await _appointmentsService.FinishBookedAppointmentAsync(id);
                return Ok("Appointment finished successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error finishing booked appointment with BookedAppointment.Id = {id}.");
                return BadRequest("Error finishing booked appointment.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("booked")]
        public async Task<IActionResult> GetBookedAppointmentsAsync()
        {
            _logger.LogInformation("Retrieving booked appointments.");
            try
            {
                var bookedAppointments = await _appointmentsService.GetBookedAppointmentsAsync();

                if (bookedAppointments != null && bookedAppointments.Any())
                {
                    _logger.LogInformation("Booked appointments retrieved successfully.");
                    return Ok(bookedAppointments);
                }
                else
                {
                    _logger.LogInformation("No booked appointments found.");
                    return NotFound("No booked appointments found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving booked appointments.");
                return BadRequest("Error retrieving booked appointments.");
            }
        }

        [Authorize]
        [HttpGet("client/{clientId}/booked")]
        public async Task<IActionResult> GetClientBookedAppointmentsAsync(int clientId)
        {
            _logger.LogInformation($"Retrieving booked appointments for client with Client.Id = {clientId}");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(clientId))
                {
                    _logger.LogWarning($"User with userId = {User.FindFirstValue("userId")} is not authorized to view booked appointments for client with Client.Id = {clientId}");
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var bookedAppointments = await _appointmentsService.GetBookedAppointmentsAsync(clientId);

                if (bookedAppointments != null && bookedAppointments.Any())
                {
                    _logger.LogInformation($"Booked appointments for client with Client.Id = {clientId} successfully returned");
                    return Ok(bookedAppointments);
                }
                else
                {
                    _logger.LogInformation($"No booked appointments found for client with Client.Id = {clientId}");
                    return NotFound("No booked appointments found.");
                }
            }
            catch (Exception ex)
            {
                var ErrorMessage = "Error retrieving booked appointments.";
                _logger.LogError(ex, ErrorMessage);
                return BadRequest(ErrorMessage);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("finished")]
        public async Task<IActionResult> GetAllFinishedAppointmentsAsync()
        {
            _logger.LogInformation("Retrieving finished appointments.");
            try
            {
                var finishedAppointments = await _appointmentsService.GetFinishedAppointmentsAsync();

                if (finishedAppointments != null && finishedAppointments.Any())
                {
                    _logger.LogInformation("Finished appointments retrieved successfully.");
                    return Ok(finishedAppointments);
                }
                else
                {
                    _logger.LogWarning("No finished appointments found.");
                    return NotFound("No finished appointments found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving finished appointments.");
                return BadRequest("Error retrieving finished appointments.");
            }
        }

        [Authorize]
        [HttpGet("client/{clientId}/finished")]
        public async Task<IActionResult> GetClientsFinishedAppointmentsAsync(int clientId)
        {
            _logger.LogInformation($"Retrieving finished appointments for client with Client.Id = {clientId}");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(clientId))
                {
                    _logger.LogWarning($"User with userId = {User.FindFirstValue("userId")} is not authorized to view finished appointments for client with Client.Id = {clientId}");
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var finishedAppointments = await _appointmentsService.GetFinishedAppointmentsAsync(clientId);

                if (finishedAppointments != null && finishedAppointments.Any())
                {
                    _logger.LogInformation($"Finished appointments for client with Client.Id = {clientId} successfully returned");
                    return Ok(finishedAppointments);
                }
                else
                {
                    _logger.LogWarning($"No finished appointments found for client with Client.Id = {clientId}");
                    return NotFound("No finished appointments found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving finished appointments for client with Client.Id = {clientId}.");
                return BadRequest("Error retrieving finished appointments.");
            }
        }

        private bool IsAdminOrAccessingTheirOwnData(int clientId)
        {
            var jwtUserId = User.FindFirstValue("userId");

            if (jwtUserId == null)
            {
                return false;
            }

            var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
            var isAdmin = userRoles.Contains("Admin");
            var isClientVerified = _authService.VerifyClientByIdAsync(clientId, jwtUserId).Result;
            return isAdmin || isClientVerified;
        }
    }
}

