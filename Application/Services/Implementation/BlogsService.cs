using Application.Services.Interfaces;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Application.DTO.Blog.Request;
using Application.DTO.Blog.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Application.Utilities;
using Application.Common;

namespace Application.Services.Implementation
{
    public class BlogsService : IBlogsService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BlogsService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BlogPostDto>> GetBlogPostsAsync()
        {
            var blogPosts = await _context.BlogPosts.ToListAsync();
            return _mapper.Map<IEnumerable<BlogPostDto>>(blogPosts);
        }

        public async Task<BlogPostDto?> GetBlogPostBySlugAsync(string slug)
        {
            var blogPost = await _context.BlogPosts.Where(x => x.Slug == slug).FirstOrDefaultAsync();
            if (blogPost == null) throw new Exception($"Blog post with title {slug} not found");

            return _mapper.Map<BlogPostDto>(blogPost);
        }

        public async Task<IEnumerable<BlogPostDto>> GetNonHiddenBlogPostsAsync()
        {
            var blogPosts = await _context.BlogPosts.Where(x => x.IsHidden == false).OrderByDescending(bp => bp.DatePublished).ToListAsync();
            return _mapper.Map<IEnumerable<BlogPostDto>>(blogPosts);
        }

        public async Task CreateBlogPostAsync(CreateBlogPostDto createBlogPostDto)
        {
            var blogPostsAlreadyExist = await _context.BlogPosts.AnyAsync(bp => bp.Title == createBlogPostDto.Title);
            if (blogPostsAlreadyExist) throw new AlreadyExistsException("Blog post with this title already exists");

            var blogPost = _mapper.Map<BlogPost>(createBlogPostDto);
            _context.BlogPosts.Add(blogPost);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBlogPostAsync(UpdateBlogPostDto updateBlogPostDto)
        {
            var blogPost = await _context.BlogPosts.FirstOrDefaultAsync(bp => bp.Slug == updateBlogPostDto.Slug);

            if (blogPost == null) throw new Exception("Blog post not found");

            if (blogPost.Title != updateBlogPostDto.Title)
            {
                var blogPostsAlreadyExist = await _context.BlogPosts.AnyAsync(bp => bp.Title == updateBlogPostDto.Title);
                if (blogPostsAlreadyExist) throw new AlreadyExistsException("Blog post with this title already exists");
            }

            _mapper.Map(updateBlogPostDto, blogPost);
            await _context.SaveChangesAsync();
        }

        public async Task IncrementBlogPostViewCountAsync(string slug)
        {
            var blogPost = await _context.BlogPosts.FirstOrDefaultAsync(bp => bp.Slug == slug);
            if (blogPost == null) throw new Exception($"Blog post with slug {slug} not found");

            blogPost.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBlogPostAsync(string slug)
        {
            var blogPost = await _context.BlogPosts.FirstOrDefaultAsync(bp => bp.Slug == slug);
            if (blogPost == null) throw new Exception("Blog post not found");

            _context.BlogPosts.Remove(blogPost);
            await _context.SaveChangesAsync();
        }
    }
}
