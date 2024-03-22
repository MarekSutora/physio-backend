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
    public class ClientMappingProfile : Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<ApplicationUser, ClientDto>()
            .ForMember(dto => dto.FirstName, conf => conf.MapFrom(user => user.Person.FirstName))
            .ForMember(dto => dto.LastName, conf => conf.MapFrom(user => user.Person.LastName));

            CreateMap<CreateClientNoteDto, ClientNote>().ForMember(pn => pn.ClientId, dto => dto.MapFrom(cpn => cpn.ClientId));
            CreateMap<ClientNote, ClientNoteDto>();
        }
    }
}
