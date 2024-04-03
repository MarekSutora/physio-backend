﻿using AutoMapper;
using Application.DTO.Blog.Request;
using Application.DTO.Blog.Response;
using DataAccess.Entities;
using Application.Common;

namespace Application.Mappings
{
    public class BlogPostMappingProfile : Profile
    {
        public BlogPostMappingProfile()
        {
            CreateMap<CreateBlogPostDto, BlogPost>().ForMember(dest => dest.Slug, opt => opt.MapFrom(src => MappingUtilities.GenerateSlug(src.Title)));

            CreateMap<BlogPost, BlogPostDto>().ReverseMap();

            CreateMap<UpdateBlogPostDto, BlogPost>().ForMember(dest => dest.Slug, opt => opt.MapFrom(src => MappingUtilities.GenerateSlug(src.Title)));
        }
    }
}
