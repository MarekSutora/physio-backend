using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Application.DTO.ServiceType.Request;
using Application.DTO.ServiceType.Response;


namespace Application.Services.Implementation
{
    public class ServiceTypeService : IServiceTypesService
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

        public async Task<List<ServiceTypeDto>> GetActiveServiceTypesAsync()
        {
            var serviceTypes = await _context.ServiceTypes
                .Where(st => st.Active)
                .Include(st => st.ServiceTypeDurationCosts)
                    .ThenInclude(stdc => stdc.DurationCost)
                .ToListAsync();

            return _mapper.Map<List<ServiceTypeDto>>(serviceTypes);
        }

        public async Task<ServiceTypeDto?> GetServiceTypeBySlugAsync(string slug)
        {

            var serviceType = await _context.ServiceTypes
                .Include(st => st.ServiceTypeDurationCosts)
                    .ThenInclude(stdc => stdc.DurationCost)
                .Where(x => x.Slug == slug).FirstOrDefaultAsync();

            if (serviceType == null)
            {
                _logger.LogWarning("ServiceType with slug: {Slug} not found.", slug);
                return null;
            }

            return _mapper.Map<ServiceTypeDto>(serviceType);
        }

        public async Task CreateServiceTypeAsync(CreateServiceTypeDto createNewServiceTypeDto)
        {

            var existingServiceType = await _context.ServiceTypes
                .Include(st => st.ServiceTypeDurationCosts)
                .ThenInclude(stdc => stdc.DurationCost)
                .FirstOrDefaultAsync(st => EF.Functions.Like(st.Name, createNewServiceTypeDto.Name));

            if (existingServiceType != null && !existingServiceType.Active)
            {
                existingServiceType.Active = true;

                foreach (var stdc in existingServiceType.ServiceTypeDurationCosts)
                {
                    stdc.DateTo = DateTime.UtcNow.AddHours(1);
                }

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
                var newServiceType = _mapper.Map<ServiceType>(createNewServiceTypeDto);
                _context.ServiceTypes.Add(newServiceType);
            }

            await _context.SaveChangesAsync();
        }

        public async Task UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto)
        {

            var serviceType = await _context.ServiceTypes
                .Include(st => st.ServiceTypeDurationCosts)
                    .ThenInclude(stdc => stdc.DurationCost)
                .FirstOrDefaultAsync(st => st.Id == updateServiceTypeDto.Id);

            if (serviceType == null)
            {
                throw new Exception("ServiceType not found");
            }

            serviceType.Name = updateServiceTypeDto.Name;
            serviceType.Description = updateServiceTypeDto.Description;
            serviceType.HexColor = updateServiceTypeDto.HexColor;
            serviceType.IconName = updateServiceTypeDto.IconName;
            serviceType.ImageUrl = updateServiceTypeDto.ImageUrl;

            var currentDurationCosts = serviceType.ServiceTypeDurationCosts.ToList();
            foreach (var current in currentDurationCosts)
            {
                if (!updateServiceTypeDto.DurationCosts.Exists(dto => dto.DurationMinutes == current.DurationCost.DurationMinutes && dto.Cost == current.DurationCost.Cost))
                {
                    current.DateTo = DateTime.UtcNow.AddHours(1);
                }
            }

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

            await _context.SaveChangesAsync();
        }

        public async Task SoftDeleteServiceTypeAsync(int id)
        {

            _logger.LogInformation("Attempting to soft delete ServiceType with ID: {ServiceTypeId}", id);

            var serviceType = await _context.ServiceTypes.FindAsync(id);

            if (serviceType == null)
            {
                throw new Exception("ServiceType not found");
            }

            serviceType.Active = false;

            foreach (var stdc in serviceType.ServiceTypeDurationCosts)
            {
                stdc.DateTo = DateTime.Now;
            }

            _context.ServiceTypes.Update(serviceType);
            await _context.SaveChangesAsync();
        }
    }
}
