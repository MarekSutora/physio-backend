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

        public async Task<List<PatientForBookedReservationDto>> GetAllForBookedReservationAsync()
        {
            try
            {
                var patients = await _context.Patients
                                             .Include(p => p.Person) // Ensure Person is included
                                             .ToListAsync();

                return _mapper.Map<List<PatientForBookedReservationDto>>(patients);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error getting all patients for booked reservations: {Message}", e.Message);
                throw;
            }
        }
    }
}
