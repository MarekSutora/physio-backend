using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Model.Entities;
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

        Task AdminCreateBookedAppointmentAsync(AdminBookedAppointmentDto bookedAppointmentDto);

        Task ClientCreateBookedAppointmentAsync(ClientBookedAppointmentDto clientBookedAppointmentDto, string userId);

        Task DeleteBookedAppointmentAsync(int bookedAppointmentId);

        Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId);

        Task UpdateAppointmentDetailsAsync(int appointmentId, AppointmentDetailDto appointmentExerciseDetails);

        Task FinishBookedAppointmentAsync(int bookedAppointmentId);

        Task<List<BookedAppointmentDto>> GetFinishedAppointmentsAsync(int? clientId = null);

        Task<List<BookedAppointmentDto>> GetBookedAppointmentsAsync(int? clientId = null);
    }
}
