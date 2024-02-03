using AutoMapper;
using DataAccess.Model.Entities;
using Shared.DTO.ServiceType;

namespace Application.Mappings
{
    public class ServiceTypeProfile : Profile
    {
        public ServiceTypeProfile()
        {
            CreateMap<CreateNewServiceTypeDto, ServiceType>()
                .ForMember(dest => dest.ServiceTypeDurationCosts, opt => opt.MapFrom(src => src.ServiceTypeDurationCosts));

            CreateMap<UpdateServiceTypeDto, ServiceType>()
                .ForMember(dest => dest.ServiceTypeDurationCosts, opt => opt.MapFrom(src => src.ServiceTypeDurationCosts));

            CreateMap<ServiceTypeDurationCostDto, ServiceTypeDurationCost>();
        }
    }
}


