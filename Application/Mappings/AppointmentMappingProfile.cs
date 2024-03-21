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
    internal class AppointmentMappingProfile : Profile
    {
        public AppointmentMappingProfile()
        {

            CreateMap<Appointment, AppointmentDto>()
                .ForMember(dest => dest.BookedAppointments, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCosts.SelectMany(astdc => astdc.BookedAppointments)))
                .ForMember(dest => dest.AppointmentDetail, opt => opt.MapFrom(src => src.AppointmentDetail));

            CreateMap<AppointmentDetail, AppointmentDetailDto>().ReverseMap();

            CreateMap<AppointmentExerciseDetail, AppointmentExerciseDetailDto>().ReverseMap();

            CreateMap<ExerciseTypeDto, ExerciseType>().ReverseMap();
        }
    }
}
