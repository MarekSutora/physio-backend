using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.DTO.ServiceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class ServiceTypeService : IServiceTypeService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ServiceTypeService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateServiceTypeAsync(CreateNewServiceTypeDto createNewServiceTypeDto)
        {
            try
            {
                var serviceType = _mapper.Map<ServiceType>(createNewServiceTypeDto);

                // Create and add associated DurationCosts (and nested ServiceTypeDurationCost) 
                foreach (var costDto in createNewServiceTypeDto.DurationCosts)
                {
                    var newDurationCost = new DurationCost
                    {
                        DurationMinutes = costDto.DurationMinutes,
                        Cost = costDto.Cost
                    };

                    var newServiceTypeDurationCost = new ServiceTypeDurationCost
                    {
                        ServiceType = serviceType,
                        DurationCost = newDurationCost,
                        DateFrom = DateTime.Now // Assuming validity starts from creation
                    };

                    serviceType.ServiceTypeDurationCosts.Add(newServiceTypeDurationCost);
                }

                await _context.ServiceTypes.AddAsync(serviceType);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        // ... (SoftDeleteServiceTypeAsync - No changes were necessary)

        public async Task<List<ServiceTypeDto>> GetAllActiveServiceTypesAsync()
        {
            var serviceTypes = await _context.ServiceTypes
                .Where(st => st.Active)
                .Include(st => st.ServiceTypeDurationCosts) // Eager load 
                .ThenInclude(stdc => stdc.DurationCost)  // ... and DurationCosts
                .ToListAsync();

            return _mapper.Map<List<ServiceTypeDto>>(serviceTypes);
        }

        public async Task<bool> UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto)
        {
            var serviceType = await _context.ServiceTypes
                .Include(st => st.ServiceTypeDurationCosts)
                .ThenInclude(stdc => stdc.DurationCost)
                .FirstOrDefaultAsync(st => st.Id == updateServiceTypeDto.Id && st.Active);

            if (serviceType == null) return false;

            // Mark old costs as inactive
            foreach (var stdc in serviceType.ServiceTypeDurationCosts)
            {
                stdc.DateTo = DateTime.Now; // Set end date
            }

            // Create and add new costs 
            foreach (var newCostDto in updateServiceTypeDto.DurationCosts)
            {
                var newDurationCost = new DurationCost
                {
                    DurationMinutes = newCostDto.DurationMinutes,
                    Cost = newCostDto.Cost
                };

                var newStdc = new ServiceTypeDurationCost
                {
                    ServiceType = serviceType,
                    DurationCost = newDurationCost,
                    DateFrom = DateTime.Now.Date // Start date
                };

                serviceType.ServiceTypeDurationCosts.Add(newStdc);
            }

            // Update ServiceType properties
            _mapper.Map(updateServiceTypeDto, serviceType);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
