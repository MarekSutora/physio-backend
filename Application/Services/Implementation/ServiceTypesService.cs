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

        public async Task<bool> CreateServiceTypeAsync(CreateServiceTypeDto createNewServiceTypeDto)
        {
            try
            {
                var existingServiceType = await _context.ServiceTypes
                    .Include(st => st.ServiceTypeDurationCosts)
                    .ThenInclude(stdc => stdc.DurationCost)
                    .FirstOrDefaultAsync(st => st.Name.Equals(createNewServiceTypeDto.Name, StringComparison.OrdinalIgnoreCase));

                if (existingServiceType != null && !existingServiceType.Active)
                {
                    // If it exists and is not active, reactivate it
                    existingServiceType.Active = true;

                    // Update the existing ServiceTypeDurationCosts to set DateTo to Now + 1 hour
                    foreach (var stdc in existingServiceType.ServiceTypeDurationCosts)
                    {
                        stdc.DateTo = DateTime.UtcNow.AddHours(1);
                    }

                    // Add new ServiceTypeDurationCosts based on the DTO
                    foreach (var durationCostDto in createNewServiceTypeDto.DurationCosts)
                    {
                        var durationCost = new DurationCost
                        {
                            DurationMinutes = durationCostDto.DurationMinutes,
                            Cost = durationCostDto.Cost
                        };
                        _context.DurationCosts.Add(durationCost);

                        existingServiceType.ServiceTypeDurationCosts.Add(new ServiceTypeDurationCost
                        {
                            DurationCost = durationCost
                        });
                    }
                }
                else
                {
                    // If it does not exist, create a new ServiceType as usual
                    var newServiceType = _mapper.Map<ServiceType>(createNewServiceTypeDto);
                    _context.ServiceTypes.Add(newServiceType);
                }

                await _context.SaveChangesAsync();

                _logger.LogInformation("ServiceType created or reactivated successfully.");

                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error creating or reactivating ServiceType: {Message}", e.Message);
                throw;
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

                serviceType.Name = updateServiceTypeDto.Name;
                serviceType.Description = updateServiceTypeDto.Description;
                serviceType.HexColor = updateServiceTypeDto.HexColor;
                serviceType.IconName = updateServiceTypeDto.IconName;
                serviceType.ImageUrl = updateServiceTypeDto.ImageUrl;


                // Handle existing associations
                var currentDurationCosts = serviceType.ServiceTypeDurationCosts.ToList();
                foreach (var current in currentDurationCosts)
                {
                    if (!updateServiceTypeDto.DurationCosts.Exists(dto => dto.DurationMinutes == current.DurationCost.DurationMinutes && dto.Cost == current.DurationCost.Cost))
                    {
                        current.DateTo = DateTime.Now; // Mark the end date of the current association
                    }
                }

                // Handle new associations
                foreach (var dto in updateServiceTypeDto.DurationCosts)
                {
                    var existingDurationCost = await _context.DurationCosts
                        .FirstOrDefaultAsync(dc => dc.DurationMinutes == dto.DurationMinutes && dc.Cost == dto.Cost);

                    if (existingDurationCost == null)
                    {
                        existingDurationCost = new DurationCost
                        {
                            DurationMinutes = dto.DurationMinutes,
                            Cost = dto.Cost
                        };
                        _context.DurationCosts.Add(existingDurationCost);
                    }

                    if (!serviceType.ServiceTypeDurationCosts.Exists(stdc => stdc.DurationCost == existingDurationCost && stdc.DateTo == null))
                    {
                        serviceType.ServiceTypeDurationCosts.Add(new ServiceTypeDurationCost
                        {
                            DurationCost = existingDurationCost
                        });
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
