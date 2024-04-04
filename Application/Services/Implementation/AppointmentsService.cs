using DataAccess;
using Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.DTO.Appointments.Request;
using Application.DTO.Appointments.Response;
using AutoMapper;
using DataAccess.Entities;
using Application.Common.Email;
using Microsoft.AspNetCore.Identity;
using Application.DTO.Appointments.Both;

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

            var unBookedAppointmentsQuery = _context.AppointmentServiceTypeDurationCosts
                .Include(astdc => astdc.BookedAppointments)
                .Include(astdc => astdc.ServiceTypeDurationCost)
                    .ThenInclude(stdc => stdc.ServiceType)
                .Include(astdc => astdc.ServiceTypeDurationCost)
                    .ThenInclude(stdc => stdc.DurationCost)
                .Where(astdc => astdc.BookedAppointments.Count < astdc.Appointment.Capacity
                        && astdc.Appointment.StartTime > DateTime.UtcNow.AddHours(1) && astdc.ServiceTypeDurationCost.DateTo == null)
                .Select(astdc => new
                {
                    astdc.Appointment,
                    BookedCount = astdc.BookedAppointments.Count,
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
                    Id = g.Key.Id,
                    StartTime = g.Key.StartTime,
                    Capacity = g.Key.Capacity,
                    ReservedCount = g.Sum(x => x.BookedCount), // Aggregate the count here
                    ServiceTypeInfos = g.Select(x => x.ServiceTypeInfo).ToList()
                });

            return groupedAppointments.ToList();
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

            var client = await _context.Persons.FindAsync(personId);

            if (client == null)
            {
                throw new Exception("Client not found.");
            }

            var bookedAppointment = new BookedAppointment
            {
                AppointmentServiceTypeDurationCostId = createBookedAppointmentDto.AstdcId,
                AppointmentBookedDate = DateTime.Now,
                PersonId = personId,
            };

            var appointmentServiceTypeDurationCost = await _context.AppointmentServiceTypeDurationCosts
                .Include(astdc => astdc.Appointment)
                .Include(astdc => astdc.ServiceTypeDurationCost)
                    .ThenInclude(stdc => stdc.ServiceType)
                .Include(astdc => astdc.ServiceTypeDurationCost)
                    .ThenInclude(stdc => stdc.DurationCost)
                .FirstOrDefaultAsync(astdc => astdc.Id == createBookedAppointmentDto.AstdcId);

            if (appointmentServiceTypeDurationCost == null)
            {
                throw new Exception("AppointmentServiceTypeDurationCost not found.");
            }

            var capacity = appointmentServiceTypeDurationCost.Appointment.Capacity;

            // Check if the appointment is fully booked
            var existingBookingsCount = await _context.BookedAppointments
                .CountAsync(ba => ba.AppointmentServiceTypeDurationCostId == createBookedAppointmentDto.AstdcId);

            if (existingBookingsCount >= capacity)
            {
                throw new Exception("Appointment is fully booked.");
            }

            _context.BookedAppointments.Add(bookedAppointment);

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

            await _context.SaveChangesAsync();
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

