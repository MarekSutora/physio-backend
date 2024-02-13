using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class appointmentTablesChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Appointments_AppointmentId",
                table: "BookedAppointments");

            migrationBuilder.DropIndex(
                name: "IX_BookedAppointments_AppointmentId",
                table: "BookedAppointments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "0bcd48d1-658a-4118-8828-c18a8f950b5a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6bd76916-4e69-4cb0-ad72-8ae63efb943f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "8fdc4230-4d48-4139-89aa-16dd57b4ae94" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bcd48d1-658a-4118-8828-c18a8f950b5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd76916-4e69-4cb0-ad72-8ae63efb943f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fdc4230-4d48-4139-89aa-16dd57b4ae94");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "BookedAppointments");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4d7c32fb-ce0c-41a4-9989-25b508a69c8c", 0, "76843fe4-70b5-49f0-8cb3-f9a867b6308c", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECAQ0Axt7jDX230Ux+bL789zYTeNj2arCA4ujt2eSP8+NPqRHi3lz67tqrO5MZSNkg==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e1880171-be22-4e1c-bd3e-b45973980c94", false, "admin@example.com" },
                    { "5e1acbf9-e736-4cb6-bd5b-05772323aaf1", 0, "5f3d4e5a-2780-4988-8ce7-896b826f14ba", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIWrmix9tlauKb2tr9nwotHpe/6xAaI4kVy9IIwJk7B8Ndn3BTkldkm+XSxV8/Gx+A==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a79386af-0c4c-4efd-8a49-a61e018c650a", false, "patient1@example.com" },
                    { "628e758a-b0a9-46c1-b992-d0fa3751dca9", 0, "4105be3b-f6fc-47de-b24e-017039c30022", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE/27qqllUXc+NFiRaZk6hFbNtGyqCDsTUuJC/R+6RPTMEMGGaypDb+2HudID3zEgA==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b1e4eb0b-1d9f-4e03-a827-4234801ecde4", false, "patient3@example.com" },
                    { "821800be-3412-4740-98ef-f3c0b645dfab", 0, "78088490-f8de-4320-aeff-a0f5dd218f19", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN4ur7moAuGDcT6CMLH9Q4RPivBilCmnt3OXNj+bVsyBTjL6bZC16XHrhIockxPiXA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "49de7cd4-c906-44e6-9c11-b6eab88bc67b", false, "patient2@example.com" },
                    { "ff625c7f-3a95-4252-95be-6f2ebf2ca24c", 0, "31a618c1-f147-4b1b-b2bd-be9c7875ced0", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEHsxRcUZYQNYD3xPbCX6WF8Jg/XqdHA1N7z9Z+K2eMjHyJqd9pmlw6315+VFP148A==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "94e2a397-4f32-4e35-952f-8f415eab729c", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "4d7c32fb-ce0c-41a4-9989-25b508a69c8c" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5e1acbf9-e736-4cb6-bd5b-05772323aaf1" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "628e758a-b0a9-46c1-b992-d0fa3751dca9" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "821800be-3412-4740-98ef-f3c0b645dfab" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "ff625c7f-3a95-4252-95be-6f2ebf2ca24c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "4d7c32fb-ce0c-41a4-9989-25b508a69c8c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5e1acbf9-e736-4cb6-bd5b-05772323aaf1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "628e758a-b0a9-46c1-b992-d0fa3751dca9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "821800be-3412-4740-98ef-f3c0b645dfab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "ff625c7f-3a95-4252-95be-6f2ebf2ca24c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d7c32fb-ce0c-41a4-9989-25b508a69c8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e1acbf9-e736-4cb6-bd5b-05772323aaf1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "628e758a-b0a9-46c1-b992-d0fa3751dca9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "821800be-3412-4740-98ef-f3c0b645dfab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff625c7f-3a95-4252-95be-6f2ebf2ca24c");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "BookedAppointments",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0bcd48d1-658a-4118-8828-c18a8f950b5a", 0, "16e2abfe-db5c-486d-8c0b-61baaff7de4b", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAECRKj7LambNdXWE0bQ6A+IrekpsijrroJEDuhdWW3Roj9DuvxA3HrFLg3RaftMqouA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2158fd0c-41df-448a-bfb0-c9f5bfb08453", false, "patient2@example.com" },
                    { "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864", 0, "0b50cb69-567a-4784-a6cc-79ad2a01d845", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIPsCo2yK9vcH3eaJ0k3EXE1FqmXFqbDbaL2aRRpdCnuwLo4yGqUNGA8Oe1VppR6+A==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "171e4add-68c1-4ba2-a1b9-2fb82f921b93", false, "admin@example.com" },
                    { "6bd76916-4e69-4cb0-ad72-8ae63efb943f", 0, "b87acd44-4798-4e27-a77b-1d24d8c5de9f", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB1UFc0N+dyHojppskL4tKvZEPgllSGB1FdiISWXVePBHC8izgIBXU/fBT6jhnFeGA==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5191e3c2-212e-41ae-af82-574eb4cb63fd", false, "patient1@example.com" },
                    { "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7", 0, "a63cc2ae-62c4-4048-bdab-6e81445602d9", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAECjxJ/WqHWYe34jAJwnREwFDZJz39A5K/dZ480gHG0JwDra7bbvP5cV14g0FTzv1iQ==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2ac3d873-b915-4d8e-94a8-d7ae7c30cf26", false, "patient3@example.com" },
                    { "8fdc4230-4d48-4139-89aa-16dd57b4ae94", 0, "277811e4-c776-414a-bbbc-f7919b38507b", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMWXpp2a+ifc6R9sct/jg3sPjKZVjjV0c5p6yjKqLxq2uUQyQsZGjIxOdiuYwAtgHA==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dbe558fd-904d-40ae-99af-a8f9c894973c", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "0bcd48d1-658a-4118-8828-c18a8f950b5a" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6bd76916-4e69-4cb0-ad72-8ae63efb943f" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "8fdc4230-4d48-4139-89aa-16dd57b4ae94" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_AppointmentId",
                table: "BookedAppointments",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Appointments_AppointmentId",
                table: "BookedAppointments",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id");
        }
    }
}
