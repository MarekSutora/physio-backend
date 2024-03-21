
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;

namespace Application.Services.Interfaces
{
    public interface IServiceTypesService
    {
        Task CreateServiceTypeAsync(CreateServiceTypeDto createNewServiceTypeDto);
        Task SoftDeleteServiceTypeAsync(int id);
        Task<List<ServiceTypeDto>> GetAllActiveServiceTypesAsync();
        Task UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto);
        Task<ServiceTypeDto> GetServiceTypeBySlugAsync(string slug);
    }
}
