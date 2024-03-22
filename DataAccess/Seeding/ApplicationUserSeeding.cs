using DataAccess.Entities;
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
            var clientRoleId = "C7D20194-9C7E-40DB-9C63-F71D20116529";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = clientRoleId, Name = "Client", NormalizedName = "CLIENT" }
            );

            // Seed Admins
            ApplicationUser admin1 = new ApplicationUser
            {
                Id = "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                UserName = "admin1@example.com",
                NormalizedUserName = "ADMIN1@EXAMPLE.COM",
                Email = "admin1@example.com",
                NormalizedEmail = "ADMIN1@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 1
            };
            admin1.PasswordHash = passwordHasher.HashPassword(admin1, "asdAdmin123!@");

            ApplicationUser admin2 = new ApplicationUser
            {
                Id = "faa2cd95-a59c-4127-8f54-916deb38b612",
                UserName = "admin2@example.com",
                NormalizedUserName = "ADMIN2@EXAMPLE.COM",
                Email = "admin2@example.com",
                NormalizedEmail = "ADMIN2@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 2
            };
            admin2.PasswordHash = passwordHasher.HashPassword(admin2, "asdAdmin123!@");

            // Seed Clients
            ApplicationUser client1 = new ApplicationUser
            {
                Id = "ea4cbaeb-0869-493c-b80c-372a32b05539",
                UserName = "client1@example.com",
                NormalizedUserName = "client1@EXAMPLE.COM",
                Email = "client1@example.com",
                NormalizedEmail = "CLIENT1@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 3
            };
            client1.PasswordHash = passwordHasher.HashPassword(client1, "asdClient123!@");

            ApplicationUser client2 = new ApplicationUser
            {
                Id = "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                UserName = "client2@example.com",
                NormalizedUserName = "CLIENT12@EXAMPLE.COM",
                Email = "client2@example.com",
                NormalizedEmail = "CLIENT12@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 4
            };
            client2.PasswordHash = passwordHasher.HashPassword(client2, "asdClient123!@");

            ApplicationUser client3 = new ApplicationUser
            {
                Id = "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                UserName = "client3@example.com",
                NormalizedUserName = "CLIENT3@EXAMPLE.COM",
                Email = "client3@example.com",
                NormalizedEmail = "CLIENT3@EXAMPLE.COM",
                EmailConfirmed = true,
                PersonId = 5
            };
            client3.PasswordHash = passwordHasher.HashPassword(client3, "asdClient123!@");

            builder.Entity<ApplicationUser>().HasData(admin1, admin2, client1, client2, client3);

            // Seed User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = admin1.Id },
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = admin2.Id },
                new IdentityUserRole<string> { RoleId = clientRoleId, UserId = client1.Id },
                new IdentityUserRole<string> { RoleId = clientRoleId, UserId = client2.Id },
                new IdentityUserRole<string> { RoleId = clientRoleId, UserId = client3.Id }
            );


            // Seed Persons
            builder.Entity<Person>().HasData(
                new Person { Id = 1, FirstName = "Admin", LastName = "One", PhoneNumber = "1234567890" },
                new Person { Id = 2, FirstName = "Admin", LastName = "Two", PhoneNumber = "1234567890" },
                new Person { Id = 3, FirstName = "Client", LastName = "One", PhoneNumber = "1234567890" },
                new Person { Id = 4, FirstName = "Client", LastName = "Two", PhoneNumber = "1234567890" },
                new Person { Id = 5, FirstName = "Client", LastName = "Three", PhoneNumber = "1234567890" }
            );

            Client client1Entity = new Client { PersonId = 3 };
            Client client2Entity = new Client { PersonId = 4 };
            Client client3Entity = new Client { PersonId = 5 };

            builder.Entity<Client>().HasData(client1Entity, client2Entity, client3Entity);
        }
    }
}
