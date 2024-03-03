using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
    }
}
