﻿using DataAccess.Model.Entities;
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    //TODO pluralize the name of the interface
    public interface IServiceTypeService
    {
        Task<bool> CreateServiceTypeAsync(CreateServiceTypeDto createNewServiceTypeDto);
        Task<bool> SoftDeleteServiceTypeAsync(int id);
        Task<List<ServiceTypeDto>> GetAllActiveServiceTypesAsync();
        Task<bool> UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto);
    }
}
