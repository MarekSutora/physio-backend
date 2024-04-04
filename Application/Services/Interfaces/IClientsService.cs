using Application.DTO.Clients.Request;
using Application.DTO.Clients.Response;

namespace Application.Services.Interfaces
{
    public interface IClientsService
    {
        Task<IEnumerable<ClientDto>> GetClientsAsync();

        Task<ClientDto?> GetClientByIdAsync(int personId);

        Task<IEnumerable<ClientNoteDto>> GetNotesForClientAsync(int personId);

        Task<int> AddNoteToClientAsync(CreateClientNoteDto createClientNoteDto);

        Task DeleteNoteAsync(int noteId);
    }
}
