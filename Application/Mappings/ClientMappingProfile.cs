using Application.DTO.Clients.Request;
using Application.DTO.Clients.Response;
using AutoMapper;
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

            CreateMap<CreateClientNoteDto, ClientNote>();
            CreateMap<ClientNote, ClientNoteDto>();
        }
    }
}
