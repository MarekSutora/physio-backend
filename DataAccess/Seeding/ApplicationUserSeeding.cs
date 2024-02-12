using DataAccess.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Seeding
{
    public static class ApplicationUserSeeding
    {
        public static void SeedApplicationUsers(this ModelBuilder builder)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            var adminRoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6";
            var patientRoleId = "C7D20194-9C7E-40DB-9C63-F71D20116529";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = patientRoleId, Name = "Patient", NormalizedName = "PATIENT" }
            );

            // Seed Admins
            ApplicationUser admin1 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 1
            };
            admin1.PasswordHash = passwordHasher.HashPassword(admin1, "Admin123!");

            ApplicationUser admin2 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin2@example.com",
                NormalizedUserName = "ADMIN2@EXAMPLE.COM",
                Email = "admin2@example.com",
                NormalizedEmail = "ADMIN2@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 2
            };
            admin2.PasswordHash = passwordHasher.HashPassword(admin2, "Admin123!");

            // Seed Patients
            ApplicationUser patient1 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "patient1@example.com",
                NormalizedUserName = "PATIENT1@EXAMPLE.COM",
                Email = "patient1@example.com",
                NormalizedEmail = "PATIENT1@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 3
            };
            patient1.PasswordHash = passwordHasher.HashPassword(patient1, "Patient123!");

            ApplicationUser patient2 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "patient2@example.com",
                NormalizedUserName = "PATIENT2@EXAMPLE.COM",
                Email = "patient2@example.com",
                NormalizedEmail = "PATIENT2@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 4
            };
            patient2.PasswordHash = passwordHasher.HashPassword(patient2, "Patient123!");

            ApplicationUser patient3 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "patient3@example.com",
                NormalizedUserName = "PATIENT3@EXAMPLE.COM",
                Email = "patient3@example.com",
                NormalizedEmail = "PATIENT3@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 5
            };
            patient3.PasswordHash = passwordHasher.HashPassword(patient3, "Patient123!");

            builder.Entity<ApplicationUser>().HasData(admin1, admin2, patient1, patient2, patient3);

            // Seed User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = admin1.Id },
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = admin2.Id },
                new IdentityUserRole<string> { RoleId = patientRoleId, UserId = patient1.Id },
                new IdentityUserRole<string> { RoleId = patientRoleId, UserId = patient2.Id },
                new IdentityUserRole<string> { RoleId = patientRoleId, UserId = patient3.Id }
            );


            // Seed Persons
            builder.Entity<Person>().HasData(
                new Person { Id = 1, FirstName = "Admin", LastName = "One" },
                new Person { Id = 2, FirstName = "Admin", LastName = "Two" },
                new Person { Id = 3, FirstName = "Patient", LastName = "One" },
                new Person { Id = 4, FirstName = "Patient", LastName = "Two" },
                new Person { Id = 5, FirstName = "Patient", LastName = "Three" }
            );

            // Include seeding for Patient entities corresponding to each Patient ApplicationUser
            Patient patient1Entity = new Patient { PersonId = 3 }; // Assuming PersonId 3 is for patient1
            Patient patient2Entity = new Patient { PersonId = 4 }; // Assuming PersonId 4 is for patient2
            Patient patient3Entity = new Patient { PersonId = 5 }; // Assuming PersonId 5 is for patient3

            builder.Entity<Patient>().HasData(patient1Entity, patient2Entity, patient3Entity);
        }
    }
}
