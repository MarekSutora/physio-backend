using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Model.Entities;
using Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DTO.Reservations;
using Shared.DTO.Reservations.Request;
using Shared.DTO.Reservations.Response;

namespace Application.Services.Implementation
{
    public class ReservationsService : IReservationsService
    {
        private readonly ApplicationDbContext _context;

        public ReservationsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAvailableReservationAsync(CreateAvailableReservationDto createAvailableReservationDto)
        {
            // Create a new AvailableReservation entity from the DTO
            var availableReservation = new AvailableReservation
            {
                StartTime = createAvailableReservationDto.StartTime,
                Capacity = createAvailableReservationDto.Capacity,
                ReservedAmount = 0, // Assuming new reservations start with 0 reserved slots
            };

            // Fetch the associated ServiceTypeDurationCost entities based on the provided IDs
            var stdcs = await _context.ServiceTypeDurationCosts
                                      .Where(stdc => createAvailableReservationDto.StdcIds.Contains(stdc.Id))
                                      .ToListAsync();

            // Associate the AvailableReservation with the ServiceTypeDurationCosts
            availableReservation.ServiceTypeDurationCosts.AddRange(stdcs);

            _context.AvailableReservations.Add(availableReservation);
            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> CreateBookedReservationAsync(BookReservationDto bookedReservationDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AvailableReservationDto>> GetAvailableReservationsAsync()
        {
            var availableReservations = await _context.AvailableReservations
                .Where(ar => ar.ReservedAmount < ar.Capacity)
                .Include(ar => ar.ServiceTypeDurationCosts)
                    .ThenInclude(stdc => stdc.ServiceType)
                .Include(ar => ar.ServiceTypeDurationCosts)
                    .ThenInclude(stdc => stdc.DurationCost)
                .Select(ar => new AvailableReservationDto
                {
                    Id = ar.Id,
                    StartTime = ar.StartTime,
                    Capacity = ar.Capacity,
                    ReservedAmount = ar.ReservedAmount,
                    ServiceTypesWithCosts = ar.ServiceTypeDurationCosts.Select(stdc => new ServiceTypeWithCostDto
                    {
                        arstdcId = stdc.Id, // Include the ID of AvailableReservationServiceTypeDc
                        ServiceTypeName = stdc.ServiceType.Name,
                        DurationMinutes = stdc.DurationCost.DurationMinutes,
                        Cost = stdc.DurationCost.Cost,
                        HexColor = stdc.ServiceType.HexColor
                    }).ToList()
                })
                .ToListAsync();

            return availableReservations;
        }

    }
}
