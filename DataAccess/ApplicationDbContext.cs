using DataAccess.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ActivityType> ActivityType { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogKeyword> BlogKeyword { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Person> Person { get; set; }

        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var adminRoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6";
            var physiotherapistRoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F";
            var patientRoleId = "C7D20194-9C7E-40DB-9C63-F71D20116529";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = physiotherapistRoleId, Name = "Employee", NormalizedName = "PHYSIOTHERAPIST" },
                new IdentityRole { Id = patientRoleId, Name = "Patient", NormalizedName = "PATIENT" }
                );

            ApplicationUser admin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Adpassword123!"),
                SecurityStamp = new Guid().ToString("D")
            };

            ApplicationUser physiotherapist = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "physiotherapist@example.com",
                NormalizedUserName = "PHYSIOTHERAPIST@PHYSIOTHERAPIST.COM",
                Email = "physiotherapist@example.com",
                NormalizedEmail = "PHYSIOTHERAPIST@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Pypassword123!"),
                SecurityStamp = new Guid().ToString("D")
            };

            ApplicationUser patient = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "patient@example.com",
                NormalizedUserName = "PATIENT@PATIENT.COM",
                Email = "patient@example.com",
                NormalizedEmail = "patient@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Papassword123!"),
                SecurityStamp = new Guid().ToString("D")
            };

            builder.Entity<ApplicationUser>().HasData(admin);
            builder.Entity<ApplicationUser>().HasData(physiotherapist);
            builder.Entity<ApplicationUser>().HasData(patient);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId, // Use the actual admin role ID from the seeded roles
                UserId = admin.Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = physiotherapistRoleId, // Use the actual admin role ID from the seeded roles
                UserId = physiotherapist.Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = patientRoleId, // Use the actual admin role ID from the seeded roles
                UserId = patient.Id
            });
        }
    }
}
