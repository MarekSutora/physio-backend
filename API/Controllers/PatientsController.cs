
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Application.Services.Implementation;
using Shared.DTO.Patients.Request;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace diploma_thesis_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    //[Authorize(Roles = "Admin")]
    public class PatientsController : Controller
    {
        private readonly IPatientsService _patientsService;
        private readonly IAuthService _authService;
        public readonly ILogger<PatientsController> _logger;

        public PatientsController(IPatientsService patientService, IAuthService authService, ILogger<PatientsController> logger)
        {
            _patientsService = patientService;
            _authService = authService;
            _logger = logger;
        }

        [HttpPost("{patientId}/notes")]
        public async Task<IActionResult> AddNoteToPatient(int patientId, [FromBody] CreatePatientNoteDto createPatientNoteDto)
        {
            try
            {
                if (patientId != createPatientNoteDto.PatientId)
                {
                    return BadRequest("Mismatched patient ID.");
                }

                await _patientsService.AddNoteToPatientAsync(createPatientNoteDto);
                return Ok("Note added successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding note to patient");
                return StatusCode(500, "Error adding note to patient");
            }
        }

        [HttpGet("{patientId}/notes")]
        public async Task<IActionResult> GetAllNotesForPatient(int patientId)
        {
            try
            {
                var notes = await _patientsService.GetAllNotesForPatient(patientId);
                return Ok(notes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving notes for patient");
                return StatusCode(500, "Error retrieving notes for patient");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            try
            {
                var patients = await _patientsService.GetAllPatientsAsync();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all patients");
                return StatusCode(500, "Error retrieving all patients");
            }
        }

        [HttpGet("{patientId}")]
        public async Task<IActionResult> GetPatientById(int clientId)
        {
            try
            {
                int? clientIdToUse = null;

                var jwtUserId = User.FindFirstValue(JwtRegisteredClaimNames.Name);
                var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();

                if (userRoles.Contains("Admin") && clientId != null)
                {
                    clientIdToUse = clientId;
                }
                else if (clientId != null && jwtUserId != null)
                {
                    if (!await _authService.VerifyClientById(clientId, jwtUserId))
                    {
                        return Unauthorized("You are not authorized to view these appointments.");
                    }
                    clientIdToUse = clientId;
                }
                else
                {
                    return BadRequest("You are not authorized to view these appointments.");
                }

                var patient = await _patientsService.GetPatientByIdAsync(clientId);
                if (patient == null)
                {
                    return NotFound($"Patient with ID {clientId} not found.");
                }
                return Ok(patient);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving patient by id");
                return StatusCode(500, "Error retrieving patient by id");
            }
        }
    }
}
