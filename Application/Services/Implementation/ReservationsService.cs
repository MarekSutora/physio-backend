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
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace Application.Services.Implementation
{
    public class ReservationsService : IReservationsService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ReservationsService> _logger;
        private readonly IMapper _mapper;

        public ReservationsService(ApplicationDbContext context, ILogger<ReservationsService> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task CreateAvailableReservationAsync(CreateAvailableReservationDto createAvailableReservationDto)
        {
            // Vytvorenie novej entity AvailableReservation z DTO
            var availableReservation = new AvailableReservation
            {
                StartTime = createAvailableReservationDto.StartTime,
                Capacity = createAvailableReservationDto.Capacity,
                ReservedAmount = 0,
            };

            // Načítanie príslušných entít ServiceTypeDurationCost na základe poskytnutých ID
            var stdcs = await _context.ServiceTypeDurationCosts
                                      .Where(stdc => createAvailableReservationDto.StdcIds.Contains(stdc.Id))
                                      .ToListAsync();

            // Asociácia AvailableReservation s ServiceTypeDurationCosts
            availableReservation.ServiceTypeDurationCosts.AddRange(stdcs);

            _context.AvailableReservations.Add(availableReservation);
            await _context.SaveChangesAsync();
        }

        public async Task ClientCreateBookedReservationAsync(ClientBookedReservationDto bookedReservationDto)
        {
            try
            {
                var newBookedReservation = _mapper.Map<BookedReservation>(bookedReservationDto);

                var availableReservation = await _context.AvailableReservations
                    .Include(ar => ar.ServiceTypeDurationCosts)
                    .FirstOrDefaultAsync(ar => ar.Id == newBookedReservation.AvailableReservationServiceTypeDCId);

                if (availableReservation == null)
                {
                    throw new Exception("The available reservation does not exist");
                }

                if (availableReservation.ReservedAmount >= availableReservation.Capacity)
                {
                    throw new Exception("The available reservation is full");
                }
                else
                {
                    availableReservation.ReservedAmount++;
                }

                _context.BookedReservations.Add(newBookedReservation);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Booked reservation with ID: {BookedReservationId} created successfully.", newBookedReservation.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating booked reservation");
                throw; // Propagujte výnimku vyššie
            }
        }





        public async Task<List<AvailableReservationDto>> GetAvailableReservationsAsync()
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving available reservations.");
                throw;
            }
        }

        public async Task<List<BookedReservationDto>> GetBookedReservationsAsync() //TODO getall
        {
            try
            {
                // Query to retrieve booked reservations along with related entities
                var bookedReservations = await _context.BookedReservations
                    .Include(br => br.AvailableReservationServiceTypeDc)
                        .ThenInclude(arstdc => arstdc.ServiceTypeDurationCost)
                        .ThenInclude(stdc => stdc.ServiceType)
                    .Include(br => br.AvailableReservationServiceTypeDc)
                        .ThenInclude(arstdc => arstdc.ServiceTypeDurationCost)
                        .ThenInclude(stdc => stdc.DurationCost)
                    .Include(br => br.Patient)
                        .ThenInclude(p => p.Person)
                    .Select(br => new BookedReservationDto
                    {
                        Id = br.Id,
                        StartTime = br.AvailableReservationServiceTypeDc.AvailableReservation.StartTime,
                        Duration = br.AvailableReservationServiceTypeDc.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                        ServiceTypeName = br.AvailableReservationServiceTypeDc.ServiceTypeDurationCost.ServiceType.Name,
                        Person = br.Patient != null ? br.Patient.Person.FirstName + " " + br.Patient.Person.LastName : "-", // Handle null Patient
                        Cost = br.AvailableReservationServiceTypeDc.ServiceTypeDurationCost.DurationCost.Cost,
                        HexColor = br.AvailableReservationServiceTypeDc.ServiceTypeDurationCost.ServiceType.HexColor
                    })
                    .ToListAsync();

                return bookedReservations;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving booked reservations.");
                throw;
            }
        }

        public async Task AdminCreateBookedReservationAsync(AdminBookedReservationDto bookedReservationDto)
        {
            // Start transaction to ensure atomicity
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Step 1: Create the AvailableReservation
                var availableReservation = new AvailableReservation
                {
                    StartTime = bookedReservationDto.StartTime,
                    Capacity = 1, // Assuming capacity of 1 for admin created reservations
                    ReservedAmount = 1 // Since you're booking it right away
                };

                _context.AvailableReservations.Add(availableReservation);
                await _context.SaveChangesAsync();

                // Step 2: Retrieve ServiceTypeDurationCost and associate it with AvailableReservation
                var serviceTypeDurationCost = await _context.ServiceTypeDurationCosts
                    .FindAsync(bookedReservationDto.ServiceTypeDurationCostId);

                if (serviceTypeDurationCost == null)
                {
                    throw new Exception("ServiceTypeDurationCost not found.");
                }

                // Link the ServiceTypeDurationCost with the AvailableReservation
                availableReservation.ServiceTypeDurationCosts.Add(serviceTypeDurationCost);

                // Step 3: Create the BookedReservation
                var bookedReservation = new BookedReservation
                {
                    AvailableReservationServiceTypeDCId = serviceTypeDurationCost.Id,
                    ReservationBookedDate = DateTime.Now,
                    ReservationFinishedDate = availableReservation.StartTime.AddMinutes(serviceTypeDurationCost.DurationCost.DurationMinutes),
                    PatientId = bookedReservationDto.PatientId,
                    // Other properties if required
                };

                _context.BookedReservations.Add(bookedReservation);
                await _context.SaveChangesAsync();

                // Commit the transaction
                await transaction.CommitAsync();

                _logger.LogInformation("Admin created BookedReservation successfully.");
            }
            catch (Exception ex)
            {
                // Rollback the transaction if any exception occurs
                await transaction.RollbackAsync();
                _logger.LogError(ex, "Error creating admin booked reservation");
                throw;
            }
        }
    }
}
