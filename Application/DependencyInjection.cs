using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Application.Common.Auth;
using Application.Services.Implementation;
using DataAccess;
using Application.Mappings;
using Application.Common.Email;
using DataAccess.Entities;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccess(configuration);

            services.AddIdentity<ApplicationUser, IdentityRole>(
                    options =>
                    {
                        options.Lockout.MaxFailedAccessAttempts = 5;
                        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
                    }
                )
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAppointmentsService, AppointmentsService>();
            services.AddScoped<IServiceTypesService, ServiceTypeService>();
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
                options.Password.RequiredUniqueChars = 1;
                options.SignIn.RequireConfirmedEmail = true;
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
                options.AddPolicy("Client", policy => policy.RequireRole("Client"));
            }
            );

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
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
            services.AddAutoMapper(typeof(BlogMappingProfile));
            services.AddAutoMapper(typeof(ClientMappingProfile));
            services.AddAutoMapper(typeof(ServiceTypeMappingProfile));
        }
    }
}
