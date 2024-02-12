using AutoMapper;
using DataAccess.Model.Entities;
using Shared.DTO.Patients.Response;
using Shared.DTO.Reservations.Request;
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;

namespace Application.Mappings
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<CreateServiceTypeDto, ServiceType>();

            CreateMap<DurationCostDto, DurationCost>();

            CreateMap<UpdateServiceTypeDto, ServiceType>();

            CreateMap<ServiceTypeDurationCost, ServiceTypeDurationCostDto>()
                .ForMember(dto => dto.Id, conf => conf.MapFrom(stdc => stdc.Id))
                .ForMember(dto => dto.DurationMinutes, conf => conf.MapFrom(stdc => stdc.DurationCost.DurationMinutes))
                .ForMember(dto => dto.Cost, conf => conf.MapFrom(stdc => stdc.DurationCost.Cost));

            CreateMap<ServiceType, ServiceTypeDto>()
                .ForMember(dto => dto.Stdcs, conf => conf.MapFrom(st => st.ServiceTypeDurationCosts
                    .Where(stdc => stdc.DateTo == null) // Optional: filter out inactive STDCs
                    .Select(stdc => new ServiceTypeDurationCostDto
                    {
                        Id = stdc.Id,
                        DurationMinutes = stdc.DurationCost.DurationMinutes,
                        Cost = stdc.DurationCost.Cost
                    })));

            CreateMap<BookedReservation, BookReservationDto>();

            CreateMap<Patient, PatientForBookedReservationDto>()
               .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
               .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Person.FirstName))
               .ForMember(dest => dest.SecondName, opt => opt.MapFrom(src => src.Person.LastName));
        }
    }
}
