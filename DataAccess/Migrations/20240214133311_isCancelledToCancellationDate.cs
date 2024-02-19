using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class isCancelledToCancellationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "BookedAppointments");

            migrationBuilder.RenameColumn(
                name: "AppointmentFinishedDate",
                table: "BookedAppointments",
                newName: "CancellationDate");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "132fb38f-7690-4521-a3ac-64e2bd0f680e", 0, "b2619a63-5ea3-4633-a537-30645a7eddfd", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDHR8SYC54Lka4k2lKb63RlRuwvgVl/HaY+/qYi+FsFknZgBLW4YwwF8V0ewYIqmfw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "20ca0dd8-e880-4d7b-aac7-eae2b3f7f84b", false, "admin2@example.com" },
                    { "5ad31b21-38f6-4159-b20f-544d45803ea8", 0, "e36d0632-20db-41dd-8a08-033a38946d60", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIfriJGyFcF/0/B+pPRzbMN9n5r8KAkVr+tYkVhnLu9eHkjgWTC/6ISSjM/5nUPE7w==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ced15cc-88cf-411b-97a4-f8cf9fe1e257", false, "patient2@example.com" },
                    { "b597c871-0dd5-45f0-8683-67a66920271a", 0, "697dcaf0-8560-4d25-a0ed-d88a1108d751", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM0WqaFY5F9N8E6s+wERRr6ZPMBobrwBIbXs7T0yCAIJUKASqtjoANQyDnjoSfHmsg==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1cdfc52d-10be-4149-88c0-cea82434f624", false, "admin@example.com" },
                    { "c74ccb80-ad1e-4373-a2ef-b05f428665b9", 0, "d7f65e75-5110-4ba3-8d2b-356413d95178", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDRQWpoSyV53Iy0ev96Fx8XHV2O791Em/8wT9UrxP/5DA/OrS7u9oVn2aBclal2w7Q==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bc36c7fb-70d2-4c6c-9691-21694c15b9a3", false, "patient1@example.com" },
                    { "e934755e-634a-466e-ba7a-fea0c6f9ed16", 0, "b1156dd4-f6f5-4d21-a36d-dfe8bf50829b", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOnFD5XTEx9bERbQ3Fl08HNZs/qjsZv+BfVie9NlTs0RAmRJJHyoeZwUDXR3s3xq+Q==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2473f8c4-192e-4ed4-8104-b3d7eebcf065", false, "patient3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "132fb38f-7690-4521-a3ac-64e2bd0f680e" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5ad31b21-38f6-4159-b20f-544d45803ea8" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "b597c871-0dd5-45f0-8683-67a66920271a" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c74ccb80-ad1e-4373-a2ef-b05f428665b9" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "e934755e-634a-466e-ba7a-fea0c6f9ed16" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "132fb38f-7690-4521-a3ac-64e2bd0f680e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5ad31b21-38f6-4159-b20f-544d45803ea8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "b597c871-0dd5-45f0-8683-67a66920271a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c74ccb80-ad1e-4373-a2ef-b05f428665b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "e934755e-634a-466e-ba7a-fea0c6f9ed16" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132fb38f-7690-4521-a3ac-64e2bd0f680e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ad31b21-38f6-4159-b20f-544d45803ea8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b597c871-0dd5-45f0-8683-67a66920271a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ccb80-ad1e-4373-a2ef-b05f428665b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e934755e-634a-466e-ba7a-fea0c6f9ed16");

            migrationBuilder.RenameColumn(
                name: "CancellationDate",
                table: "BookedAppointments",
                newName: "AppointmentFinishedDate");

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "BookedAppointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
    }
}
