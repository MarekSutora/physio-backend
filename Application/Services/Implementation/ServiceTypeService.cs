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
    //TODO - poriadne vyriesit logging, exception handling
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
                // Vytvorte inštanciu entity ServiceType z DTO pomocou AutoMapper
                var serviceType = _mapper.Map<ServiceType>(createNewServiceTypeDto);

                // Pridajte novú službu do kontextu
                await _context.ServiceTypes.AddAsync(serviceType);

                // Uložte zmeny v databáze
                var saved = await _context.SaveChangesAsync();
                return saved > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<bool> SoftDeleteServiceTypeAsync(int id)
        {
            try
            {
                var serviceType = await _context.ServiceTypes.FindAsync(id);
                if (serviceType == null) return false;

                // Mark as inactive and rename
                serviceType.Active = false;
                serviceType.Name += $"_odstranena_{DateTime.Now:yyyyMMdd}";

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error soft-deleting service type: {e.Message}", e);
            }
        }

        public async Task<List<ServiceTypeDto>> GetAllActiveServiceTypesAsync()
        {
            try
            {
                var serviceTypes = await _context.ServiceTypes
                    .Where(st => st.Active)
                    .Include(st => st.ServiceTypeDurationCosts.Where(cost => cost.Active))
                    .ToListAsync();

                return _mapper.Map<List<ServiceTypeDto>>(serviceTypes);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting active service types.", ex);
            }
        }

        public async Task<bool> UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto)
        {
            var serviceType = await _context.ServiceTypes
                .Include(st => st.ServiceTypeDurationCosts)
                .FirstOrDefaultAsync(st => st.Id == updateServiceTypeDto.Id && st.Active);

            if (serviceType == null) return false;

            // Mark existing duration costs as inactive
            foreach (var cost in serviceType.ServiceTypeDurationCosts)
            {
                cost.Active = false;
            }

            // Add new duration costs
            var newCosts = _mapper.Map<List<ServiceTypeDurationCost>>(updateServiceTypeDto.ServiceTypeDurationCosts);
            foreach (var newCost in newCosts)
            {
                newCost.ServiceTypeId = serviceType.Id;
                _context.ServiceTypeDurationCosts.Add(newCost);
            }

            // Update service type details
            _mapper.Map(updateServiceTypeDto, serviceType);

            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
