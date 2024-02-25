using AutoMapper;
using DataAccess.Model.Entities;
using Shared.DTO.Patients.Response;
using Shared.DTO.Appointments.Request;
using Shared.DTO.ServiceType.Request;
using Shared.DTO.ServiceType.Response;
using Shared.DTO.Blog.Request;
using Shared.DTO.Blog.Response;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

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

            CreateMap<Patient, PatientForBookedAppointmentDto>()
               .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
               .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Person.FirstName))
               .ForMember(dest => dest.SecondName, opt => opt.MapFrom(src => src.Person.LastName));

            CreateMap<CreateBlogPostDto, BlogPost>().ForMember(dest => dest.Slug, opt => opt.MapFrom(src => GenerateSlug(src.Title)));

            CreateMap<BlogPost, BlogPostDto>();

            CreateMap<UpdateBlogPostDto, BlogPost>();
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
