using DataAccess.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeding
{
    public static class ApplicationUserSeeding
    {
        public static void SeedApplicationUsers(this ModelBuilder builder)
        {
            // Create password hasher
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            // Seed Roles
            var adminRoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6";
            var physiotherapistRoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F";
            var patientRoleId = "C7D20194-9C7E-40DB-9C63-F71D20116529";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = physiotherapistRoleId, Name = "Physiotherapist", NormalizedName = "PHYSIOTHERAPIST" },
                new IdentityRole { Id = patientRoleId, Name = "Patient", NormalizedName = "PATIENT" }
            );

            // Seed Users
            ApplicationUser admin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 1 // Assuming this is the ID for the related Person
            };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Adpassword123!");

            ApplicationUser physiotherapist = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "physiotherapist@example.com",
                NormalizedUserName = "PHYSIOTHERAPIST@EXAMPLE.COM",
                Email = "physiotherapist@example.com",
                NormalizedEmail = "PHYSIOTHERAPIST@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 2 // Assuming this is the ID for the related Person
            };
            physiotherapist.PasswordHash = passwordHasher.HashPassword(physiotherapist, "Pypassword123!");

            ApplicationUser patient = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "patient@example.com",
                NormalizedUserName = "PATIENT@EXAMPLE.COM",
                Email = "patient@example.com",
                NormalizedEmail = "PATIENT@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 3 // Assuming this is the ID for the related Person
            };
            patient.PasswordHash = passwordHasher.HashPassword(patient, "Papassword123!");

            builder.Entity<ApplicationUser>().HasData(admin, physiotherapist, patient);

            // Seed User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = admin.Id },
                new IdentityUserRole<string> { RoleId = physiotherapistRoleId, UserId = admin.Id },
                new IdentityUserRole<string> { RoleId = physiotherapistRoleId, UserId = physiotherapist.Id },
                new IdentityUserRole<string> { RoleId = patientRoleId, UserId = patient.Id }
            );

            // Seed Persons
            builder.Entity<Person>().HasData(
                new Person { Id = 1, FirstName = "Admin", LastName = "User" },
                new Person { Id = 2, FirstName = "John", LastName = "Doe" },
                new Person { Id = 3, FirstName = "Jane", LastName = "Doe" }
            );
        }
    }
}
