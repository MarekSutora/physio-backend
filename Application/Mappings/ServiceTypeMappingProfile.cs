using AutoMapper;
using Shared.DTO.Clients.Response;
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;
using Shared.DTO.Blog.Request;
using Shared.DTO.Blog.Response;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;
using Shared.DTO.Appointments.Response;
using Shared.DTO.Clients.Request;
using DataAccess.Entities;

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

            CreateMap<CreateServiceTypeDto, ServiceType>().ForMember(dest => dest.Slug, opt => opt.MapFrom(src => GenerateSlug(src.Name)));
        }

        private string GenerateSlug(string title)
        {
            // Normalize string, removing diacritics
            string normalizedString = title.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            // Lowercase and remove invalid chars
            string slug = stringBuilder.ToString().Normalize(NormalizationForm.FormC).ToLower();
            slug = Regex.Replace(slug, @"[^a-z0-9\s-]", ""); // Remove all non valid chars          
            slug = Regex.Replace(slug, @"\s+", " ").Trim(); // Convert multiple spaces into one space   
            slug = Regex.Replace(slug, @"\s", "-"); // Replace spaces with hyphens

            return slug;
        }
    }
}

