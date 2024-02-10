using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;


namespace Application.Services.Implementation
{
    public class ServiceTypeService : IServiceTypeService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ServiceTypeService> _logger;

        public ServiceTypeService(ApplicationDbContext context, IMapper mapper, ILogger<ServiceTypeService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        // Creates a new ServiceType along with associated DurationCosts and ServiceTypeDurationCosts
        public async Task<bool> CreateServiceTypeAsync(CreateServiceTypeDto createNewServiceTypeDto)
        {
            try
            {
                var serviceType = _mapper.Map<ServiceType>(createNewServiceTypeDto);
                // Log the creation attempt
                _logger.LogInformation("Attempting to create a new ServiceType: {ServiceTypeName}", serviceType.Name);


                await _context.ServiceTypes.AddAsync(serviceType);
                bool result = await _context.SaveChangesAsync() > 0;
                // Log the result
                _logger.LogInformation("ServiceType creation {Result}", result ? "succeeded" : "failed");

                return result;
            }
            catch (Exception e)
            {
                // Log the exception
                _logger.LogError(e, "Error creating ServiceType: {Message}", e.Message);
                return false;
            }
        }

        public async Task<bool> SoftDeleteServiceTypeAsync(int id)
        {
            try
            {
                _logger.LogInformation("Attempting to soft delete ServiceType with ID: {ServiceTypeId}", id);

                var serviceType = await _context.ServiceTypes.FindAsync(id);

                if (serviceType == null)
                {
                    _logger.LogWarning("Soft delete failed: ServiceType with ID: {ServiceTypeId} not found.", id);
                    return false;
                }

                serviceType.Active = false;

                foreach (var stdc in serviceType.ServiceTypeDurationCosts)
                {
                    stdc.DateTo = DateTime.Now;
                }

                _context.ServiceTypes.Update(serviceType);
                await _context.SaveChangesAsync();

                _logger.LogInformation("ServiceType with ID: {ServiceTypeId} soft deleted successfully.", id);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error soft deleting ServiceType with ID: {ServiceTypeId}. Exception: {ExceptionMessage}", id, e.Message);
                return false;
            }
        }

        public async Task<List<ServiceTypeDto>> GetAllActiveServiceTypesAsync()
        {
            _logger.LogInformation("Retrieving all active ServiceTypes with current DurationCosts.");
            try
            {
                var serviceTypes = await _context.ServiceTypes
                    .Where(st => st.Active)
                    .Include(st => st.ServiceTypeDurationCosts)
                        .ThenInclude(stdc => stdc.DurationCost)
                    .ToListAsync();

                _logger.LogInformation("Retrieved {Count} active ServiceTypes with current DurationCosts.", serviceTypes.Count);
                return _mapper.Map<List<ServiceTypeDto>>(serviceTypes);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error retrieving active ServiceTypes with current DurationCosts.");
                throw; // Preserve the original stack trace
            }
        }



        //Todo validacia ze dat return true ak sa updatne na uplne rovnake hodnoty (mozno aj na FE)
        public async Task<bool> UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto)
        {
            try
            {
                var serviceType = await _context.ServiceTypes
                    .Include(st => st.ServiceTypeDurationCosts)
                    .ThenInclude(stdc => stdc.DurationCost)
                    .FirstOrDefaultAsync(st => st.Id == updateServiceTypeDto.Id);

                if (serviceType == null)
                {
                    _logger.LogWarning("Update failed: ServiceType with ID: {ServiceTypeId} not found.", updateServiceTypeDto.Id);
                    return false;
                }

                // Update serviceType properties
                serviceType.Name = updateServiceTypeDto.Name;
                serviceType.Description = updateServiceTypeDto.Description;
                serviceType.HexColor = updateServiceTypeDto.HexColor;

                // Convert DTO list to a set for efficient lookups
                var dtoDurations = new HashSet<(int DurationMinutes, decimal Cost)>(
                    updateServiceTypeDto.DurationCosts.Select(dto => (dto.DurationMinutes, dto.Cost))
                );

                // Update and add new associations
                foreach (var dto in updateServiceTypeDto.DurationCosts)
                {
                    var existingAssociation = serviceType.ServiceTypeDurationCosts
                        .Find(stdc => stdc.DurationCost.DurationMinutes == dto.DurationMinutes && stdc.DurationCost.Cost == dto.Cost);

                    if (existingAssociation == null)
                    {
                        var durationCost = new DurationCost { DurationMinutes = dto.DurationMinutes, Cost = dto.Cost };
                        serviceType.ServiceTypeDurationCosts.Add(new ServiceTypeDurationCost
                        {
                            ServiceType = serviceType,
                            DurationCost = durationCost
                        });
                    }
                    // No else part needed, as we keep existing matches
                }

                // Remove or deactivate old associations
                foreach (var association in serviceType.ServiceTypeDurationCosts)
                {
                    var durationCost = association.DurationCost;
                    if (!dtoDurations.Contains((durationCost.DurationMinutes, durationCost.Cost)))
                    {
                        association.DateTo = DateTime.Now; // Mark as inactive
                    }
                }

                bool result = await _context.SaveChangesAsync() > 0;

                _logger.LogInformation("ServiceType with ID: {ServiceTypeId} updated {Result}.", updateServiceTypeDto.Id, result ? "successfully" : "unsuccessfully");
                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error updating ServiceType with ID: {ServiceTypeId}. Exception: {ExceptionMessage}", updateServiceTypeDto.Id, e.Message);
                return false;
            }
        }

    }
}
