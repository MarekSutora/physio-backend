using Application.DTO.Clients.Request;
using Application.DTO.Clients.Response;
using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation
{
    public class ClientsService : IClientsService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ClientsService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> AddNoteToClientAsync(CreateClientNoteDto createClientNoteDto)
        {

            var clientExists = await _context.Persons.AnyAsync(p => p.Id == createClientNoteDto.PersonId);

            if (!clientExists)
            {
                throw new Exception($"No Client found with ID {createClientNoteDto.PersonId}.");
            }

            var clientNote = _mapper.Map<ClientNote>(createClientNoteDto);
            clientNote.CreatedAt = DateTime.UtcNow.AddHours(1);

            clientNote.PersonId = createClientNoteDto.PersonId;

            _context.ClientNotes.Add(clientNote);
            await _context.SaveChangesAsync();

            return clientNote.Id;
        }

        public async Task DeleteNoteAsync(int noteId)
        {
            var note = await _context.ClientNotes.FirstOrDefaultAsync(n => n.Id == noteId);

            if (note == null)
            {
                throw new Exception($"No note found with ID {noteId}.");
            }

            _context.ClientNotes.Remove(note);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ClientNoteDto>> GetNotesForClientAsync(int personId)
        {
            var clientNotes = await _context.ClientNotes
                .Where(n => n.PersonId == personId)
                .ToListAsync();


            return _mapper.Map<IEnumerable<ClientNoteDto>>(clientNotes);
        }

        public async Task<IEnumerable<ClientDto>> GetClientsAsync()
        {
            var clientRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "Client");
            var clientUserIds = new List<string>();

            if (clientRole != null)
            {
                clientUserIds = await _context.UserRoles
                                               .Where(ur => ur.RoleId == clientRole.Id)
                                               .Select(ur => ur.UserId)
                                               .ToListAsync();
            }

            var clients = await _context.Users
                                        .Where(u => clientUserIds.Contains(u.Id))
                                        .Include(u => u.Person)
                                        .ToListAsync();


            return _mapper.Map<IEnumerable<ClientDto>>(clients);
        }

        public async Task<ClientDto?> GetClientByIdAsync(int personId)
        {
            var clientRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "Client");
            if (clientRole == null)
            {
                throw new Exception("Client role not found at GetClientByIdAsync.");
            }
            var clientUserIds = await _context.UserRoles
                                              .Where(ur => ur.RoleId == clientRole.Id)
                                              .Select(ur => ur.UserId)
                                              .ToListAsync();

            var client = await _context.Users
                                       .Where(u => clientUserIds.Contains(u.Id) && u.PersonId == personId)
                                       .Include(u => u.Person)
                                       .FirstOrDefaultAsync();

            if (client == null)
            {
                return null;
            }

            return _mapper.Map<ClientDto>(client);
        }
    }
}
