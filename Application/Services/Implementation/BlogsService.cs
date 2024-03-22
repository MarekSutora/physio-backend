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

namespace Application.Services.Implementation
{
    public class BlogsService : IBlogsService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BlogsService> _logger;
        private readonly IMapper _mapper;

        public BlogsService(ApplicationDbContext context, ILogger<BlogsService> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task CreateBlogPostAsync(CreateBlogPostDto createBlogPostDto)
        {
            var blogPost = _mapper.Map<BlogPost>(createBlogPostDto);
            _context.BlogPosts.Add(blogPost);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Blog post created with ID: {blogPost.Id}");
        }

        public async Task DeleteBlogPostAsync(int id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(id);
            if (blogPost == null) throw new KeyNotFoundException("Blog post not found");

            _context.BlogPosts.Remove(blogPost);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Blog post deleted with ID: {blogPost.Id}");
        }

        public async Task<BlogPostDto> GetBlogPostByIdAsync(int id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(id);
            if (blogPost == null) throw new KeyNotFoundException($"Blog post with ID {id} not found");

            return _mapper.Map<BlogPostDto>(blogPost);
        }

        public async Task<BlogPostDto> GetBlogPostBySlugAsync(string slug)
        {
            var blogPost = await _context.BlogPosts.Where(x => x.Slug == slug).FirstOrDefaultAsync();
            if (blogPost == null) throw new KeyNotFoundException($"Blog post with title {slug} not found");

            return _mapper.Map<BlogPostDto>(blogPost);
        }

        public async Task<IEnumerable<BlogPostDto>> GetBlogPostsAsync()
        {

            var blogPosts = await _context.BlogPosts.ToListAsync();
            return _mapper.Map<IEnumerable<BlogPostDto>>(blogPosts);

        }

        public async Task<IEnumerable<BlogPostDto>> GetNonHiddenBlogPostsAsync()
        {
            var blogPosts = await _context.BlogPosts.Where(x => x.IsHidden == false).ToListAsync();
            return _mapper.Map<IEnumerable<BlogPostDto>>(blogPosts);
        }

        public async Task HideBlogPostAsync(int id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(id);
            if (blogPost == null) throw new KeyNotFoundException("Blog post not found");

            blogPost.IsHidden = true;
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Blog post hidden with ID: {blogPost.Id}");
        }

        public async Task UpdateBlogPostAsync(UpdateBlogPostDto updateBlogPostDto)
        {

            var blogPost = await _context.BlogPosts.FindAsync(updateBlogPostDto.Id);
            if (blogPost == null) throw new KeyNotFoundException("Blog post not found");

            _mapper.Map(updateBlogPostDto, blogPost);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Blog post updated with ID: {blogPost.Id}");
        }


        public async Task IncrementBlogPostViewCountAsync(string slug)
        {
            var blogPost = await _context.BlogPosts.FirstOrDefaultAsync(bp => bp.Slug == slug);
            if (blogPost == null) throw new KeyNotFoundException($"Blog post with slug {slug} not found");

            blogPost.ViewCount += 1;
            await _context.SaveChangesAsync();
        }
    }
}
