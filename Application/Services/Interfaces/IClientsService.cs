using Application.DTO.Clients.Request;
using Application.DTO.Clients.Response;

namespace Application.Services.Interfaces
{
    public interface IClientsService
    {
        Task<IEnumerable<ClientDto>> GetAllClientsAsync();

        Task<ClientDto?> GetClientByIdAsync(int clientId);

        Task<IEnumerable<ClientNoteDto>> GetAllNotesForClientAsync(int clientId);

        Task AddNoteToClientAsync(CreateClientNoteDto createClientNoteDto);

        Task DeleteNoteAsync(int noteId);
    }
}
