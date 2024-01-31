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

        public async Task<List<AvailableReservationDto>> GetAvailableReservationsWithServiceTypesAsync()
        {
            //var threeMonthsFromNow = DateTime.Today.AddDays(-5).AddMonths(3);

            //var availableAppointments = await _context.AvailableReservation
            //    .Where(a => a.Date >= DateTime.Today && a.Date <= threeMonthsFromNow)
            //    .Include(a => a.ServiceTypes)
            //    .Select(a => new AvailableReservationDto
            //    {
            //        Id = a.Id,
            //        Date = a.Date,
            //        Capacity = a.Capacity,
            //        ReservedAmount = a.ReservedAmount,
            //        ServiceTypes = a.ServiceTypes.Select(at => new ServiceTypeDto
            //        {
            //            Id = at.Id,
            //            Name = at.Name,
            //            Description = at.Description,
            //            Cost = at.Cost,
            //            Duration = at.Duration,
            //            HexColor = at.HexColor
            //        }).ToList()
            //    })
            //    .ToListAsync();

            return null;
        }
    }
}
