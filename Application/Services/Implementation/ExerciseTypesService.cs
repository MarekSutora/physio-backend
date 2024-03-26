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
        private readonly IMapper _mapper;

        public ExerciseTypesService(ApplicationDbContext context, ILogger<AppointmentsService> logger, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExerciseTypeDto>> GetExerciseTypesAsync()
        {
            var exerciseTypes = await _context.ExerciseTypes.ToListAsync();
            var exerciseTypesDto = _mapper.Map<IEnumerable<ExerciseTypeDto>>(exerciseTypes);

            return exerciseTypesDto;
        }
    }
}
