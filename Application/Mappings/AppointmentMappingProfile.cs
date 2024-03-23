using AutoMapper;
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
