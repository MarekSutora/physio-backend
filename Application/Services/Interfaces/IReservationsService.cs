using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Model.Entities;
using Shared.DTO.Reservations;
using Shared.DTO.Reservations.Request;
using Shared.DTO.Reservations.Response;

namespace Application.Services.Interfaces
{
    public interface IReservationsService
    {
        Task<bool> CreateAvailableReservationAsync(CreateAvailableReservationDto createAvailableReservationDto);

        Task<List<AvailableReservationDto>> GetAvailableReservationsAsync();

        Task<bool> CreateBookedReservationAsync(BookReservationDto bookedReservationDto);

        //Task<bool> UpdateAvailableReservationAsync(int id, UpdateReservationDto updateReservationDto);
    }
}
