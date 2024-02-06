using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ServiceTypeChanges2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypeDurationCost_ServiceTypes_ServiceTypeId",
                table: "ServiceTypeDurationCost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypeDurationCost",
                table: "ServiceTypeDurationCost");

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

            migrationBuilder.RenameTable(
                name: "ServiceTypeDurationCost",
                newName: "ServiceTypeDurationCosts");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceTypeDurationCost_ServiceTypeId",
                table: "ServiceTypeDurationCosts",
                newName: "IX_ServiceTypeDurationCosts_ServiceTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypeDurationCosts",
                table: "ServiceTypeDurationCosts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29aa6dbf-c1df-4ae7-88ee-1054832a8d09", 0, "07280a3d-b913-4f20-8b59-5de72cd900e9", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAIRNZVIh0Gs+X2tpN+94OsHXn7d9SxxGtpeliXVBKSq4UtBkGP2Gu71tOdiDkJsGw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ffdde672-d56a-428b-ade0-5e5bb9d92678", false, "patient@example.com" },
                    { "7d5c1d61-4f4b-4f78-a7dd-fa6313326584", 0, "80412e42-1d3e-43da-b2fc-a22af1bad134", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ1ZpykxPTnEP4jyyHKDsvw/etnQb20dZ1UQIaB+cuMoQYX8WZ+zEdnd9SauoSmV/g==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "93b0589f-8086-445a-8c9c-eb3cf8fb0b4d", false, "admin@example.com" },
                    { "f13a2170-2de4-4021-bf08-fa87df056aca", 0, "10012c79-7248-402d-9db2-a5bfa01a293a", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPF6yCCV9NhFCD1tZNHxPYhZIsiGIzPzoqJCP1IiZ3FNqpe0lLBk20oqBa4hxJc+YQ==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2367df58-47fb-4a5d-9f3d-c38a5a0266f4", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "29aa6dbf-c1df-4ae7-88ee-1054832a8d09" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "f13a2170-2de4-4021-bf08-fa87df056aca" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypeDurationCosts_ServiceTypes_ServiceTypeId",
                table: "ServiceTypeDurationCosts",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypeDurationCosts_ServiceTypes_ServiceTypeId",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypeDurationCosts",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "29aa6dbf-c1df-4ae7-88ee-1054832a8d09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "f13a2170-2de4-4021-bf08-fa87df056aca" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29aa6dbf-c1df-4ae7-88ee-1054832a8d09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d5c1d61-4f4b-4f78-a7dd-fa6313326584");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f13a2170-2de4-4021-bf08-fa87df056aca");

            migrationBuilder.RenameTable(
                name: "ServiceTypeDurationCosts",
                newName: "ServiceTypeDurationCost");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceTypeDurationCosts_ServiceTypeId",
                table: "ServiceTypeDurationCost",
                newName: "IX_ServiceTypeDurationCost_ServiceTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypeDurationCost",
                table: "ServiceTypeDurationCost",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypeDurationCost_ServiceTypes_ServiceTypeId",
                table: "ServiceTypeDurationCost",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
