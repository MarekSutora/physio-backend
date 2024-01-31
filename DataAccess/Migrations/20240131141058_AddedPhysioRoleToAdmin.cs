using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhysioRoleToAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "08b24183-96e5-4dcc-ae6d-defe3757cc7b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "0cbe3858-14ba-4abe-9e4f-705c2a811b56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6379d698-6fd3-4056-9432-74fc8addc250" });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 13 });

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
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 1 });

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
                keyValues: new object[] { 4, 2 });

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
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b24183-96e5-4dcc-ae6d-defe3757cc7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cbe3858-14ba-4abe-9e4f-705c2a811b56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6379d698-6fd3-4056-9432-74fc8addc250");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ActivityTypeToDisplay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTypeToDisplay", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a82c7f9-2056-4465-92b2-87f0a927e2cd", 0, "2d051bfc-3719-422c-8f6d-599a90243b24", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEl/GLz/JOZrJwybtTjqZcgEwwK9kFT2gtnJuEemslLl+OuYdCczpTksuM6Crr/caA==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c2090d2-5cdc-4020-8594-fc1188e907e0", false, "patient@example.com" },
                    { "284a3606-d583-4e61-b754-0dcaf9f7e791", 0, "65755459-c4cb-44db-b32b-91b1c6f65050", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAENKf4IQi1i1H+nNFC/Y8HTjKXkp7FUkl+nsa2FI5I4dS8fFb1WY1f/I6eoSvIgzrOQ==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9981328d-bc97-445a-bb7b-62086abb0b55", false, "admin@example.com" },
                    { "67b15e36-90d2-4383-bd46-b05fe4065958", 0, "76c0af5b-b375-46f5-9987-813bd2207879", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBaYwqCBc3yAzviuLcrnBUWRlltGr/I2XS8xPaKiiuGoJO3p0BSSjWmJeF3GOXOTmw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4617fe4f-134a-458f-bf82-9a92617cb62c", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 8 },
                    { 1, 10 },
                    { 2, 5 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 17 },
                    { 3, 3 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 10 },
                    { 3, 15 },
                    { 4, 16 },
                    { 4, 17 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "1a82c7f9-2056-4465-92b2-87f0a927e2cd" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "284a3606-d583-4e61-b754-0dcaf9f7e791" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "284a3606-d583-4e61-b754-0dcaf9f7e791" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "67b15e36-90d2-4383-bd46-b05fe4065958" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityTypeToDisplay");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "1a82c7f9-2056-4465-92b2-87f0a927e2cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "284a3606-d583-4e61-b754-0dcaf9f7e791" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "284a3606-d583-4e61-b754-0dcaf9f7e791" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "67b15e36-90d2-4383-bd46-b05fe4065958" });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a82c7f9-2056-4465-92b2-87f0a927e2cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "284a3606-d583-4e61-b754-0dcaf9f7e791");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b15e36-90d2-4383-bd46-b05fe4065958");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08b24183-96e5-4dcc-ae6d-defe3757cc7b", 0, null, "4dbe9bce-1580-46c9-ba1a-2dbef8237ca5", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAECTqxV6OY83OSkqTjtvcujTlIVATDCaAQRPfsBW1lBI6m+6PAyhVmVcTDZkDSgoRZg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d2a96af-11ca-4323-89ec-6a5a816060a9", false, "patient@example.com" },
                    { "0cbe3858-14ba-4abe-9e4f-705c2a811b56", 0, null, "2af40260-1d3b-4abf-8d95-8f1eddde937f", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMuDqEe+H6tVVERyhl1A8Eup2VWvlFm7x1aJ2tLTL0DGk1dyALHgfGnyjUmEDW+laA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3aead33b-f591-4480-8f92-c865629d6712", false, "admin@example.com" },
                    { "6379d698-6fd3-4056-9432-74fc8addc250", 0, null, "d6ad9310-9a85-4bde-97d2-8af72c9c8b31", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFV87yihEyDXQWwekUY/Ob0pmPkMGnT0JiM3ejcs5/rjOm8iFvieijq3sb+bnv+QUw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2f97b418-d5c9-436b-909c-534a8ab57bed", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 15 },
                    { 1, 17 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "08b24183-96e5-4dcc-ae6d-defe3757cc7b" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "0cbe3858-14ba-4abe-9e4f-705c2a811b56" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6379d698-6fd3-4056-9432-74fc8addc250" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }
    }
}
