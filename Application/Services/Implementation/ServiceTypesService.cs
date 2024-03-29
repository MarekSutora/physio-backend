using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Application.DTO.ServiceType.Request;
using Application.DTO.ServiceType.Response;
using Application.Utilities;


namespace Application.Services.Implementation
{
    public class ServiceTypesService : IServiceTypesService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ServiceTypesService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

            if (existingServiceType != null && existingServiceType.Active)
            {
                throw new AlreadyExistsException($"Service type with the name {createNewServiceTypeDto.Name} already exists.");
            }
            else if (existingServiceType != null && !existingServiceType.Active)
            {
                existingServiceType.Active = true;

                foreach (var stdc in existingServiceType.ServiceTypeDurationCosts)
                {
                    stdc.DateTo = DateTime.UtcNow.AddHours(1);
                }
            }
            else
            {
                existingServiceType = _mapper.Map<ServiceType>(createNewServiceTypeDto);
                _context.ServiceTypes.Add(existingServiceType);
            }

            foreach (var durationCostDto in createNewServiceTypeDto.DurationCosts)
            {
                var durationCost = await _context.DurationCosts
                    .FirstOrDefaultAsync(dc => dc.DurationMinutes == durationCostDto.DurationMinutes && dc.Cost == durationCostDto.Cost);

                if (durationCost == null)
                {
                    durationCost = new DurationCost
                    {
                        DurationMinutes = durationCostDto.DurationMinutes,
                        Cost = durationCostDto.Cost
                    };
                    _context.DurationCosts.Add(durationCost);
                }

                existingServiceType.ServiceTypeDurationCosts.Add(new ServiceTypeDurationCost
                {
                    DurationCost = durationCost
                });
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

                if (!serviceType.ServiceTypeDurationCosts.Any(stdc => stdc.DurationCostId == existingDurationCost.Id && stdc.DateTo == null))
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

            var serviceType = await _context.ServiceTypes.FindAsync(id);

            if (serviceType == null)
            {
                throw new Exception("ServiceType not found");
            }

            DateTime currentDateTime = DateTime.UtcNow.AddHours(1);

            serviceType.Active = false;

            foreach (var stdc in serviceType.ServiceTypeDurationCosts)
            {
                stdc.DateTo = currentDateTime;
            }

            _context.ServiceTypes.Update(serviceType);
            await _context.SaveChangesAsync();
        }
    }
}
