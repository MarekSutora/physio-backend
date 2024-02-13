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

        Task CancelAppointmentAsync(CancelBookedAppointmentDto cancelBookedAppointmentDto, string userId, bool isAdmin);

        Task DeleteAppointmentAsync(DeleteAppointmentDto deleteAppointmentDto);

        Task AdminCreateBookedAppointmentAsync(AdminBookedAppointmentDto bookedAppointmentDto);

        Task ClientCreateBookedAppointmentAsync(ClientBookedAppointmentDto clientBookedAppointmentDto, string userId);


    }
}
