using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Application.DTO.Clients.Request;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
namespace diploma_thesis_backend.Controllers
{
    [Route("clients")]
    [ApiController]
    [Produces("application/json")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientsService _clientsService;
        private readonly IAuthService _authService;
        public readonly ILogger<ClientsController> _logger;

        public ClientsController(IClientsService clientService, IAuthService authService, ILogger<ClientsController> logger)
        {
            _clientsService = clientService;
            _authService = authService;
            _logger = logger;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetClientsAsync()
        {
            _logger.LogInformation("Retrieving all Client.");
            try
            {
                var clients = await _clientsService.GetClientsAsync();

                if (clients != null && clients.Any())
                {
                    _logger.LogInformation("All Clients successfully retrieved.");
                    return Ok(clients);
                }
                else
                {
                    _logger.LogInformation("No Clients found.");
                    return NotFound("No Clients found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all Clients.");
                return BadRequest("Error retrieving all Clients.");
            }
        }

        [Authorize]
        [HttpGet("{personId}")]
        public async Task<IActionResult> GetClientByIdAsync(int personId)
        {
            _logger.LogInformation($"Retrieving Client with ID {personId}");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(personId))
                {
                    _logger.LogWarning($"User with userId = {User.FindFirstValue("userId")} is not authorized to view Client with Person.Id = {personId}");
                    return Unauthorized("You are not authorized to view this data.");
                }

                var client = await _clientsService.GetClientByIdAsync(personId);

                if (client != null)
                {
                    _logger.LogInformation($"Client with Person.Id {personId} successfully retrieved.");
                    return Ok(client);
                }
                else
                {
                    _logger.LogInformation($"Client with ID {personId} not found.");
                    return NotFound("Client not found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving Client by Person.Id.");
                return BadRequest("Error retrieving Client by Person.Id.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{personId}/notes")]
        public async Task<IActionResult> GetNotesForClientAsync(int personId)
        {
            _logger.LogInformation($"Retrieving notes for Client with Person.Id {personId}");
            try
            {
                var notes = await _clientsService.GetNotesForClientAsync(personId);

                if (notes != null && notes.Any())
                {
                    _logger.LogInformation($"Notes for Client with Person.Id {personId} successfully retrieved.");
                    return Ok(notes);
                }
                else
                {
                    _logger.LogInformation($"Client with Person.Id {personId} has no notes.");
                    return NotFound("Client has no notes.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Client's notes.");
                return BadRequest("Error retrieving Client's notes.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{personId}/notes")]
        public async Task<IActionResult> AddNoteToClientAsync(int personId, [FromBody] CreateClientNoteDto createClientNoteDto)
        {
            _logger.LogInformation($"Adding note to Client with ID {personId}");
            try
            {
                if (personId != createClientNoteDto.PersonId)
                {
                    return BadRequest("Client ID mismatch.");
                }

                await _clientsService.AddNoteToClientAsync(createClientNoteDto);
                return Ok("Note successfully added.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding note to Client.");
                return BadRequest("Error adding note to Client.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("notes/{noteId}")]
        public async Task<IActionResult> DeleteNoteAsync(int noteId)
        {
            _logger.LogInformation($"Deleting note with Note.Id {noteId}");
            try
            {
                await _clientsService.DeleteNoteAsync(noteId);

                _logger.LogInformation($"Note with Note.Id {noteId} successfully deleted.");
                return Ok("Note successfully deleted.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting Note.");
                return BadRequest("Error deleting Note.");
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
