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

        Task<List<BookedAppointmentDto>> GetBookedAppointmentsAsync();

        Task DeleteAppointmentAsync(int appointmentId);

        Task AdminCreateBookedAppointmentAsync(AdminBookedAppointmentDto bookedAppointmentDto);

        Task ClientCreateBookedAppointmentAsync(ClientBookedAppointmentDto clientBookedAppointmentDto, string userId);

        Task DeleteBookedAppointmentAsync(int bookedAppointmentId);

        Task<AppointmentInfoDto> GetAppointmentByIdAsync(int appointmentId);
    }
}
