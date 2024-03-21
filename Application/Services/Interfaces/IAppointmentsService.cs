using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entities;
using Shared.DTO.Appointments;
using Shared.DTO.Appointments.Request;
using Shared.DTO.Appointments.Response;

namespace Application.Services.Interfaces
{
    public interface IAppointmentsService
    {
        Task CreateAppointmentAsync(CreateAppointmentDto createAppointmentDto);

        Task<List<UnbookedAppointmentDto>> GetUnbookedAppointmentsAsync();

        Task DeleteAppointmentAsync(int appointmentId);

        Task CreateBookedAppointmentAsync(CreateBookedAppointmentDto createBookedAppointmentDto, int clientId?);

        Task DeleteBookedAppointmentAsync(int bookedAppointmentId);

        Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId);

        Task UpdateAppointmentDetailsAsync(int appointmentId, AppointmentDetailDto appointmentExerciseDetails);

        Task FinishBookedAppointmentAsync(int bookedAppointmentId);

        Task<List<BookedAppointmentDto>> GetFinishedAppointmentsAsync(int? clientId = null);

        Task<List<BookedAppointmentDto>> GetBookedAppointmentsAsync(int? clientId = null);
    }
}
