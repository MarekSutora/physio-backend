using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ActivityToService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_ActivityType_ActivityTypeId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "ActivityTypeToDisplay");

            migrationBuilder.DropTable(
                name: "AvailableReservationActivityType");

            migrationBuilder.DropTable(
                name: "ActivityType");

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
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AvailableReservation",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.RenameColumn(
                name: "ActivityTypeId",
                table: "Reservation",
                newName: "ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ActivityTypeId",
                table: "Reservation",
                newName: "IX_Reservation_ServiceTypeId");

            migrationBuilder.AddColumn<bool>(
                name: "Cancelled",
                table: "Reservation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HexColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypeToDisplay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypeToDisplay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvailableReservationServiceType",
                columns: table => new
                {
                    AvailableReservationId = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableReservationServiceType", x => new { x.AvailableReservationId, x.ServiceTypeId });
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceType_AvailableReservation_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceType_ServiceType_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypeDurationCost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypeDurationCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTypeDurationCost_ServiceType_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cd3728f3-80be-41ae-a2dc-87b6458269ef", 0, "62d85e8c-b32e-49c2-a8ef-5bc43dbaf181", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAELuZEQxkZRMdzXjysGx+slPvL/xbjyKSQgwCk0tMOnKWZ4fhYMBhqPVmLNK8aK85Lw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c369445d-fcd6-404e-bfda-011b7e924011", false, "patient@example.com" },
                    { "d4e6ae1f-61e0-4fc6-ad0c-36a4dace2998", 0, "306daf4b-8636-49aa-a4c7-25073ba3f91a", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEERdkOiI/n7aOP+b06asufE/U9FgoInP1A31DppV58rm6XmsTIhXdU+zIXC0J/Ef5w==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c3d5cde4-4a21-46c4-9f32-5679ff2c83ed", false, "physiotherapist@example.com" },
                    { "e2a33bb0-c13f-4cd0-a2e8-cee43284da17", 0, "ccebb077-8b6c-431c-92eb-98822c81d22b", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMRHQTzfys6nk7kfsjyJXchLnpyiN3ri2uZzk059PHFndFBQOM+dzU7zBDE32/Bg6g==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5f264002-82d5-42a2-a9d5-2b96de0a89e6", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "cd3728f3-80be-41ae-a2dc-87b6458269ef" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "d4e6ae1f-61e0-4fc6-ad0c-36a4dace2998" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "e2a33bb0-c13f-4cd0-a2e8-cee43284da17" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "e2a33bb0-c13f-4cd0-a2e8-cee43284da17" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationServiceType_ServiceTypeId",
                table: "AvailableReservationServiceType",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDurationCost_ServiceTypeId",
                table: "ServiceTypeDurationCost",
                column: "ServiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_ServiceType_ServiceTypeId",
                table: "Reservation",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_ServiceType_ServiceTypeId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "AvailableReservationServiceType");

            migrationBuilder.DropTable(
                name: "ServiceTypeDurationCost");

            migrationBuilder.DropTable(
                name: "ServiceTypeToDisplay");

            migrationBuilder.DropTable(
                name: "ServiceType");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "cd3728f3-80be-41ae-a2dc-87b6458269ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "d4e6ae1f-61e0-4fc6-ad0c-36a4dace2998" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "e2a33bb0-c13f-4cd0-a2e8-cee43284da17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "e2a33bb0-c13f-4cd0-a2e8-cee43284da17" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd3728f3-80be-41ae-a2dc-87b6458269ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e6ae1f-61e0-4fc6-ad0c-36a4dace2998");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a33bb0-c13f-4cd0-a2e8-cee43284da17");

            migrationBuilder.DropColumn(
                name: "Cancelled",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "ServiceTypeId",
                table: "Reservation",
                newName: "ActivityTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ServiceTypeId",
                table: "Reservation",
                newName: "IX_Reservation_ActivityTypeId");

            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    HexColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AvailableReservationActivityType",
                columns: table => new
                {
                    ActivityTypeId = table.Column<int>(type: "int", nullable: false),
                    AvailableReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableReservationActivityType", x => new { x.ActivityTypeId, x.AvailableReservationId });
                    table.ForeignKey(
                        name: "FK_AvailableReservationActivityType_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableReservationActivityType_AvailableReservation_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActivityType",
                columns: new[] { "Id", "Cost", "Description", "Duration", "HexColor", "Name" },
                values: new object[,]
                {
                    { 1, 60m, "Individuálna konzultácia", 30, "#007bff", "Konzultácia" },
                    { 2, 50m, "Terapeutická fyzioterapia", 60, "#28a745", "Fyzioterapia" },
                    { 3, 40m, "Relaxačná masáž", 45, "#dc3545", "Masáž" },
                    { 4, 40m, "Rehabilitačné cvičenia", 60, "#ffc107", "Rehabilitácia" }
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
                table: "AvailableReservation",
                columns: new[] { "Id", "Capacity", "Date", "ReservedAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 2, new DateTime(2024, 1, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 3, new DateTime(2024, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 4, new DateTime(2024, 1, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 5, new DateTime(2024, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0 },
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "1a82c7f9-2056-4465-92b2-87f0a927e2cd" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "284a3606-d583-4e61-b754-0dcaf9f7e791" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "284a3606-d583-4e61-b754-0dcaf9f7e791" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "67b15e36-90d2-4383-bd46-b05fe4065958" }
                });

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 8 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 2 },
                    { 2, 5 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 13 },
                    { 2, 15 },
                    { 2, 17 },
                    { 3, 3 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 10 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 4, 3 },
                    { 4, 6 },
                    { 4, 9 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationActivityType_AvailableReservationId",
                table: "AvailableReservationActivityType",
                column: "AvailableReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_ActivityType_ActivityTypeId",
                table: "Reservation",
                column: "ActivityTypeId",
                principalTable: "ActivityType",
                principalColumn: "Id");
        }
    }
}
