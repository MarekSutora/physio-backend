
using Application.DTO.ServiceType.Request;
using Application.DTO.ServiceType.Response;

namespace Application.Services.Interfaces
{
    public interface IServiceTypesService
    {
        Task CreateServiceTypeAsync(CreateServiceTypeDto createNewServiceTypeDto);
        Task SoftDeleteServiceTypeAsync(int id);
        Task<List<ServiceTypeDto>> GetActiveServiceTypesAsync();
        Task UpdateServiceTypeAsync(UpdateServiceTypeDto updateServiceTypeDto);
        Task<ServiceTypeDto?> GetServiceTypeBySlugAsync(string slug);
    }
}
