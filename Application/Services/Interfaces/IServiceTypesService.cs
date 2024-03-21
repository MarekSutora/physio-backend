
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;

namespace Application.Services.Interfaces
{
    public interface IServiceTypesService
    {
        Task<bool> CreateServiceTypeAsync(CreateServiceTypeDto createNewServiceTypeDto);
        Task<bool> SoftDeleteServiceTypeAsync(int id);
        Task<List<ServiceTypeDto>> GetAllActiveServiceTypesAsync();
        Task<bool> UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto);
        Task<ServiceTypeDto> GetServiceTypeBySlugAsync(string slug);
    }
}
