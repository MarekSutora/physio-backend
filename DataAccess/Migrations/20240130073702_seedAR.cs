using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class seedAR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4a4b4ef0-ec87-485d-b01b-0fb51bb3a3a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6fcf90f3-92bd-4572-9f67-d2fdc389853b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "d0342876-8e7a-4821-8507-0df011e06ad2" });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a4b4ef0-ec87-485d-b01b-0fb51bb3a3a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fcf90f3-92bd-4572-9f67-d2fdc389853b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0342876-8e7a-4821-8507-0df011e06ad2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b89cdec-a76c-4caf-a209-76e0b0efaf0a", 0, null, "dac84364-21c5-4b15-9255-0786aa036f6a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG82HM33db92Ecph0sgIFzRjbNI22l2xgVaA6n/+qCUF+tZYe3O4yUbh5gMI36ltyw==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6b8b8119-04e4-4a64-b905-d06d8247109b", false, "admin@example.com" },
                    { "a53fc396-157a-4e12-901c-bab515297d43", 0, null, "89fc8f43-2227-4aae-81ef-37beace63b91", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKiMKrhhHCYGsg5sJL+aHLqGFRiNlyklYQPG18KlTv+QL6d0t/e1OLRFzL0k1t9C0Q==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e63f03b7-3369-4b3c-a966-3c9164e2fde9", false, "physiotherapist@example.com" },
                    { "edb62273-187b-486f-9897-1e5bc06c8004", 0, null, "299ad2ab-885c-4970-a970-de59cdc64c9b", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAtoK/s321dlOgff1qKyaa/nRCRbrTgDcQF9/3XWMFIdhrh7N+Yb8oyN6hntMeJ2Bw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "acc1236c-dc38-40cf-89a9-d5660290ace8", false, "patient@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Capacity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Capacity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 3,
                column: "Capacity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 5,
                column: "Capacity",
                value: 5);

            migrationBuilder.InsertData(
                table: "AvailableReservation",
                columns: new[] { "Id", "Capacity", "Date", "ReservedAmount" },
                values: new object[,]
                {
                    { 6, 6, new DateTime(2024, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, 1, new DateTime(2024, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, 2, new DateTime(2024, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, 3, new DateTime(2024, 2, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, 4, new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, 4, new DateTime(2024, 2, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 5, new DateTime(2024, 2, 1, 14, 35, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 13, 1, new DateTime(2024, 2, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, 2, new DateTime(2024, 3, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, 10, new DateTime(2024, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, 1, new DateTime(2024, 3, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17, 2, new DateTime(2024, 3, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "1b89cdec-a76c-4caf-a209-76e0b0efaf0a" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "a53fc396-157a-4e12-901c-bab515297d43" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "edb62273-187b-486f-9897-1e5bc06c8004" }
                });

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 17 },
                    { 2, 6 },
                    { 2, 8 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 14 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 4, 7 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 12 },
                    { 4, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "1b89cdec-a76c-4caf-a209-76e0b0efaf0a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "a53fc396-157a-4e12-901c-bab515297d43" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "edb62273-187b-486f-9897-1e5bc06c8004" });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b89cdec-a76c-4caf-a209-76e0b0efaf0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a53fc396-157a-4e12-901c-bab515297d43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb62273-187b-486f-9897-1e5bc06c8004");

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a4b4ef0-ec87-485d-b01b-0fb51bb3a3a1", 0, null, "8c1850ee-050e-4dec-9f2f-f00804fe7146", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEINDEV/W5WLdBbKvS17j2hHuAj2F533SUZSuuMQ0MT+F/7RMHpXpfeHizcENaxOU+g==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1b653dc2-bca1-426f-92b8-50833d5a2c7b", false, "patient@example.com" },
                    { "6fcf90f3-92bd-4572-9f67-d2fdc389853b", 0, null, "ae7d7324-e66b-4899-b5f1-7c77b2d567bc", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIeji/S+H1pmUlYbhExmZLURTGuyseYDB0W8n+YtFdq7s2XxXCZH+y/2MvL2XnjIcg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0e691581-86eb-4a73-9009-59a2ed93215a", false, "physiotherapist@example.com" },
                    { "d0342876-8e7a-4821-8507-0df011e06ad2", 0, null, "57c77804-13d9-47ec-b27c-a736a236b810", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDmrd+dTNQ/p66wwxuMNN/ljnCgRbS4uFi75pNBIRgGh2mZldJba8H9nNsa2u/iboA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "946b3a5c-f4ea-4b06-8e42-5055f5f4cf7e", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Capacity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Capacity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 3,
                column: "Capacity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 5,
                column: "Capacity",
                value: 4);

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4a4b4ef0-ec87-485d-b01b-0fb51bb3a3a1" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6fcf90f3-92bd-4572-9f67-d2fdc389853b" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "d0342876-8e7a-4821-8507-0df011e06ad2" }
                });
        }
    }
}
