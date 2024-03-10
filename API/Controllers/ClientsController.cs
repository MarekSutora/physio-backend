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
        public async Task<IActionResult> AddNoteToClientAsync(int clientId, [FromBody] CreateClientNoteDto createClientNoteDto)
        {
            try
            {
                if (clientId != createClientNoteDto.ClientId)
                {
                    return BadRequest("Nesúlad Id klienta.");
                }

                await _clientsService.AddNoteToClientAsync(createClientNoteDto);
                return Ok("Poznámka úspešne pridaná.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri pridávaní poznámky klientovi.");
                return BadRequest("Chyba pri pridávaní poznámky klientovi.");
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
                _logger.LogError(ex, "Chyba pri získavaní poznámok klienta.");
                return BadRequest("Chyba pri získavaní poznámok klienta.");
            }
        }


        [HttpDelete("notes/{noteId}")]
        public async Task<IActionResult> DeleteNoteAsync(int noteId)
        {
            try
            {
                await _clientsService.DeleteNoteAsync(noteId);
                return Ok("Poznámka úspešne vymazaná.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri mazaní poznámky.");
                return BadRequest("Chyba pri mazaní poznámky.");
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
                _logger.LogError(ex, "Chyba pri získavaní všetkých klientov.");
                return BadRequest("Chyba pri získavaní všetkých klientov.");
            }
        }
        [HttpGet("{clientId}")]
        public async Task<IActionResult> GetClientByIdAsync(int clientId)
        {
            try
            {
                var jwtUserId = User.FindFirstValue("userId");
                var userRoles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
                if (!userRoles.Contains("Admin") && !await _authService.VerifyClientByIdAsync(clientId, jwtUserId))
                {
                    return Unauthorized("Nemáte oprávnenie na zobrazenie týchto údajov.");
                }

                var client = await _clientsService.GetClientByIdAsync(clientId);
                if (client == null)
                {
                    return NotFound($"Klient s ID {clientId} nebol nájdený.");
                }
                return Ok(client);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pri získavaní klienta podľa ID.");
                return BadRequest("Chyba pri získavaní klienta podľa ID.");
            }
        }
    }
}
