using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Model.Entities;
using Shared.DTO.Reservations;

namespace Application.Services.Interfaces
{
    public interface IReservationsService
    {
        Task<List<AvailableReservationDto>> GetAvailableReservationsWithServiceTypesAsync();
    }
}
