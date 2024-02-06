using DataAccess.Model.Entities;
using Shared.DTO.ServiceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IServiceTypeService
    {
        Task<bool> CreateServiceTypeAsync(CreateNewServiceTypeDto createNewServiceTypeDto);
        Task<(bool, string)> DeleteServiceTypeAsync(int id);
        Task<List<ServiceTypeDto>> GetAllServiceTypesAsync();
        Task<bool> UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto);
    }
}
