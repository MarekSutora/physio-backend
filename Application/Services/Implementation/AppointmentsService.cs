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
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;

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
                    .ThenInclude(p => p.Client)
                    .FirstOrDefaultAsync(u => u.Id == userId);

                if (user?.Person?.Client == null)
                {
                    throw new Exception($"Client associated with User ID {userId} not found.");
                }

                var clientId = user.Person.Client.PersonId;

                var bookedAppointment = new BookedAppointment
                {
                    AppointmentServiceTypeDurationCostId = clientBookedAppointmentDto.astdcId,
                    AppointmentBookedDate = DateTime.Now,
                    ClientId = clientId,
                    // Other properties if required
                };

                var existingBookingsCount = await _context.BookedAppointments
                            .CountAsync(ba => ba.AppointmentServiceTypeDurationCostId == clientBookedAppointmentDto.astdcId);

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
                    .Where(astdc => astdc.BookedAppointments.Count < astdc.Appointment.Capacity
                            && astdc.Appointment.StartTime > DateTime.UtcNow.AddHours(1))
                    .Select(astdc => new
                    {
                        astdc.Appointment,
                        BookedCount = astdc.BookedAppointments.Count, // Use Count() method here
                        ServiceTypeInfo = new ServiceTypeInfoDto
                        {
                            AstdcId = astdc.Id,
                            Name = astdc.ServiceTypeDurationCost.ServiceType.Name,
                            DurationMinutes = astdc.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                            Cost = astdc.ServiceTypeDurationCost.DurationCost.Cost,
                            HexColor = astdc.ServiceTypeDurationCost.ServiceType.HexColor
                        }
                    });

                var groupedAppointments = (await unBookedAppointmentsQuery.ToListAsync())
                    .GroupBy(x => x.Appointment)
                    .OrderBy(g => g.Key.StartTime)
                    .Select(g => new UnbookedAppointmentDto
                    {
                        AppointmentId = g.Key.Id,
                        StartTime = g.Key.StartTime,
                        Capacity = g.Key.Capacity,
                        ReservedCount = g.Sum(x => x.BookedCount), // Aggregate the count here
                        ServiceTypeInfos = g.Select(x => x.ServiceTypeInfo).ToList()
                    });

                return groupedAppointments.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving unbooked appointments.");
                throw;
            }
        }



        public async Task<List<BookedAppointmentDto>> GetBookedAppointmentsAsync(int? clientId = null)
        {
            try
            {
                IQueryable<BookedAppointment> query = _context.BookedAppointments
                    .Include(ba => ba.Client)
                        .ThenInclude(p => p.Person)
                    .Where(ba => !ba.IsFinished); // Filter for non-finished appointments

                // Filter by client ID if provided
                if (clientId.HasValue)
                {
                    query = query.Where(ba => ba.ClientId == clientId.Value);
                }

                // Now project to the DTO
                var bookedAppointments = await query.Select(ba => new BookedAppointmentDto
                {
                    Id = ba.Id,
                    AppointmentId = ba.AppointmentServiceTypeDurationCost.Appointment.Id,
                    StartTime = ba.AppointmentServiceTypeDurationCost.Appointment.StartTime,
                    DurationMinutes = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                    ServiceTypeName = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name,
                    HexColor = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor,
                    Capacity = ba.AppointmentServiceTypeDurationCost.Appointment.Capacity,
                    ClientId = ba.Client == null ? -1 : ba.Client.PersonId,
                    ClientFirstName = ba.Client == null ? "-" : ba.Client.Person.FirstName,
                    ClientSecondName = ba.Client == null ? "-" : ba.Client.Person.LastName,
                    Cost = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost,
                    AppointmentBookedDate = ba.AppointmentBookedDate
                }).ToListAsync();

                return bookedAppointments;
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
                    ClientId = bookedAppointmentDto.ClientId,
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

        public async Task DeleteAppointmentAsync(int appointmentId)
        {
            try
            {
                var appointment = await _context.Appointments
                    .Include(a => a.AppointmentServiceTypeDurationCosts)
                    .FirstOrDefaultAsync(a => a.Id == appointmentId);

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

        public async Task DeleteBookedAppointmentAsync(int bookedAppointmentId)
        {
            try
            {
                var bookedAppointment = await _context.BookedAppointments
                    .Include(ba => ba.AppointmentServiceTypeDurationCost)
                    .FirstOrDefaultAsync(ba => ba.Id == bookedAppointmentId);

                if (bookedAppointment == null)
                {
                    throw new Exception("BookedAppointment not found.");
                }

                _context.BookedAppointments.Remove(bookedAppointment);
                await _context.SaveChangesAsync();
            }
            catch
            {
                _logger.LogError("Error deleting the booked appointment.");
                throw;
            }
        }

        public async Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId)
        {
            try
            {
                var appointment = await _context.Appointments
                    .Include(a => a.AppointmentServiceTypeDurationCosts)
                        .ThenInclude(astdc => astdc.BookedAppointments).ThenInclude(ba => ba.Client).ThenInclude(p => p.Person)
                    .Include(a => a.AppointmentServiceTypeDurationCosts)
                        .ThenInclude(astdc => astdc.ServiceTypeDurationCost)
                            .ThenInclude(stdc => stdc.ServiceType)
                    .Include(a => a.AppointmentServiceTypeDurationCosts)
                        .ThenInclude(astdc => astdc.ServiceTypeDurationCost)
                            .ThenInclude(stdc => stdc.DurationCost)
                            .Include(a => a.AppointmentDetail).ThenInclude(ad => ad.AppointmentExerciseDetails).ThenInclude(aed => aed.ExerciseType)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(a => a.Id == appointmentId);

                if (appointment == null)
                {
                    _logger.LogWarning("Appointment not found for ID {AppointmentId}.", appointmentId);
                    throw new Exception("Appointment not found.");
                }

                var appointmentDto = _mapper.Map<AppointmentDto>(appointment);

                return appointmentDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving the appointment with ID {AppointmentId}.", appointmentId);
                throw;
            }
        }

        public async Task UpdateAppointmentDetailsAsync(int appointmentId, AppointmentDetailDto appointmentExerciseDetails)
        {
            try
            {
                var appointment = await _context.Appointments
                    .Include(a => a.AppointmentDetail)
                        .ThenInclude(ad => ad.AppointmentExerciseDetails)
                    .FirstOrDefaultAsync(a => a.Id == appointmentId);

                if (appointment == null)
                {
                    _logger.LogWarning("Appointment not found for ID {AppointmentId}.", appointmentId);
                    throw new Exception($"Appointment not found for ID {appointmentId}.");
                }

                if (appointment.AppointmentDetail == null)
                {
                    appointment.AppointmentDetail = new AppointmentDetail
                    {
                        AppointmentId = appointmentId,
                        Note = appointmentExerciseDetails.Note
                    };
                }
                else
                {
                    // Update the note if provided
                    appointment.AppointmentDetail.Note = appointmentExerciseDetails.Note;

                    // Clear existing exercise details
                    _context.AppointmentExerciseDetails.RemoveRange(appointment.AppointmentDetail.AppointmentExerciseDetails);
                }

                foreach (var detailDto in appointmentExerciseDetails.AppointmentExerciseDetails)
                {
                    var existingExerciseType = await _context.ExerciseTypes
                        .FindAsync(detailDto.ExerciseType.Id);

                    if (existingExerciseType == null)
                    {
                        _logger.LogError("ExerciseType not found for ID {ExerciseTypeId}.", detailDto.ExerciseType.Id);
                        throw new Exception($"ExerciseType not found for ID {detailDto.ExerciseType.Id}.");
                    }

                    var detail = _mapper.Map<AppointmentExerciseDetail>(detailDto);
                    detail.ExerciseType = existingExerciseType; // Use the existing instance
                    detail.AppointmentId = appointmentId;

                    appointment.AppointmentDetail.AppointmentExerciseDetails.Add(detail);
                }

                await _context.SaveChangesAsync();
                _logger.LogInformation("Updated exercise details for appointment ID {AppointmentId}.", appointmentId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating exercise details for appointment ID {AppointmentId}.", appointmentId);
                throw;
            }
        }

        public async Task FinishBookedAppointmentAsync(int bookedAppointmentId)
        {
            try
            {
                var bookedAppointment = await _context.BookedAppointments.FindAsync(bookedAppointmentId);
                bookedAppointment.IsFinished = true;
                await _context.SaveChangesAsync();
            }
            catch
            {
                _logger.LogError("Error finishing the booked appointment.");
                throw;
            }
        }

        public async Task<List<BookedAppointmentDto>> GetFinishedAppointmentsAsync(int? clientId = null)
        {
            try
            {
                IQueryable<BookedAppointment> query = _context.BookedAppointments
                    .Include(ba => ba.Client)
                        .ThenInclude(p => p.Person)
                    .Where(ba => ba.IsFinished);

                // Filter by client ID if provided
                if (clientId.HasValue)
                {

                    query = query.Where(ba => ba.ClientId == clientId.Value);
                }

                var finishedAppointments = await query.Select(ba => new BookedAppointmentDto
                {
                    Id = ba.Id,
                    AppointmentId = ba.AppointmentServiceTypeDurationCost.Appointment.Id,
                    StartTime = ba.AppointmentServiceTypeDurationCost.Appointment.StartTime,
                    DurationMinutes = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                    ServiceTypeName = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name,
                    HexColor = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor,
                    Capacity = ba.AppointmentServiceTypeDurationCost.Appointment.Capacity,
                    ClientId = ba.Client == null ? -1 : ba.Client.PersonId,
                    ClientFirstName = ba.Client == null ? "-" : ba.Client.Person.FirstName,
                    ClientSecondName = ba.Client == null ? "-" : ba.Client.Person.LastName,
                    Cost = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost,
                    AppointmentBookedDate = ba.AppointmentBookedDate
                }).ToListAsync();

                return finishedAppointments;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving finished appointments.");
                throw;
            }
        }

    }
}

