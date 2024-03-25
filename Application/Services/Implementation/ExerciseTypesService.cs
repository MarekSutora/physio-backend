using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Application.DTO.Appointments.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class ExerciseTypesService : IExerciseTypesService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AppointmentsService> _logger;
        private readonly IMapper _mapper;

        public ExerciseTypesService(ApplicationDbContext context, ILogger<AppointmentsService> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExerciseTypeDto>> GetExerciseTypesAsync()
        {
            try
            {
                var exerciseTypes = await _context.ExerciseTypes.ToListAsync();
                var exerciseTypesDto = _mapper.Map<IEnumerable<ExerciseTypeDto>>(exerciseTypes);

                return exerciseTypesDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all exercise types");
                throw;
            }
        }
    }
}
