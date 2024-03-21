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

            CreateMap<BookedAppointment, BookedAppointmentDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.AppointmentId))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.Appointment.StartTime)) // Assuming the start time of the booked appointment is the same as the appointment start time
                .ForMember(dest => dest.DurationMinutes, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.DurationMinutes)) // Adjust this based on your actual entity structure
                .ForMember(dest => dest.ServiceTypeName, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name))
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.ClientId))
                .ForMember(dest => dest.ClientFirstName, opt => opt.MapFrom(src => src.Client == null ? "-" : src.Client.Person.FirstName)) // Assuming your Client entity has a FirstName property
                .ForMember(dest => dest.ClientSecondName, opt => opt.MapFrom(src => src.Client == null ? "-" : src.Client.Person.LastName)) // Adjust according to your Client entity
                .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost))
                .ForMember(dest => dest.HexColor, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor))
                .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.AppointmentServiceTypeDurationCost.Appointment.Capacity))
                .ForMember(dest => dest.AppointmentBookedDate, opt => opt.MapFrom(src => src.AppointmentBookedDate));
        }
    }
}
