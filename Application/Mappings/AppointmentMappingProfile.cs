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
                .ForMember(dest => dest.BookedAppointments, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCosts.SelectMany(astdc => astdc.BookedAppointments)));

            CreateMap<AppointmentDetail, AppointmentDetailDto>().ReverseMap();

            //CreateMap<AppointmentExerciseDetail, AppointmentExerciseDetailDto>().ReverseMap();

            CreateMap<ExerciseTypeDto, ExerciseType>().ReverseMap();

            CreateMap<BookedAppointment, BookedAppointmentDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.AppointmentId))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.Appointment.StartTime))
                .ForMember(dest => dest.DurationMinutes, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes))
                .ForMember(dest => dest.ServiceTypeName, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name))
                .ForMember(dest => dest.ClientFirstName, opt => opt.MapFrom(src => src.Person.FirstName))
                .ForMember(dest => dest.ClientSecondName, opt => opt.MapFrom(src => src.Person.LastName))
                .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost))
                .ForMember(dest => dest.HexColor, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor))
                .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.Appointment.Capacity))
                .ForMember(dest => dest.AppointmentBookedDate, opt => opt.MapFrom(src => src.AppointmentBookedDate));
        }
    }
}
