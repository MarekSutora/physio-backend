using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Application.DTO.Appointments.Request;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Application.DTO.Appointments.Response;
using Microsoft.AspNetCore.Authorization;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("appointments")]
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

        //[AllowAnonymous]
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

        [Authorize]
        [HttpGet("{appointmentId}")]
        public async Task<IActionResult> GetAppointmentByIdAsync(int appointmentId)
        {
            _logger.LogInformation($"Retrieving appointment with Appointment.Id = {appointmentId}.");
            try
            {
                var jwtUserId = User.FindFirstValue("userId");

                if (jwtUserId == null)
                {
                    return Unauthorized("You are not authorized to view this appointment.");
                }

                var appointment = await _appointmentsService.GetAppointmentByIdAsync(appointmentId, jwtUserId);
                if (appointment != null)
                {
                    _logger.LogInformation($"Appointment with Appointment.Id = {appointmentId} retrieved successfully.");
                    return Ok(appointment);
                }
                else
                {
                    _logger.LogInformation($"Appointment with Appointment.Id = {appointmentId} not found.");
                    return NotFound("Termín nebol nájdený.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.LogWarning(ex, $"User with userId = {User.FindFirstValue("userId")} is not authorized to view appointment with Appointment.Id = {appointmentId}");
                return Unauthorized("You are not authorized to view this appointment.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when retrieving appointment with Appointment.Id = {appointmentId}");
                return BadRequest("Error when retrieving appointment.");
            }
        }


        [Authorize]
        [HttpGet("clients/{personId}/booked")]
        public async Task<IActionResult> GetClientBookedAppointmentsAsync(int personId)
        {
            _logger.LogInformation($"Retrieving booked appointments for Client with Person.Id = {personId}");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(personId))
                {
                    _logger.LogWarning($"User with userId = {User.FindFirstValue("userId")} is not authorized to view booked appointments for Client with Person.Id = {personId}");
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var bookedAppointments = await _appointmentsService.GetBookedAppointmentsAsync(personId);

                if (bookedAppointments != null && bookedAppointments.Any())
                {
                    _logger.LogInformation($"Booked appointments for Client with Person.Id = {personId} successfully returned");
                    return Ok(bookedAppointments);
                }
                else
                {
                    _logger.LogInformation($"No booked appointments found for Client with Person.Id = {personId}");
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
        public async Task<IActionResult> GetFinishedAppointmentsAsync()
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
        [HttpGet("clients/{personId}/finished")]
        public async Task<IActionResult> GetClientsFinishedAppointmentsAsync(int personId)
        {
            _logger.LogInformation($"Retrieving finished appointments for Person with Person.Id = {personId}");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(personId))
                {
                    _logger.LogWarning($"User with userId = {User.FindFirstValue("userId")} is not authorized to view finished appointments for Person with Person.Id = {personId}");
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var finishedAppointments = await _appointmentsService.GetFinishedAppointmentsAsync(personId);

                if (finishedAppointments != null && finishedAppointments.Any())
                {
                    _logger.LogInformation($"Finished appointments for Client with Person.Id = {personId} successfully returned");
                    return Ok(finishedAppointments);
                }
                else
                {
                    _logger.LogWarning($"No finished appointments found for Client with Person.Id = {personId}");
                    return NotFound("No finished appointments found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving finished appointments for Client with Person.Id = {personId}.");
                return BadRequest("Error retrieving finished appointments.");
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

        [Authorize(Roles = "Admin")]
        [HttpPost("unbooked")]
        public async Task<IActionResult> CreateAppointmentAsync([FromBody] CreateAppointmentDto createAppointmentDto)
        {
            _logger.LogInformation("Creating new appointment.");

            try
            {
                await _appointmentsService.CreateAppointmentAsync(createAppointmentDto);

                _logger.LogInformation("New appointment successfully created.");
                return Ok("New appointment successfully created.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when creating new appointment.");
                return BadRequest("Error when creating new appointment.");
            }
        }

        [Authorize]
        [HttpPost("booked/{personId}")]
        public async Task<IActionResult> CreateClientBookedAppointmentAsync(int personId, [FromBody] CreateBookedAppointmentDto createBookedAppointmentDto)
        {
            _logger.LogInformation($"Retrieving booked appointments for Client with Person.Id = {personId}.");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(personId))
                {
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                await _appointmentsService.CreateBookedAppointmentAsync(createBookedAppointmentDto, personId);

                _logger.LogInformation($"Booked appointment for Client with Person.Id = {personId} created successfully.");
                return Ok("Termín úspešne rezervovaný klientom.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when retrieving booked appointments for Client with Person.Id = {personId}.");
                return BadRequest("Error when retrieving booked appointments.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}/details")]
        public async Task<IActionResult> UpdateAppointmentDetailsAsync(int id, [FromBody] AppointmentDetailDto appointmentDetailDto)
        {
            _logger.LogInformation($"Updating appointment details for appointment with Appointment.Id = {id}.");
            try
            {
                await _appointmentsService.UpdateAppointmentDetailsAsync(id, appointmentDetailDto);

                _logger.LogInformation($"Appointment details for appointment with Appointment.Id = {id} updated successfully.");
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

                _logger.LogInformation($"Booked appointment with BookedAppointment.Id = {id} finished successfully.");
                return Ok("Appointment finished successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error finishing booked appointment with BookedAppointment.Id = {id}.");
                return BadRequest("Error finishing booked appointment.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("booked/{bookedAppointmentId}")]
        public async Task<IActionResult> DeleteBookedAppointmentAsync(int bookedAppointmentId)
        {
            _logger.LogInformation($"Deleting booked appointment with BookedAppointment.Id = {bookedAppointmentId}.");
            try
            {
                await _appointmentsService.DeleteBookedAppointmentAsync(bookedAppointmentId);

                _logger.LogInformation($"Booked appointment with BookedAppointment.Id = {bookedAppointmentId} deleted successfully.");
                return Ok("Termín úspešne zrušený.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when deleting booked appointment with BookedAppointment.Id = {bookedAppointmentId}.");
                return BadRequest("Error when deleting booked appointment.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{appointmentId}")]
        public async Task<IActionResult> DeleteAppointmentAsync(int appointmentId)
        {
            _logger.LogInformation($"Deleting appointment with Appointment.Id = {appointmentId}.");
            try
            {
                await _appointmentsService.DeleteAppointmentAsync(appointmentId);

                _logger.LogInformation($"Appointment with Appointment.Id = {appointmentId} deleted successfully.");
                return Ok("Termín úspešne vymazaný.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when deleting appointment with Appointment.Id = {appointmentId}.");
                return BadRequest("Error when deleting appointment");
            }
        }

        private bool IsAdminOrAccessingTheirOwnData(int personId)
        {
            var jwtUserId = User.FindFirstValue("userId");

            if (jwtUserId == null)
            {
                return false;
            }

            var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
            var isAdmin = userRoles.Contains("Admin");
            var isClientVerified = _authService.VerifyClientByIdAsync(personId, jwtUserId).Result;
            return isAdmin || isClientVerified;
        }
    }
}

