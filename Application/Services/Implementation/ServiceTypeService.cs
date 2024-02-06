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

        public async Task<(bool, string)> DeleteServiceTypeAsync(int id)
        {
            try
            {
                // Overte, či existuje nejaká rezervácia, ktorá obsahuje daný typ služby
                bool hasReservations = await _context.AvailableReservationServiceTypes
                    .AnyAsync(arst => arst.ServiceTypeId == id);

                if (hasReservations)
                {
                    // Neumožnite odstránenie služby a vráťte správu s false
                    return (false, "Služba sa nedá odstrániť, pretože je s ňou spojená aktívna rezervácia.");
                }

                // Ak neexistujú žiadne aktívne rezervácie spojené s týmto typom služby, odstráňte službu
                var serviceType = await _context.ServiceTypes.FindAsync(id);
                if (serviceType != null)
                {
                    _context.ServiceTypes.Remove(serviceType);
                    await _context.SaveChangesAsync();
                    return (true, "Služba bola úspešne odstránená.");
                }

                return (false, "Služba s daným ID nebola nájdená.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (false, $"Pri odstraňovaní služby došlo k chybe: {e.Message}");
            }
        }


        public async Task<List<ServiceTypeDto>> GetAllServiceTypesAsync()
        {
            try
            {
                var serviceTypes = await _context.ServiceTypes
                         .Include(st => st.ServiceTypeDurationCosts)
                         .ToListAsync();

                // Use AutoMapper to map from ServiceType entities to ServiceTypeDto
                return _mapper.Map<List<ServiceTypeDto>>(serviceTypes);
            }
            catch (Exception ex)
            {
                // Log the exception here using a logger
                // For example: _logger.LogError(ex, "An error occurred while getting all service types.");
                throw new Exception("An error occurred while getting all service types.", ex);
            }
        }


        public async Task<bool> UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto)
        {
            var serviceType = await _context.ServiceTypes
                .Include(st => st.ServiceTypeDurationCosts)
                .FirstOrDefaultAsync(st => st.Id == updateServiceTypeDto.Id);

            if (serviceType == null)
            {
                return false; // ServiceType doesn't exist
            }

            // Odstránenie existujúcich ServiceTypeDurationCosts
            _context.ServiceTypeDurationCosts.RemoveRange(serviceType.ServiceTypeDurationCosts);

            // Pridanie nových ServiceTypeDurationCosts
            foreach (var durationCostDto in updateServiceTypeDto.ServiceTypeDurationCosts)
            {
                serviceType.ServiceTypeDurationCosts.Add(new ServiceTypeDurationCost
                {
                    DurationMinutes = durationCostDto.DurationMinutes,
                    Cost = durationCostDto.Cost,
                    ServiceTypeId = serviceType.Id
                });
            }

            // Aktualizácia vlastností ServiceType
            serviceType.Name = updateServiceTypeDto.Name;
            serviceType.Description = updateServiceTypeDto.Description;
            serviceType.HexColor = updateServiceTypeDto.HexColor;

            // Uloženie zmien
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
