using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Model.Entities;
using Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DTO.Reservations;

namespace Application.Services.Implementation
{
    public class ReservationsService : IReservationsService
    {
        private readonly ApplicationDbContext _context;

        public ReservationsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AvailableReservationDto>> GetAvailableReservationsWithActivityTypesAsync()
        {
            var threeMonthsFromNow = DateTime.Today.AddMonths(3);

            var availableAppointments = await _context.AvailableReservation
                .Where(a => a.Date >= DateTime.Today && a.Date <= threeMonthsFromNow)
                .Include(a => a.ActivityTypes)
                .Select(a => new AvailableReservationDto
                {
                    Id = a.Id,
                    Date = a.Date,
                    ActivityTypes = a.ActivityTypes.Select(at => new ActivityTypeDto
                    {
                        Id = at.Id,
                        Name = at.Name,
                        Description = at.Description,
                        NormalCost = at.NormalCost,
                        Duration = at.Duration,
                        HexColor = at.HexColor
                    }).ToList()
                })
                .ToListAsync();

            return availableAppointments;
        }
    }
}
