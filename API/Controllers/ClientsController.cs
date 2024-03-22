using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Application.DTO.Clients.Request; // Assuming you have renamed the DTOs as well
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
namespace diploma_thesis_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClientsController : Controller
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

        [Authorize(Policy = "Admin")]
        [HttpPost("{clientId}/notes")]
        public async Task<IActionResult> AddNoteToClientAsync(int clientId, [FromBody] CreateClientNoteDto createClientNoteDto)
        {
            _logger.LogInformation($"Adding note to client with ID {clientId}");
            try
            {
                if (clientId != createClientNoteDto.ClientId)
                {
                    return BadRequest("Client ID mismatch.");
                }

                await _clientsService.AddNoteToClientAsync(createClientNoteDto);
                return Ok("Note successfully added.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding note to client.");
                return BadRequest("Error adding note to client.");
            }
        }

        [Authorize(Policy = "Admin")]
        [HttpGet("{clientId}/notes")]
        public async Task<IActionResult> GetAllNotesForClientAsync(int clientId)
        {
            _logger.LogInformation($"Retrieving notes for client with ID {clientId}");
            try
            {
                var notes = await _clientsService.GetAllNotesForClientAsync(clientId);

                if (notes != null && notes.Any())
                {
                    _logger.LogInformation($"Notes for client with ID {clientId} successfully retrieved.");
                    return Ok(notes);
                }
                else
                {
                    _logger.LogInformation($"Client with ID {clientId} has no notes.");
                    return NotFound("Client has no notes.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving client's notes.");
                return BadRequest("Error retrieving client's notes.");
            }
        }

        [Authorize(Policy = "Admin")]
        [HttpDelete("notes/{noteId}")]
        public async Task<IActionResult> DeleteNoteAsync(int noteId)
        {
            _logger.LogInformation($"Deleting note with ID {noteId}");
            try
            {
                await _clientsService.DeleteNoteAsync(noteId);

                _logger.LogInformation($"Note with ID {noteId} successfully deleted.");
                return Ok("Note successfully deleted.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting note.");
                return BadRequest("Error deleting note.");
            }
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllClientsAsync()
        {
            _logger.LogInformation("Retrieving all clients.");
            try
            {
                var clients = await _clientsService.GetAllClientsAsync();

                if (clients != null && clients.Any())
                {
                    _logger.LogInformation("All clients successfully retrieved.");
                    return Ok(clients);
                }
                else
                {
                    _logger.LogInformation("No clients found.");
                    return NotFound("No clients found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all clients.");
                return BadRequest("Error retrieving all clients.");
            }
        }

        [Authorize]
        [HttpGet("{clientId}")]
        public async Task<IActionResult> GetClientByIdAsync(int clientId)
        {
            _logger.LogInformation($"Retrieving client with ID {clientId}");
            try
            {
                if (!IsAdminOrAccessingTheirOwnData(clientId))
                {
                    _logger.LogWarning($"User with userId = {User.FindFirstValue("userId")} is not authorized to view client with Client.Id = {clientId}");
                    return Unauthorized("You are not authorized to view this data.");
                }

                var client = await _clientsService.GetClientByIdAsync(clientId);

                if (client != null)
                {
                    _logger.LogInformation($"Client with ID {clientId} successfully retrieved.");
                    return Ok(client);
                }
                else
                {
                    _logger.LogInformation($"Client with ID {clientId} not found.");
                    return NotFound("Client not found.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving client by ID.");
                return BadRequest("Error retrieving client by ID.");
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
