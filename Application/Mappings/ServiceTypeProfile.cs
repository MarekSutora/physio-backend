using AutoMapper;
using DataAccess.Model.Entities;
using Shared.DTO.ServiceType;
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;

namespace Application.Mappings
{
    public class ServiceTypeProfile : Profile
    {
        public ServiceTypeProfile()
        {
            CreateMap<CreateNewServiceTypeDto, ServiceType>();

            CreateMap<DurationCostDto, DurationCost>().ReverseMap();

            CreateMap<UpdateServiceTypeDto, ServiceType>();

            CreateMap<ServiceType, ServiceTypeDto>();
        }
    }
}
