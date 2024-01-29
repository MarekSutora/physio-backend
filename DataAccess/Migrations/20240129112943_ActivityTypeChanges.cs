using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class ActivityTypeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "0846106c-0c94-47c3-adbc-120f226f1f19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "669be530-3bdd-4e2a-b5e0-1cd2b273f45e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "789730d7-ef11-4238-ab0b-0621a16deb18" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0846106c-0c94-47c3-adbc-120f226f1f19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "669be530-3bdd-4e2a-b5e0-1cd2b273f45e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789730d7-ef11-4238-ab0b-0621a16deb18");

            migrationBuilder.RenameColumn(
                name: "NormalCost",
                table: "ActivityType",
                newName: "Cost");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a4b4ef0-ec87-485d-b01b-0fb51bb3a3a1", 0, null, "8c1850ee-050e-4dec-9f2f-f00804fe7146", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEINDEV/W5WLdBbKvS17j2hHuAj2F533SUZSuuMQ0MT+F/7RMHpXpfeHizcENaxOU+g==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1b653dc2-bca1-426f-92b8-50833d5a2c7b", false, "patient@example.com" },
                    { "6fcf90f3-92bd-4572-9f67-d2fdc389853b", 0, null, "ae7d7324-e66b-4899-b5f1-7c77b2d567bc", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIeji/S+H1pmUlYbhExmZLURTGuyseYDB0W8n+YtFdq7s2XxXCZH+y/2MvL2XnjIcg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0e691581-86eb-4a73-9009-59a2ed93215a", false, "physiotherapist@example.com" },
                    { "d0342876-8e7a-4821-8507-0df011e06ad2", 0, null, "57c77804-13d9-47ec-b27c-a736a236b810", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDmrd+dTNQ/p66wwxuMNN/ljnCgRbS4uFi75pNBIRgGh2mZldJba8H9nNsa2u/iboA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "946b3a5c-f4ea-4b06-8e42-5055f5f4cf7e", false, "admin@example.com" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "ActivityType",
                newName: "NormalCost");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0846106c-0c94-47c3-adbc-120f226f1f19", 0, null, "2b85cf25-6317-4cd7-9713-a63288837142", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPGBXjbQdi/imkvDbMhFbGygWPkfoRrJNFURSwi5UBzPuaL4AXgBH/mfB1xxWaeKJw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d116440d-9c2e-4809-b541-7be5011b59cc", false, "physiotherapist@example.com" },
                    { "669be530-3bdd-4e2a-b5e0-1cd2b273f45e", 0, null, "0e6c3939-f66d-46c7-a238-7273b5eb52f4", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOJBbZEu2ERAJdMDxVmOF3VtufSJtkeuDVEauPhPVUiHyHMc8izXuCKBJ1xJZL08aw==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4058f29e-5a50-46ac-86a2-26af8efd18bc", false, "admin@example.com" },
                    { "789730d7-ef11-4238-ab0b-0621a16deb18", 0, null, "5d60a042-0315-429d-82f7-96c2682fa9b8", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIdcIWLgLy+Hm7hExF8nElzBVclhKf8fjAr3S1IlhUu/Ra34RuHMlaP94WqQALJTVA==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d8efa2f9-5e84-45f2-9921-da42da235109", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "0846106c-0c94-47c3-adbc-120f226f1f19" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "669be530-3bdd-4e2a-b5e0-1cd2b273f45e" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "789730d7-ef11-4238-ab0b-0621a16deb18" }
                });
        }
    }
}
