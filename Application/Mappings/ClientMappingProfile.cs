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
