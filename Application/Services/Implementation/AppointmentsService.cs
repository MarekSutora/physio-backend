using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Model.Entities;
using Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DTO.Appointments;
using Shared.DTO.Appointments.Request;
using Shared.DTO.Appointments.Response;
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace Application.Services.Implementation
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AppointmentsService> _logger;
        private readonly IMapper _mapper;

        public AppointmentsService(ApplicationDbContext context, ILogger<AppointmentsService> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task CreateAppointmentAsync(CreateAppointmentDto createAppointmentDto)
        {
            // Vytvorenie novej entity Appointment z DTO
            var appointment = new Appointment
            {
                StartTime = createAppointmentDto.StartTime,
                Capacity = createAppointmentDto.Capacity,
            };

            // Načítanie príslušných entít ServiceTypeDurationCost na základe poskytnutých ID
            var stdcs = await _context.ServiceTypeDurationCosts
                                      .Where(stdc => createAppointmentDto.StdcIds.Contains(stdc.Id))
                                      .ToListAsync();

            appointment.ServiceTypeDurationCosts.AddRange(stdcs);

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
        }


        public async Task ClientCreateBookedAppointmentAsync(ClientBookedAppointmentDto clientBookedAppointmentDto, string userId)
        {
            try
            {
                var user = await _context.ApplicationUsers
                    .Include(u => u.Person)
                    .ThenInclude(p => p.Patient)
                    .FirstOrDefaultAsync(u => u.Id == userId);

                if (user?.Person?.Patient == null)
                {
                    throw new Exception($"Patient associated with User ID {userId} not found.");
                }

                var patientId = user.Person.Patient.PersonId;

                var bookedAppointment = new BookedAppointment
                {
                    AppointmentServiceTypeDurationCostId = clientBookedAppointmentDto.astdcId,
                    AppointmentBookedDate = DateTime.Now,
                    PatientId = patientId,
                    // Other properties if required
                };

                var existingBookingsCount = await _context.BookedAppointments
                            .CountAsync(ba => ba.AppointmentServiceTypeDurationCostId == clientBookedAppointmentDto.astdcId && ba.CancellationDate == null);

                var capacity = await _context.AppointmentServiceTypeDurationCosts
                    .Where(astdc => astdc.Id == clientBookedAppointmentDto.astdcId)
                    .Select(astdc => astdc.Appointment.Capacity)
                    .FirstOrDefaultAsync();

                if (existingBookingsCount >= capacity)
                {
                    throw new Exception("Appointment is fully booked.");
                }

                // Add the new BookedAppointment to the context
                _context.BookedAppointments.Add(bookedAppointment);

                // Save the changes to the database
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating booked Appointment");
                throw;
            }
        }


        public async Task<List<UnbookedAppointmentDto>> GetUnbookedAppointmentsAsync()
        {
            try
            {
                var unBookedAppointmentsQuery = _context.AppointmentServiceTypeDurationCosts
            .Include(astdc => astdc.BookedAppointments)
            .Include(astdc => astdc.ServiceTypeDurationCost)
                .ThenInclude(stdc => stdc.ServiceType)
            .Include(astdc => astdc.ServiceTypeDurationCost)
                .ThenInclude(stdc => stdc.DurationCost)
            .Where(astdc => astdc.BookedAppointments.Count(ba => ba.CancellationDate == null) < astdc.Appointment.Capacity
                    && astdc.Appointment.StartTime > DateTime.UtcNow.AddHours(1));

                var groupedAppointments = from astdc in unBookedAppointmentsQuery
                                          group astdc by astdc.Appointment into g
                                          select new UnbookedAppointmentDto
                                          {
                                              AppointmentId = g.Key.Id,
                                              StartTime = g.Key.StartTime,
                                              Capacity = g.Key.Capacity,
                                              ServiceTypeInfos = g.Select(astdc => new ServiceTypeInfoDto
                                              {
                                                  AstdcId = astdc.Id,
                                                  Name = astdc.ServiceTypeDurationCost.ServiceType.Name,
                                                  DurationMinutes = astdc.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                                                  Cost = astdc.ServiceTypeDurationCost.DurationCost.Cost,
                                                  HexColor = astdc.ServiceTypeDurationCost.ServiceType.HexColor
                                              }).ToList()
                                          };

                var unBookedAppointments = await groupedAppointments.ToListAsync();

                return unBookedAppointments;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving unbooked appointments.");
                throw;
            }
        }


        public async Task<List<BookedAppointmentDto>> GetBookedAppointmentsAsync()
        {
            try
            {
                var bookedAppointments = await _context.BookedAppointments
                    .Where(ba => ba.CancellationDate == null) // Filter out canceled appointments
                    .Select(ba => new
                    {
                        ba.Id,
                        AppointmentId = ba.AppointmentServiceTypeDurationCost.Appointment.Id,
                        ba.AppointmentServiceTypeDurationCost.Appointment.StartTime,
                        DurationMinutes = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                        ServiceTypeName = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name,
                        HexColor = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor,
                        Capacity = ba.AppointmentServiceTypeDurationCost.Appointment.Capacity,
                        ClientFirstName = ba.Patient == null ? "-" : ba.Patient.Person.FirstName,
                        ClientLastName = ba.Patient == null ? "-" : ba.Patient.Person.LastName,
                        Cost = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost,
                        AppointmentBookedDate = ba.AppointmentBookedDate
                    })
                    .ToListAsync();

                var groupedAppointments = bookedAppointments
                    .GroupBy(ba => ba.AppointmentId)
                    .Select(g => new BookedAppointmentDto
                    {
                        Id = g.First().Id,
                        AppointmentId = g.Key,
                        StartTime = g.First().StartTime,
                        DurationMinutes = g.First().DurationMinutes,
                        ServiceTypeName = g.First().ServiceTypeName,
                        HexColor = g.First().HexColor,
                        Capacity = g.First().Capacity,
                        Cost = g.First().Cost,
                        ClientFirstName = g.First().ClientFirstName,
                        ClientSecondName = g.First().ClientLastName,
                        AppointmentBookedDate = g.First().AppointmentBookedDate
                    })
                    .ToList();

                return groupedAppointments;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving booked appointments.");
                throw;
            }
        }



        public async Task AdminCreateBookedAppointmentAsync(AdminBookedAppointmentDto bookedAppointmentDto)
        {
            // Start transaction to ensure atomicity
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var appointment = new Appointment
                {
                    StartTime = bookedAppointmentDto.StartTime,
                    Capacity = 1, // Assuming capacity of 1 for admin created Appointments
                };

                _context.Appointments.Add(appointment);
                await _context.SaveChangesAsync();

                // Step 2: Retrieve ServiceTypeDurationCost and associate it with Appointment
                var serviceTypeDurationCost = await _context.ServiceTypeDurationCosts
                    .FindAsync(bookedAppointmentDto.ServiceTypeDurationCostId);

                if (serviceTypeDurationCost == null)
                {
                    throw new Exception("ServiceTypeDurationCost not found.");
                }

                // Link the ServiceTypeDurationCost with the Appointment
                appointment.ServiceTypeDurationCosts.Add(serviceTypeDurationCost);

                // Step 3: Create the BookedAppointment
                var bookedAppointment = new BookedAppointment
                {
                    AppointmentServiceTypeDurationCostId = serviceTypeDurationCost.Id,
                    AppointmentBookedDate = DateTime.UtcNow.AddHours(1),
                    PatientId = bookedAppointmentDto.PatientId,
                    // Other properties if required
                };

                _context.BookedAppointments.Add(bookedAppointment);
                await _context.SaveChangesAsync();

                // Commit the transaction
                await transaction.CommitAsync();

                _logger.LogInformation("Admin created BookedAppointment successfully.");
            }
            catch (Exception ex)
            {
                // Rollback the transaction if any exception occurs
                await transaction.RollbackAsync();
                _logger.LogError(ex, "Error creating admin booked Appointment");
                throw;
            }
        }

        public async Task CancelAppointmentAsync(CancelBookedAppointmentDto cancelBookedAppointmentDto, string userId, bool isAdmin)
        {
            try
            {
                var bookedAppointment = await _context.BookedAppointments
                    .Include(ba => ba.Patient)
                    .ThenInclude(p => p.Person) // Assuming Patient is linked to Person, which contains UserId
                    .FirstOrDefaultAsync(ba => ba.Id == cancelBookedAppointmentDto.BookedAppointmentId);

                if (bookedAppointment == null)
                {
                    throw new Exception("Appointment not found.");
                }

                // If the user is not an admin, verify the appointment belongs to them
                if (!isAdmin)
                {
                    if (bookedAppointment!.Patient!.Person!.ApplicationUser!.Id != userId)
                    {
                        throw new UnauthorizedAccessException("You do not have permission to cancel this appointment.");
                    }
                }

                // Proceed to cancel the appointment
                bookedAppointment.CancellationDate = DateTime.UtcNow.AddHours(1); // Set the cancellation date to now

                // Save the changes in the database
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error cancelling the appointment.");
                throw;
            }
        }


        public async Task DeleteAppointmentAsync(DeleteAppointmentDto deleteAppointmentDto)
        {
            try
            {
                var appointment = await _context.Appointments
                    .Include(a => a.AppointmentServiceTypeDurationCosts)
                    .FirstOrDefaultAsync(a => a.Id == deleteAppointmentDto.AppointmentId);

                if (appointment == null)
                {
                    throw new Exception("Appointment not found.");
                }

                // Remove related AppointmentServiceTypeDurationCosts
                _context.AppointmentServiceTypeDurationCosts.RemoveRange(appointment.AppointmentServiceTypeDurationCosts);

                // Remove the Appointment
                _context.Appointments.Remove(appointment);

                // Save the changes in the database
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting the appointment.");
                throw;
            }
        }
    }
}

