﻿using Application.Common.Auth;
using Application.Common.Email;
using Application.Mappings;
using Application.Services.Implementation;
using Application.Services.Interfaces;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccess(configuration);

            services.AddIdentity<ApplicationUser, IdentityRole>(
                )
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAppointmentsService, AppointmentsService>();
            services.AddScoped<IServiceTypesService, ServiceTypesService>();
            services.AddScoped<IClientsService, ClientsService>();
            services.AddScoped<IBlogsService, BlogsService>();
            services.AddScoped<IExerciseTypesService, ExerciseTypesService>();
            services.AddScoped<IStatisticsService, StatisticsService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddHostedService<TimedHostedService>();


            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));


            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 7;
                options.SignIn.RequireConfirmedEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidIssuer = configuration["JwtSettings:Issuer"],
                        ValidAudience = configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]!))
                    };
                });

            services.AddAutoMapper(typeof(AppointmentMappingProfile));
            services.AddAutoMapper(typeof(BlogPostMappingProfile));
            services.AddAutoMapper(typeof(ClientMappingProfile));
            services.AddAutoMapper(typeof(ServiceTypeMappingProfile));
        }
    }
}
