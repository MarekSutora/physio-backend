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
            CreateMap<CreateBlogPostDto, BlogPost>().ForMember(dest => dest.Slug, opt => opt.MapFrom(src => GenerateSlug(src.Title)));

            CreateMap<BlogPost, BlogPostDto>();

            CreateMap<UpdateBlogPostDto, BlogPost>();
        }
    }
}
