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
    public class BlogMappingProfile : Profile
    {
        public BlogMappingProfile()
        {
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
