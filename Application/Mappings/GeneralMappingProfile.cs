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
using Shared.DTO.Appointments.Response;

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

            CreateMap<CreateBlogPostDto, BlogPost>().ForMember(dest => dest.Slug, opt => opt.MapFrom(src => GenerateSlug(src.Title)));

            CreateMap<BlogPost, BlogPostDto>();

            CreateMap<UpdateBlogPostDto, BlogPost>();


            // Mapping from Appointment entity to AppointmentDto
            CreateMap<Appointment, AppointmentDto>()
                .ForMember(dest => dest.BookedAppointments, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCosts.SelectMany(astdc => astdc.BookedAppointments)))
                .ForMember(dest => dest.AppointmentDetail, opt => opt.MapFrom(src => src.AppointmentDetail));

            // Mapping from AppointmentDetail entity to AppointmentDetailDto
            CreateMap<AppointmentDetail, AppointmentDetailDto>().ReverseMap();

            // Mapping from AppointmentExerciseDetail entity to AppointmentExerciseDetailDto
            CreateMap<AppointmentExerciseDetail, AppointmentExerciseDetailDto>().ReverseMap();

            CreateMap<ExerciseTypeDto, ExerciseType>().ReverseMap();

            // Mapping from BookedAppointment entity to BookedAppointmentDto
            CreateMap<BookedAppointment, BookedAppointmentDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.AppointmentId))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.Appointment.StartTime)) // Assuming the start time of the booked appointment is the same as the appointment start time
                .ForMember(dest => dest.DurationMinutes, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes)) // Adjust this based on your actual entity structure
                .ForMember(dest => dest.ServiceTypeName, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name))
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.PatientId))
                .ForMember(dest => dest.ClientFirstName, opt => opt.MapFrom(src => src.Patient == null ? "-" : src.Patient.Person.FirstName)) // Assuming your Patient entity has a FirstName property
                .ForMember(dest => dest.ClientSecondName, opt => opt.MapFrom(src => src.Patient == null ? "-" : src.Patient.Person.LastName)) // Adjust according to your Patient entity
                .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost))
                .ForMember(dest => dest.HexColor, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor))
                .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.Appointment.Capacity))
                .ForMember(dest => dest.AppointmentBookedDate, opt => opt.MapFrom(src => src.AppointmentBookedDate));

            CreateMap<ApplicationUser, PatientDto>()
            .ForMember(dto => dto.FirstName, conf => conf.MapFrom(user => user.Person.FirstName))
            .ForMember(dto => dto.LastName, conf => conf.MapFrom(user => user.Person.LastName));
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
