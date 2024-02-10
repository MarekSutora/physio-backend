using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class columnRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "3d0d9f32-5926-4286-8312-a3b0920ccacf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "3d0d9f32-5926-4286-8312-a3b0920ccacf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6bbec599-63e9-495c-abf9-c72845c8ec71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "9d92412f-c325-4620-a4d0-1bd547ed88e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d0d9f32-5926-4286-8312-a3b0920ccacf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bbec599-63e9-495c-abf9-c72845c8ec71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d92412f-c325-4620-a4d0-1bd547ed88e1");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "AvailableReservations",
                newName: "StartTime");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "252c63ed-f18c-4371-90da-470ff25279a5", 0, "5a80a4bf-0227-4079-ad0b-28595ee07472", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEExF0AvoSs1eH8txV1NcnpkKIwL2ahPuryx4bIXoWC6Sn7SLbev93r6dEHdQ2mEuHw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0d1e1e2c-609b-46c9-afee-e61f3b1a02d9", false, "physiotherapist@example.com" },
                    { "4e7bc440-af9d-4186-b460-d3ed4f36a70a", 0, "16265be2-dd26-426d-9b92-38b96d25694c", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEFWvb2QRq4NQY0cUTTVwFzF3aMGQFeagtGNSEzwCsGoX/BL1Hn1inU6GC/p3/N4rw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "52f3016b-1423-4146-84ef-09a1107480a1", false, "patient@example.com" },
                    { "9e36f896-198b-41ce-b5ca-968cd1b95729", 0, "8fee0d29-fe1e-4916-af23-8f9d342cdbd7", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHSOBaF1J/Be+lk3iaB7izFTwamTR8FG/LOaKUshJ/LtRennK/Ql6uhooQW12nyn0A==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "82d50043-a61a-443a-9911-27a64e4c5258", false, "admin@example.com" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "AvailableReservations",
                newName: "Date");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d0d9f32-5926-4286-8312-a3b0920ccacf", 0, "051228e7-529c-45d0-92db-4768e83f1d7a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELImT4NbNrxchfKL6gbO7y3Cv0BAMcdhk5XvoTdEJ5qWaCrjBcrc6/G5HqNUkXfOWQ==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8bf9b7c1-2fe5-4381-a4ef-15003ae9f27a", false, "admin@example.com" },
                    { "6bbec599-63e9-495c-abf9-c72845c8ec71", 0, "f8879d9f-659a-4452-aa08-b5f634ef017e", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHG7w7evJP7bPeX5pdIu2ZqYFknsurUXX8Wypg8w8LAjnhAVGuLEX0GRjDMTtkttKg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a6992436-0de2-4a8e-bf1e-aea73737763c", false, "physiotherapist@example.com" },
                    { "9d92412f-c325-4620-a4d0-1bd547ed88e1", 0, "901af2ef-3dbe-4e74-b8b6-cfec1cc367dd", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBQahFlZZoxTY7k6bp5ziyrrcq5x+Ohh7R4FHf3xwvwjGzcCwuZPugFc39a9aoyubA==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2aed5303-79ee-4df3-a6c3-edb87bc34bf6", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "3d0d9f32-5926-4286-8312-a3b0920ccacf" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "3d0d9f32-5926-4286-8312-a3b0920ccacf" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6bbec599-63e9-495c-abf9-c72845c8ec71" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "9d92412f-c325-4620-a4d0-1bd547ed88e1" }
                });
        }
    }
}
