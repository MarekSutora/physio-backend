using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shared.DTO.Patients.Request;
using Shared.DTO.Patients.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class PatientsService : IPatientsService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PatientsService> _logger;
        private readonly IMapper _mapper;

        public PatientsService(ApplicationDbContext context, ILogger<PatientsService> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddNoteToPatientAsync(CreatePatientNoteDto createPatientNoteDto)
        {
            try
            {
                var patientNote = _mapper.Map<PatientNote>(createPatientNoteDto);


                _context.PatientNotes.Add(patientNote);

                await _context.SaveChangesAsync();
            }
            catch
            (Exception ex)
            {
                _logger.LogError(ex, "Error while adding note to patient");
                throw;
            }
        }

        public async Task<IEnumerable<PatientNoteDto>> GetAllNotesForPatient(int patientId)
        {
            try
            {
                var patientNotes = await _context.PatientNotes
                    .Where(n => n.PatientId == patientId)
                    .ToListAsync();

                _logger.LogInformation($"Retrieved all notes for patient ID {patientId}");

                return _mapper.Map<IEnumerable<PatientNoteDto>>(patientNotes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting all notes for patient");
                throw;
            }
        }

        public async Task<IEnumerable<PatientDto>> GetAllPatientsAsync()
        {
            try
            {
                var patients = await _context.ApplicationUsers
                    .Include(u => u.Person)
                    .ThenInclude(p => p.Patient)
                    .Where(u => u.Person.Patient != null) // Ensure there is a Patient record
                    .ToListAsync();

                _logger.LogInformation("Successfully retrieved all patients");

                return _mapper.Map<IEnumerable<PatientDto>>(patients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting all patients");
                throw;
            }
        }

        public async Task<PatientDto> GetPatientByIdAsync(int patientId)
        {
            try
            {
                var patient = await _context.ApplicationUsers
                    .Include(u => u.Person)
                    .ThenInclude(p => p.Patient)
                    .FirstOrDefaultAsync(u => u.Person.Id == patientId);

                _logger.LogInformation("Successfully retrieved patient by id");

                return _mapper.Map<PatientDto>(patient);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting patient by id");
                throw;
            }
        }
    }
}
