﻿using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Application.DTO.Clients.Request;
using Application.DTO.Clients.Response;
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

            var clientExists = await _context.Persons.AnyAsync(p => p.Id == createClientNoteDto.PersonId);

            if (!clientExists)
            {
                throw new InvalidOperationException($"No Client found with ID {createClientNoteDto.PersonId}.");
            }

            var clientNote = _mapper.Map<ClientNote>(createClientNoteDto);
            clientNote.CreatedAt = DateTime.UtcNow.AddHours(1);

            clientNote.PersonId = createClientNoteDto.PersonId;

            _context.ClientNotes.Add(clientNote);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNoteAsync(int noteId)
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

        public async Task<IEnumerable<ClientNoteDto>> GetAllNotesForClientAsync(int clientId)
        {
            var clientNotes = await _context.ClientNotes
                .Where(n => n.PersonId == clientId)
                .ToListAsync();

            _logger.LogInformation($"Retrieved all notes for Client ID {clientId}");

            return _mapper.Map<IEnumerable<ClientNoteDto>>(clientNotes);
        }

        public async Task<IEnumerable<ClientDto>> GetAllClientsAsync()
        {
            // Get all user IDs that have the role "Client"
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

        public async Task<ClientDto?> GetClientByIdAsync(int clientId)
        {
            var clientRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "Client");
            if (clientRole == null)
            {
                _logger.LogInformation("Client role not found.");
                return null;
            }
            var clientUserIds = await _context.UserRoles
                                              .Where(ur => ur.RoleId == clientRole.Id)
                                              .Select(ur => ur.UserId)
                                              .ToListAsync();

            var client = await _context.Users
                                       .Where(u => clientUserIds.Contains(u.Id) && u.PersonId == clientId)
                                       .Include(u => u.Person)
                                       .FirstOrDefaultAsync();

            if (client == null)
            {
                _logger.LogInformation($"No Client found with Person ID {clientId}.");
                return null;
            }

            return _mapper.Map<ClientDto>(client);
        }
    }
}
