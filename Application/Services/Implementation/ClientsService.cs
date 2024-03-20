using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shared.DTO.Clients.Request;
using Shared.DTO.Clients.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class ClientsService : IClientsService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ClientsService> _logger;
        private readonly IMapper _mapper;

        public ClientsService(ApplicationDbContext context, ILogger<ClientsService> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddNoteToClientAsync(CreateClientNoteDto createClientNoteDto)
        {
            try
            {
                var clientExists = await _context.Clients.AnyAsync(p => p.PersonId == createClientNoteDto.ClientId);

                if (!clientExists)
                {
                    throw new InvalidOperationException($"No Client found with ID {createClientNoteDto.ClientId}.");
                }

                var clientNote = _mapper.Map<ClientNote>(createClientNoteDto);
                clientNote.CreatedAt = DateTime.UtcNow.AddHours(1);

                clientNote.ClientId = createClientNoteDto.ClientId;

                _context.ClientNotes.Add(clientNote);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while adding note to Client");
                throw;
            }
        }

        public async Task DeleteNoteAsync(int noteId)
        {
            try
            {
                var note = await _context.ClientNotes.FirstOrDefaultAsync(n => n.Id == noteId);

                if (note == null)
                {
                    throw new InvalidOperationException($"No note found with ID {noteId}.");
                }

                _context.ClientNotes.Remove(note);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Deleted note with ID {noteId}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while deleting note");
                throw;
            }
        }

        public async Task<IEnumerable<ClientNoteDto>> GetAllNotesForClientAsync(int clientId)
        {
            try
            {
                var clientNotes = await _context.ClientNotes
                    .Where(n => n.ClientId == clientId)
                    .ToListAsync();

                _logger.LogInformation($"Retrieved all notes for Client ID {clientId}");

                return _mapper.Map<IEnumerable<ClientNoteDto>>(clientNotes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting all notes for Client");
                throw;
            }
        }

        public async Task<IEnumerable<ClientDto>> GetAllClientsAsync()
        {
            try
            {
                var clients = await _context.ApplicationUsers
                    .Include(u => u.Person)
                    .ThenInclude(p => p.Client)
                    .Where(u => u.Person.Client != null) // Ensure there is a Client record
                    .ToListAsync();

                _logger.LogInformation("Successfully retrieved all Clients");

                return _mapper.Map<IEnumerable<ClientDto>>(clients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting all Clients");
                throw;
            }
        }

        public async Task<ClientDto> GetClientByIdAsync(int clientId)
        {
            try
            {
                var client = await _context.ApplicationUsers
                    .Include(u => u.Person)
                    .ThenInclude(p => p.Client)
                    .FirstOrDefaultAsync(u => u.Person.Id == clientId);

                _logger.LogInformation("Successfully retrieved Client by id");

                return _mapper.Map<ClientDto>(client);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting Client by id");
                throw;
            }
        }
    }
}
