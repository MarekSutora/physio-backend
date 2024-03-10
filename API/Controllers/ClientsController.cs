using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Shared.DTO.Clients.Request; // Assuming you have renamed the DTOs as well
using System.Security.Claims;
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

        [HttpPost("{clientId}/notes")]
        public async Task<IActionResult> AddNoteToClient(int clientId, [FromBody] CreateClientNoteDto createClientNoteDto)
        {
            try
            {
                if (clientId != createClientNoteDto.ClientId)
                {
                    return BadRequest("Mismatched Client Id.");
                }

                await _clientsService.AddNoteToClientAsync(createClientNoteDto);
                return Ok("Note added successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding note to Client.");
                return StatusCode(500, "Error adding note to Client.");
            }
        }

        [HttpGet("{clientId}/notes")]
        public async Task<IActionResult> GetAllNotesForClientAsync(int clientId)
        {
            try
            {
                var notes = await _clientsService.GetAllNotesForClientAsync(clientId);
                return Ok(notes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving notes for Client");
                return StatusCode(500, "Error retrieving notes for Client");
            }
        }

        [HttpDelete("notes/{noteId}")]
        public async Task<IActionResult> DeleteNoteAsync(int noteId)
        {
            try
            {
                await _clientsService.DeleteNoteAsync(noteId);
                return Ok("Note deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting note.");
                return StatusCode(500, "Error deleting note.");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClientsAsync()
        {
            try
            {
                var clients = await _clientsService.GetAllClientsAsync();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all Clients.");
                return StatusCode(500, "Error retrieving all Clients.");
            }
        }

        [HttpGet("{clientId}")]
        public async Task<IActionResult> GetClientByIdAsync(int clientId)
        {
            try
            {
                var jwtUserId = User.FindFirstValue("userId");
                var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
                if (!userRoles.Contains("Admin") && !await _authService.VerifyClientById(clientId, jwtUserId))
                {
                    return Unauthorized("You are not authorized to view these appointments.");
                }

                var client = await _clientsService.GetClientByIdAsync(clientId);
                if (client == null)
                {
                    return NotFound($"Client with ID {clientId} not found.");
                }
                return Ok(client);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Client by Id.");
                return StatusCode(500, "Error retrieving Client by Id.");
            }
        }
    }
}
