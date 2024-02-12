using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedPatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "252c63ed-f18c-4371-90da-470ff25279a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4e7bc440-af9d-4186-b460-d3ed4f36a70a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "9e36f896-198b-41ce-b5ca-968cd1b95729" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "9e36f896-198b-41ce-b5ca-968cd1b95729" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "545BBA82-840A-4446-BFF6-64834A8DA52F");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252c63ed-f18c-4371-90da-470ff25279a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e7bc440-af9d-4186-b460-d3ed4f36a70a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e36f896-198b-41ce-b5ca-968cd1b95729");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "BookedReservations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2a80d426-5c89-46e3-9a84-394a2965ba59", 0, "0fe98064-9a07-4ed5-9347-c200667f9464", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAED50b4xXSeCld6E9ERRZ5Xz5UXwjPotVTsWZf5t92mPXBKsyg+wl7wUIiEsoezuuYw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bcf39e1f-bfff-48e9-8692-5ef6f1a925bb", false, "admin2@example.com" },
                    { "a76cac46-31e1-44d0-92fa-eb6046152e24", 0, "d39d2e9c-0d13-4cdd-bb90-def8779e7eae", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAYH3xY0TJiPciR94qBvvRiAUxaSWSzdvDPR1uUyIQKQRMSaJOkKJWaCQV9ZKdkQ3w==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9d387226-c2ea-4aed-b15f-c9cc29fc36fe", false, "admin@example.com" },
                    { "d052fc49-4a1d-4257-b19a-de10a4110669", 0, "cb54bca3-5c4e-46a3-9f45-1d470b65ee99", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECTROU1e+zjK0cN7mPsL76rDhKQd/1teOvqSXWZB0n6vZcq5mmZsAuS3ADvXqrduNw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "700f1a5a-66cc-4b2c-b5f0-9075baf6c06e", false, "patient1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                column: "PersonId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastName",
                value: "One");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Admin", "Two" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Patient", "One" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 4, null, "Patient", "Two", null },
                    { 5, null, "Patient", "Three", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2a80d426-5c89-46e3-9a84-394a2965ba59" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a76cac46-31e1-44d0-92fa-eb6046152e24" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d052fc49-4a1d-4257-b19a-de10a4110669" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07f0541e-3cdd-40da-a7d4-b33d69dd7918", 0, "8750e789-98fb-4a58-9e9e-916fc0e180c7", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPEuL7333mLBXDoeH1W1xwJl+1a01dflNK3J0eTbfOkq+0NRvjcnMSVLytj8nhqSlA==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "de013a78-f5e4-49e5-9460-422469423976", false, "patient3@example.com" },
                    { "6f313bcc-bda4-499c-b92f-8c6422b9fdd5", 0, "3784c9dc-264e-48dc-b7d1-fca56e1c963d", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOgd3clbjlpgEukLuLsz2alHkfWuvli/I/g8cBygdo+WG9Npg+dfy2sboNYEKpBPpA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4d50ab4-0f5b-401f-92c0-cac9023b15b0", false, "patient2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                column: "PersonId",
                values: new object[]
                {
                    4,
                    5
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07f0541e-3cdd-40da-a7d4-b33d69dd7918" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6f313bcc-bda4-499c-b92f-8c6422b9fdd5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07f0541e-3cdd-40da-a7d4-b33d69dd7918" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2a80d426-5c89-46e3-9a84-394a2965ba59" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6f313bcc-bda4-499c-b92f-8c6422b9fdd5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a76cac46-31e1-44d0-92fa-eb6046152e24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d052fc49-4a1d-4257-b19a-de10a4110669" });

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f0541e-3cdd-40da-a7d4-b33d69dd7918");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a80d426-5c89-46e3-9a84-394a2965ba59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f313bcc-bda4-499c-b92f-8c6422b9fdd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a76cac46-31e1-44d0-92fa-eb6046152e24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d052fc49-4a1d-4257-b19a-de10a4110669");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "BookedReservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", null, "Physiotherapist", "PHYSIOTHERAPIST" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "252c63ed-f18c-4371-90da-470ff25279a5", 0, "5a80a4bf-0227-4079-ad0b-28595ee07472", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEExF0AvoSs1eH8txV1NcnpkKIwL2ahPuryx4bIXoWC6Sn7SLbev93r6dEHdQ2mEuHw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0d1e1e2c-609b-46c9-afee-e61f3b1a02d9", false, "physiotherapist@example.com" },
                    { "4e7bc440-af9d-4186-b460-d3ed4f36a70a", 0, "16265be2-dd26-426d-9b92-38b96d25694c", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEFWvb2QRq4NQY0cUTTVwFzF3aMGQFeagtGNSEzwCsGoX/BL1Hn1inU6GC/p3/N4rw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "52f3016b-1423-4146-84ef-09a1107480a1", false, "patient@example.com" },
                    { "9e36f896-198b-41ce-b5ca-968cd1b95729", 0, "8fee0d29-fe1e-4916-af23-8f9d342cdbd7", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHSOBaF1J/Be+lk3iaB7izFTwamTR8FG/LOaKUshJ/LtRennK/Ql6uhooQW12nyn0A==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "82d50043-a61a-443a-9911-27a64e4c5258", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastName",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "John", "Doe" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Doe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "252c63ed-f18c-4371-90da-470ff25279a5" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4e7bc440-af9d-4186-b460-d3ed4f36a70a" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "9e36f896-198b-41ce-b5ca-968cd1b95729" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "9e36f896-198b-41ce-b5ca-968cd1b95729" }
                });
        }
    }
}
