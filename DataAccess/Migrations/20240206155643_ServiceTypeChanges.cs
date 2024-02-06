using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ServiceTypeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4f30ff4c-e382-4f36-b52e-c5996b4a4b06" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "60827d6b-e111-4981-a82f-a61959ccd62c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "717f24fb-6e48-457e-8211-ce6aee89d849" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "717f24fb-6e48-457e-8211-ce6aee89d849" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f30ff4c-e382-4f36-b52e-c5996b4a4b06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60827d6b-e111-4981-a82f-a61959ccd62c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "717f24fb-6e48-457e-8211-ce6aee89d849");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ServiceTypes");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3336bc12-205e-4057-98b9-e0ae6025fbb6", 0, "556186d8-afa3-4647-bff2-99b90eb3e9d6", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOcJejD/sT3AnUv+/n4FuFkkLeDyoPpxxlLxdyBHcxswFpywLE3OXB9jRucGBmr8xg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bedf36f9-73ff-4d29-9a9c-b1ba889baff8", false, "patient@example.com" },
                    { "559dcfe0-d24e-4d44-b6a3-89ff329693ec", 0, "df896a26-36bf-4317-9400-905c4306bcc1", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPLkJ4QBFAGTCFQTM85ah4PJetn62Ht0Sw7Opjg4bOtPUGTMo1z0DuhmOF5izj5R/g==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "449ca71c-47a7-45ea-a820-999af2ef4c17", false, "physiotherapist@example.com" },
                    { "b19744f0-306a-4f96-82e0-65173beb363c", 0, "2c26aa40-1c96-4fb0-bb9d-9ba0c3a9fd3a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEErOdTo25Ia5Q6aQuY+sqy6UNy/VU34PUFxJJYEtbfR04vyv28v/rWuo9IlS+rpFkA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "533896fe-51e1-4f48-b478-be0b5c77bc53", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "3336bc12-205e-4057-98b9-e0ae6025fbb6" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "559dcfe0-d24e-4d44-b6a3-89ff329693ec" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "b19744f0-306a-4f96-82e0-65173beb363c" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "b19744f0-306a-4f96-82e0-65173beb363c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "3336bc12-205e-4057-98b9-e0ae6025fbb6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "559dcfe0-d24e-4d44-b6a3-89ff329693ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "b19744f0-306a-4f96-82e0-65173beb363c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "b19744f0-306a-4f96-82e0-65173beb363c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3336bc12-205e-4057-98b9-e0ae6025fbb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "559dcfe0-d24e-4d44-b6a3-89ff329693ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b19744f0-306a-4f96-82e0-65173beb363c");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "ServiceTypes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f30ff4c-e382-4f36-b52e-c5996b4a4b06", 0, "b57de4ba-990a-4215-a509-dc482ab4c353", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN0M4n0mpPFmPzDvbTwv5oszy4qJtL8si947gO7RFXuXmLtGUUwTLnaROWwF9O2LiQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d76e1c5-6f8f-405a-b0fb-87fe79c0ce45", false, "patient@example.com" },
                    { "60827d6b-e111-4981-a82f-a61959ccd62c", 0, "d2fdadc7-f28a-4a45-89ac-56ab51f1eb45", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAECrQXjuKg1dfH9Qv4+IolP+SVK9a3QguB1crCd3RalnjGLI1049aTybX0EPbIRYewA==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cdffde19-9ed8-43f6-996a-ef59b7bd4aee", false, "physiotherapist@example.com" },
                    { "717f24fb-6e48-457e-8211-ce6aee89d849", 0, "c34ee3a1-3e80-4836-bc24-8a0ff42350e1", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOsYqkWwF4JY1ZCwVEUCLnOhFesxWil1lu3skWGlFu6RCmhNxYZoVzDCkM+H6LVcPg==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "acad0193-2d23-416b-b7ea-9c7f9b497b78", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4f30ff4c-e382-4f36-b52e-c5996b4a4b06" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "60827d6b-e111-4981-a82f-a61959ccd62c" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "717f24fb-6e48-457e-8211-ce6aee89d849" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "717f24fb-6e48-457e-8211-ce6aee89d849" }
                });
        }
    }
}
