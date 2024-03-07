﻿using System.Threading.Tasks;
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

        [HttpPost("unbooked")]
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

        [HttpDelete("booked/{bookedAppointmentId}")]
        public async Task<IActionResult> DeleteBookedAppointmentAsync(int bookedAppointmentId)
        {
            try
            {
                await _appointmentsService.DeleteBookedAppointmentAsync(bookedAppointmentId);
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

        [HttpDelete("{appointmentId}")]
        public async Task<IActionResult> DeleteAppointmentAsync(int appointmentId)
        {
            try
            {
                await _appointmentsService.DeleteAppointmentAsync(appointmentId);
                return Ok("Appointment deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting appointment.");
                return StatusCode(500, "Failed to delete appointment.");
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
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving appointment with ID {AppointmentId}", id);
                return StatusCode(500, "An error occurred while retrieving the appointment");
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
                if (!userRoles.Contains("Admin") && !await _authService.VerifyClientById(clientId, jwtUserId))
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
                var isClientVerified = await _authService.VerifyClientById(clientId, jwtUserId);

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

