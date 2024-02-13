using DataAccess.Model.Entities;
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
using AutoMapper;
using Application.Mappings;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAppointmentsService, AppointmentsService>();
            services.AddScoped<IServiceTypeService, ServiceTypeService>();
            services.AddScoped<IPatientsService, PatientsService>();

            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            //add authorization policies for admin and physiotherapist and patient

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false; //TODO: change to true
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
                options.AddPolicy("Physiotherapist", policy =>
                                   policy.RequireRole("Physiotherapist"));
                options.AddPolicy("Patient", policy => policy.RequireRole("Patient"));
            }
            );


            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    //o.RequireHttpsMetadata = false;
                    //o.SaveToken = false;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        //ValidateLifetime = true,
                        //ClockSkew = TimeSpan.Zero,
                        ValidIssuer = configuration["JwtSettings:Issuer"],
                        ValidAudience = configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]!))
                    };
                });

            services.AddAutoMapper(typeof(GeneralMappingProfile));
        }
    }
}
