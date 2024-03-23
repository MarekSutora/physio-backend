﻿using AutoMapper;
using Application.DTO.Clients.Response;
using Application.DTO.ServiceType.Request;
using Application.DTO.ServiceType.Response;
using Application.DTO.Blog.Request;
using Application.DTO.Blog.Response;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;
using Application.DTO.Appointments.Response;
using Application.DTO.Clients.Request;
using DataAccess.Entities;
using Application.Common;

namespace Application.Mappings
{
    public class ServiceTypeMappingProfile : Profile
    {
        public ServiceTypeMappingProfile()
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
                    .Where(stdc => stdc.DateTo == null)
                    .Select(stdc => new ServiceTypeDurationCostDto
                    {
                        Id = stdc.Id,
                        DurationMinutes = stdc.DurationCost.DurationMinutes,
                        Cost = stdc.DurationCost.Cost
                    })));

            CreateMap<CreateServiceTypeDto, ServiceType>().ForMember(dest => dest.Slug, opt => opt.MapFrom(src => MappingUtilities.GenerateSlug(src.Name)));
        }
    }
}
