using DataAccess;
using Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.DTO.Appointments.Request;
using Application.DTO.Appointments.Response;
using AutoMapper;
using DataAccess.Entities;

namespace Application.Services.Implementation
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AppointmentsService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public async Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId)
        {
            var appointment = await _context.Appointments
                .Include(a => a.AppointmentServiceTypeDurationCosts)
                    .ThenInclude(astdc => astdc.BookedAppointments).ThenInclude(p => p.Person)
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
                throw new Exception($"Appointment not found for ID {appointmentId}.");
            }

            var appointmentDto = _mapper.Map<AppointmentDto>(appointment);

            return appointmentDto;
        }


        public async Task<List<BookedAppointmentDto>> GetFinishedAppointmentsAsync(int? clientId = null)
        {
            var finishedAppointmentsQuery = _context.BookedAppointments
                    .Include(p => p.Person)
                .Where(ba => ba.IsFinished);

            if (clientId.HasValue)
            {

                finishedAppointmentsQuery = finishedAppointmentsQuery.Where(ba => ba.PersonId == clientId.Value);
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
                ClientId = ba.Person == null ? -1 : ba.PersonId,
                ClientFirstName = ba.Person == null ? "-" : ba.Person.FirstName,
                ClientSecondName = ba.Person == null ? "-" : ba.Person.LastName,
                Cost = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost,
                AppointmentBookedDate = ba.AppointmentBookedDate
            }).ToListAsync();

            return finishedAppointments;
        }

        public async Task<List<BookedAppointmentDto>> GetBookedAppointmentsAsync(int? clientId = null)
        {
            var bookedAppointmentsQuery = _context.BookedAppointments
                .Include(p => p.Person)
                .Where(ba => !ba.IsFinished);

            if (clientId.HasValue)
            {
                bookedAppointmentsQuery = bookedAppointmentsQuery.Where(ba => ba.PersonId == clientId.Value);
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
                ClientId = ba.Person == null ? -1 : ba.PersonId,
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
                StartTime = createAppointmentDto.StartTime,
                Capacity = createAppointmentDto.Capacity,
            };


            var stdcs = await _context.ServiceTypeDurationCosts
                                      .Where(stdc => createAppointmentDto.StdcIds.Contains(stdc.Id))
                                      .ToListAsync();

            appointment.ServiceTypeDurationCosts.AddRange(stdcs);

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task CreateBookedAppointmentAsync(CreateBookedAppointmentDto createBookedAppointmentDto, int clientId)
        {

            var client = await _context.Persons.FindAsync(clientId);

            if (client == null)
            {
                throw new Exception("Client not found.");
            }

            var bookedAppointment = new BookedAppointment
            {
                AppointmentServiceTypeDurationCostId = createBookedAppointmentDto.astdcId,
                AppointmentBookedDate = DateTime.Now,
                PersonId = clientId,
            };

            var existingBookingsCount = await _context.BookedAppointments
                        .CountAsync(ba => ba.AppointmentServiceTypeDurationCostId == createBookedAppointmentDto.astdcId);

            var capacity = await _context.AppointmentServiceTypeDurationCosts
                .Where(astdc => astdc.Id == createBookedAppointmentDto.astdcId)
                .Select(astdc => astdc.Appointment.Capacity)
                .FirstOrDefaultAsync();

            if (existingBookingsCount >= capacity)
            {
                throw new Exception("Appointment is fully booked.");
            }

            _context.BookedAppointments.Add(bookedAppointment);

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

