using Application.DTO.Clients.Request;
using Application.DTO.Clients.Response;

namespace Application.Services.Interfaces
{
    public interface IClientsService
    {
        Task<IEnumerable<ClientDto>> GetClientsAsync();

        Task<ClientDto?> GetClientByIdAsync(int clientId);

        Task<IEnumerable<ClientNoteDto>> GetNotesForClientAsync(int clientId);

        Task AddNoteToClientAsync(CreateClientNoteDto createClientNoteDto);

        Task DeleteNoteAsync(int noteId);
    }
}
