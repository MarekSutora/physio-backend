using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", null, "Employee", "PHYSIOTHERAPIST" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", null, "Admin", "ADMIN" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", null, "Patient", "PATIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9e7d954e-aa41-4663-b6c1-f405142f43e8", 0, "7ef9751e-a615-4e10-95ca-007d856dbd3b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "physiotherapist@example.com", true, false, null, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@PHYSIOTHERAPIST.COM", "AQAAAAIAAYagAAAAEJir5d6Cmv20nGn//X/ChvgxsropyTBIuxmfUO8cdGUNp8QzwgeYPmtFPo2ZRTS5FQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "physiotherapist@example.com" },
                    { "a9f4bc23-cd2b-44aa-8056-09fad4c54fcf", 0, "09785dab-620d-4c4b-96b2-f3fa8fe50298", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "patient@example.com", true, false, null, null, "patient@EXAMPLE.COM", "PATIENT@PATIENT.COM", "AQAAAAIAAYagAAAAELIoZbHsiWjpbc1ObfwJGYntSzTXrilMKF3k6GqIWY78VjM7oIwezEBaaee2BkuTCQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "patient@example.com" },
                    { "eed760ae-11a8-4a07-b5c4-662ca13273a5", 0, "b41c905e-3a50-4939-af29-3697753234af", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, false, null, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEChaRmf7crCKLhBEDdSGdyJAcVZvZ2Lm2ULKyYohuLdHpzWBcYK1KbmQBwucT/8xhw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "9e7d954e-aa41-4663-b6c1-f405142f43e8" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "a9f4bc23-cd2b-44aa-8056-09fad4c54fcf" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "eed760ae-11a8-4a07-b5c4-662ca13273a5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "9e7d954e-aa41-4663-b6c1-f405142f43e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "a9f4bc23-cd2b-44aa-8056-09fad4c54fcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "eed760ae-11a8-4a07-b5c4-662ca13273a5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "545BBA82-840A-4446-BFF6-64834A8DA52F");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8036F52A-701F-4AA4-8639-D9C8123FD8C6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C7D20194-9C7E-40DB-9C63-F71D20116529");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e7d954e-aa41-4663-b6c1-f405142f43e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9f4bc23-cd2b-44aa-8056-09fad4c54fcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eed760ae-11a8-4a07-b5c4-662ca13273a5");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");
        }
    }
}
