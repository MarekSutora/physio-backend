using Shared.DTO.Clients.Request;
using Shared.DTO.Clients.Response;

namespace Application.Services.Interfaces
{
    public interface IClientsService
    {
        Task<IEnumerable<ClientDto>> GetAllClientsAsync();

        Task<ClientDto> GetClientByIdAsync(int clientId);

        Task<IEnumerable<ClientNoteDto>> GetAllNotesForClientAsync(int clientId);

        Task AddNoteToClientAsync(CreateClientNoteDto createClienttNoteDto);

        Task DeleteNoteAsync(int noteId);
    }
}
