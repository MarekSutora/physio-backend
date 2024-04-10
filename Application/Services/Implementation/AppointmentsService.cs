using Application.Common.Email;
using Application.DTO.Appointments.Both;
using Application.DTO.Appointments.Request;
using Application.DTO.Appointments.Response;
using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public AppointmentsService(ApplicationDbContext context, IMapper mapper, IEmailService emailService, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _emailService = emailService;
            _userManager = userManager;
        }

        public async Task<List<UnbookedAppointmentDto>> GetUnbookedAppointmentsAsync()
        {
            //filter those where astdc servicetype is inactive or servicetypedurationcost has dateto

            var unBookedAppointments = await _context.Appointments
                .Include(a => a.AppointmentServiceTypeDurationCosts)
                    .ThenInclude(astdc => astdc.BookedAppointments)
                .Include(a => a.AppointmentServiceTypeDurationCosts)
                    .ThenInclude(astdc => astdc.ServiceTypeDurationCost)
                        .ThenInclude(stdc => stdc.ServiceType)
                .Include(a => a.AppointmentServiceTypeDurationCosts)
                    .ThenInclude(astdc => astdc.ServiceTypeDurationCost)
                        .ThenInclude(stdc => stdc.DurationCost)
                .Where(a => a.AppointmentServiceTypeDurationCosts
                                   .SelectMany(astdc => astdc.BookedAppointments).Count(ba => !ba.IsFinished) < a.Capacity
                                                      && a.StartTime > DateTime.UtcNow.AddHours(1))
                .Select(a => new
                {
                    Id = a.Id,
                    StartTime = a.StartTime,
                    Capacity = a.Capacity,
                    isActive = a.AppointmentServiceTypeDurationCosts.All(astdc => astdc.ServiceTypeDurationCost.ServiceType.Active),
                    ReservedCount = a.AppointmentServiceTypeDurationCosts
                        .SelectMany(astdc => astdc.BookedAppointments).Count(ba => !ba.IsFinished),
                    ServiceTypeInfos = a.AppointmentServiceTypeDurationCosts
                        .Select(astdc => new ServiceTypeInfoDto
                        {
                            AstdcId = astdc.Id,
                            Name = astdc.ServiceTypeDurationCost.ServiceType.Name,
                            DurationMinutes = astdc.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                            Cost = astdc.ServiceTypeDurationCost.DurationCost.Cost,
                            HexColor = astdc.ServiceTypeDurationCost.ServiceType.HexColor
                        }).ToList()
                }).OrderBy(u => u.StartTime).ToListAsync();

            var unBookedAppointmentsDto = unBookedAppointments
                .Where(u => u.isActive)
                .Select(u => new UnbookedAppointmentDto
                {
                    Id = u.Id,
                    StartTime = u.StartTime,
                    Capacity = u.Capacity,
                    ReservedCount = u.ReservedCount,
                    ServiceTypeInfos = u.ServiceTypeInfos
                }).ToList();


            //var unBookedAppointments = await _context.Appointments
            //    .Where(a => a.AppointmentServiceTypeDurationCosts
            //        .SelectMany(astdc => astdc.BookedAppointments).Count(ba => !ba.IsFinished) < a.Capacity
            //        && a.StartTime > DateTime.UtcNow.AddHours(1))
            //    .Select(a => new UnbookedAppointmentDto
            //    {
            //        Id = a.Id,
            //        StartTime = a.StartTime,
            //        Capacity = a.Capacity,
            //        ReservedCount = a.AppointmentServiceTypeDurationCosts
            //            .SelectMany(astdc => astdc.BookedAppointments).Count(ba => !ba.IsFinished),
            //        ServiceTypeInfos = a.AppointmentServiceTypeDurationCosts
            //            .Select(astdc => new ServiceTypeInfoDto
            //            {
            //                AstdcId = astdc.Id,
            //                Name = astdc.ServiceTypeDurationCost.ServiceType.Name,
            //                DurationMinutes = astdc.ServiceTypeDurationCost.DurationCost.DurationMinutes,
            //                Cost = astdc.ServiceTypeDurationCost.DurationCost.Cost,
            //                HexColor = astdc.ServiceTypeDurationCost.ServiceType.HexColor
            //            }).ToList()
            //    }).OrderBy(u => u.StartTime).ToListAsync();

            return unBookedAppointmentsDto;
        }

        public async Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId, string userId)
        {
            var appointment = await _context.Appointments
                .Include(a => a.AppointmentServiceTypeDurationCosts)
                    .ThenInclude(astdc => astdc.BookedAppointments).ThenInclude(ba => ba.Person).ThenInclude(p => p.ApplicationUser)
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
                throw new Exception("Appointment not found.");
            }
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new Exception("User not found.");
            }

            var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
            var isUserOwnAppointment = appointment.AppointmentServiceTypeDurationCosts.Any(astdc => astdc.BookedAppointments.Any(ba => ba.Person.ApplicationUser.Id == userId));

            if (!isAdmin && !isUserOwnAppointment)
            {
                throw new UnauthorizedAccessException("You do not have permission to access this appointment.");
            }

            var appointmentDto = _mapper.Map<AppointmentDto>(appointment);

            return appointmentDto;
        }


        public async Task<List<BookedAppointmentDto>> GetFinishedAppointmentsAsync(int? personId = null)
        {
            var finishedAppointmentsQuery = _context.BookedAppointments
                    .Include(p => p.Person)
                .Where(ba => ba.IsFinished);

            if (personId.HasValue)
            {

                finishedAppointmentsQuery = finishedAppointmentsQuery.Where(ba => ba.PersonId == personId.Value);
            }

            var finishedAppointments = await finishedAppointmentsQuery.Select(ba => new BookedAppointmentDto
            {
                Id = ba.Id,
                AppointmentId = ba.AppointmentServiceTypeDurationCost.Appointment.Id,
                StartTime = ba.AppointmentServiceTypeDurationCost.Appointment.StartTime,
                DurationMinutes = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                ServiceTypeName = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name,
                HexColor = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor,
                Capacity = ba.AppointmentServiceTypeDurationCost.Appointment.Capacity,
                PersonId = ba.Person == null ? -1 : ba.PersonId,
                ClientFirstName = ba.Person == null ? "-" : ba.Person.FirstName,
                ClientSecondName = ba.Person == null ? "-" : ba.Person.LastName,
                Cost = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost,
                AppointmentBookedDate = ba.AppointmentBookedDate
            }).ToListAsync();

            return finishedAppointments;
        }

        public async Task<List<BookedAppointmentDto>> GetBookedAppointmentsAsync(int? personId = null)
        {
            var bookedAppointmentsQuery = _context.BookedAppointments
                .Include(p => p.Person)
                .Where(ba => !ba.IsFinished);

            if (personId.HasValue)
            {
                bookedAppointmentsQuery = bookedAppointmentsQuery.Where(ba => ba.PersonId == personId.Value);
            }

            var bookedAppointments = await bookedAppointmentsQuery.Select(ba => new BookedAppointmentDto
            {
                Id = ba.Id,
                AppointmentId = ba.AppointmentServiceTypeDurationCost.Appointment.Id,
                StartTime = ba.AppointmentServiceTypeDurationCost.Appointment.StartTime,
                DurationMinutes = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes,
                ServiceTypeName = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name,
                HexColor = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor,
                Capacity = ba.AppointmentServiceTypeDurationCost.Appointment.Capacity,
                PersonId = ba.Person == null ? -1 : ba.PersonId,
                ClientFirstName = ba.Person == null ? "-" : ba.Person.FirstName,
                ClientSecondName = ba.Person == null ? "-" : ba.Person.LastName,
                Cost = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost,
                AppointmentBookedDate = ba.AppointmentBookedDate
            }).ToListAsync();

            return bookedAppointments;
        }

        public async Task CreateAppointmentAsync(CreateAppointmentDto createAppointmentDto)
        {
            if (createAppointmentDto.StdcIds.Count > 1 && createAppointmentDto.Capacity > 1)
            {
                throw new Exception("Only one service type can be selected for multiple capacity appointments.");
            }

            var appointment = new Appointment
            {
                StartTime = createAppointmentDto.StartTime.AddHours(2),
                Capacity = createAppointmentDto.Capacity,
            };


            var stdcs = await _context.ServiceTypeDurationCosts
                                      .Where(stdc => createAppointmentDto.StdcIds.Contains(stdc.Id))
                                      .ToListAsync();


            appointment.ServiceTypeDurationCosts.AddRange(stdcs);

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task CreateBookedAppointmentAsync(CreateBookedAppointmentDto createBookedAppointmentDto, int personId)
        {

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var client = await _context.Persons.Include(p => p.ApplicationUser).FirstOrDefaultAsync(p => p.ApplicationUser.PersonId == personId);
                    if (client == null) throw new Exception("Client not found.");

                    var astdc = await _context.AppointmentServiceTypeDurationCosts
                                  .Include(x => x.Appointment)
                                  .ThenInclude(x => x.AppointmentServiceTypeDurationCosts)
                                  .ThenInclude(x => x.BookedAppointments)
                                  .FirstOrDefaultAsync(x => x.Id == createBookedAppointmentDto.AstdcId);

                    if (astdc == null) throw new Exception("AppointmentServiceTypeDurationCost not found.");
                    if (astdc.Appointment == null) throw new Exception("Appointment not found.");

                    if (astdc.Appointment.StartTime < DateTime.UtcNow.AddHours(2)) throw new Exception("Appointment has already started.");

                    bool isAlreadyBooked = astdc.Appointment.AppointmentServiceTypeDurationCosts
                                  .SelectMany(x => x.BookedAppointments)
                                  .Any(ba => ba.PersonId == personId);

                    if (isAlreadyBooked) throw new Exception("Client has already booked this appointment.");

                    int totalBookings = astdc.Appointment.AppointmentServiceTypeDurationCosts
                            .Sum(x => x.BookedAppointments.Count);

                    if (totalBookings >= astdc.Appointment.Capacity) throw new Exception("Appointment is fully booked.");

                    var bookedAppointment = new BookedAppointment
                    {
                        AppointmentServiceTypeDurationCostId = createBookedAppointmentDto.AstdcId,
                        AppointmentBookedDate = DateTime.UtcNow.AddHours(2),
                        PersonId = personId
                    };

                    _context.BookedAppointments.Add(bookedAppointment);
                    await _context.SaveChangesAsync();

                    bookedAppointment = await _context.BookedAppointments
                        .Include(ba => ba.AppointmentServiceTypeDurationCost)
                            .ThenInclude(astdc => astdc.ServiceTypeDurationCost)
                                .ThenInclude(stdc => stdc.ServiceType)
                        .Include(ba => ba.AppointmentServiceTypeDurationCost)
                            .ThenInclude(astdc => astdc.ServiceTypeDurationCost)
                                .ThenInclude(stdc => stdc.DurationCost)
                        .FirstOrDefaultAsync(ba => ba.Id == bookedAppointment.Id);

                    var emailRequest = new EmailRequest
                    {
                        ToEmail = client.ApplicationUser.UserName,
                        Subject = "Potvrdenie rezervácie",
                        Body = $@"<h1>Rezervácia úspešná</h1>
                                <p>Ďakujeme za rezerváciu. Tento email je potvrdením, že ste si úspešne zarezervovali termín.</p>
                                <p>Termín: {bookedAppointment.AppointmentServiceTypeDurationCost.Appointment.StartTime}</p>
                                <p>Typ služby: {bookedAppointment.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name}</p>
                                <p>Čas trvania: {bookedAppointment.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes} minút</p>
                                <p>Cena: {bookedAppointment.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost.ToString("0.00")} €</p>
                                <p>Ďakujeme, že ste si vybrali naše služby.</p>
                                <p>S pozdravom,<br>Váš tím</p>"
                    };

                    await _emailService.SendEmailAsync(emailRequest);
                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }

        }

        public async Task UpdateAppointmentDetailsAsync(int appointmentId, AppointmentDetailDto appointmentExerciseDetails)
        {

            var appointment = await _context.Appointments
                .Include(a => a.AppointmentDetail)
                .ThenInclude(ad => ad.AppointmentExerciseDetails)
                .FirstOrDefaultAsync(a => a.Id == appointmentId);

            if (appointment == null)
            {
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
                appointment.AppointmentDetail.Note = appointmentExerciseDetails.Note;

                _context.AppointmentExerciseDetails.RemoveRange(appointment.AppointmentDetail.AppointmentExerciseDetails);
            }

            foreach (var detailDto in appointmentExerciseDetails.AppointmentExerciseDetails)
            {
                var existingExerciseType = await _context.ExerciseTypes
                    .FindAsync(detailDto.ExerciseType.Id);

                if (existingExerciseType == null)
                {
                    throw new Exception($"ExerciseType not found for ID {detailDto.ExerciseType.Id}.");
                }

                var detail = _mapper.Map<AppointmentExerciseDetail>(detailDto);
                detail.ExerciseType = existingExerciseType;

                appointment.AppointmentDetail.AppointmentExerciseDetails.Add(detail);
            }

            await _context.SaveChangesAsync();
        }

        public async Task FinishBookedAppointmentAsync(int bookedAppointmentId)
        {

            var bookedAppointment = await _context.BookedAppointments.FindAsync(bookedAppointmentId);

            if (bookedAppointment == null)
            {
                throw new Exception($"BookedAppointment not found for ID {bookedAppointmentId}.");
            }

            bookedAppointment.IsFinished = true;
            await _context.SaveChangesAsync();

        }

        public async Task DeleteBookedAppointmentAsync(int bookedAppointmentId)
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

        public async Task DeleteAppointmentAsync(int appointmentId)
        {

            var appointment = await _context.Appointments
                .Include(a => a.AppointmentServiceTypeDurationCosts)
                .FirstOrDefaultAsync(a => a.Id == appointmentId);

            if (appointment == null)
            {
                throw new Exception("Appointment not found.");
            }

            _context.AppointmentServiceTypeDurationCosts.RemoveRange(appointment.AppointmentServiceTypeDurationCosts);

            _context.Appointments.Remove(appointment);

            await _context.SaveChangesAsync();
        }
    }
}

