using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class reservationToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedReservations");

            migrationBuilder.DropTable(
                name: "AvailableReservationServiceTypeDcs");

            migrationBuilder.DropTable(
                name: "AvailableReservations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "63f41267-98c2-47f5-be4b-ad3d61d3f1e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7f896736-82f8-4def-81ea-e3063ff3de37" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7fd53cba-392d-4d13-bc02-f7b6e40c35bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80d90c3b-bad0-4097-8635-13a269c314a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63f41267-98c2-47f5-be4b-ad3d61d3f1e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f896736-82f8-4def-81ea-e3063ff3de37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fd53cba-392d-4d13-bc02-f7b6e40c35bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80d90c3b-bad0-4097-8635-13a269c314a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentServiceTypeDurationCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeDurationCostId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentServiceTypeDurationCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentServiceTypeDurationCosts_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCosts_ServiceTypeDurationCostId",
                        column: x => x.ServiceTypeDurationCostId,
                        principalTable: "ServiceTypeDurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    AppointmentBookedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentFinishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppointmentServiceTypeDurationCostId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    AppointmentId = table.Column<int>(type: "int", nullable: true),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedAppointments_AppointmentServiceTypeDurationCosts_AppointmentServiceTypeDurationCostId",
                        column: x => x.AppointmentServiceTypeDurationCostId,
                        principalTable: "AppointmentServiceTypeDurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedAppointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookedAppointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_BookedAppointments_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0bcd48d1-658a-4118-8828-c18a8f950b5a", 0, "16e2abfe-db5c-486d-8c0b-61baaff7de4b", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAECRKj7LambNdXWE0bQ6A+IrekpsijrroJEDuhdWW3Roj9DuvxA3HrFLg3RaftMqouA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2158fd0c-41df-448a-bfb0-c9f5bfb08453", false, "patient2@example.com" },
                    { "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864", 0, "0b50cb69-567a-4784-a6cc-79ad2a01d845", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIPsCo2yK9vcH3eaJ0k3EXE1FqmXFqbDbaL2aRRpdCnuwLo4yGqUNGA8Oe1VppR6+A==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "171e4add-68c1-4ba2-a1b9-2fb82f921b93", false, "admin@example.com" },
                    { "6bd76916-4e69-4cb0-ad72-8ae63efb943f", 0, "b87acd44-4798-4e27-a77b-1d24d8c5de9f", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB1UFc0N+dyHojppskL4tKvZEPgllSGB1FdiISWXVePBHC8izgIBXU/fBT6jhnFeGA==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5191e3c2-212e-41ae-af82-574eb4cb63fd", false, "patient1@example.com" },
                    { "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7", 0, "a63cc2ae-62c4-4048-bdab-6e81445602d9", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAECjxJ/WqHWYe34jAJwnREwFDZJz39A5K/dZ480gHG0JwDra7bbvP5cV14g0FTzv1iQ==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2ac3d873-b915-4d8e-94a8-d7ae7c30cf26", false, "patient3@example.com" },
                    { "8fdc4230-4d48-4139-89aa-16dd57b4ae94", 0, "277811e4-c776-414a-bbbc-f7919b38507b", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMWXpp2a+ifc6R9sct/jg3sPjKZVjjV0c5p6yjKqLxq2uUQyQsZGjIxOdiuYwAtgHA==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dbe558fd-904d-40ae-99af-a8f9c894973c", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "0bcd48d1-658a-4118-8828-c18a8f950b5a" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6bd76916-4e69-4cb0-ad72-8ae63efb943f" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "8fdc4230-4d48-4139-89aa-16dd57b4ae94" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "AppointmentServiceTypeDurationCosts",
                column: "ServiceTypeDurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_AppointmentId",
                table: "BookedAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_AppointmentServiceTypeDurationCostId",
                table: "BookedAppointments",
                column: "AppointmentServiceTypeDurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_PatientId",
                table: "BookedAppointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_ServiceTypeId",
                table: "BookedAppointments",
                column: "ServiceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedAppointments");

            migrationBuilder.DropTable(
                name: "AppointmentServiceTypeDurationCosts");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "0bcd48d1-658a-4118-8828-c18a8f950b5a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6bd76916-4e69-4cb0-ad72-8ae63efb943f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "8fdc4230-4d48-4139-89aa-16dd57b4ae94" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bcd48d1-658a-4118-8828-c18a8f950b5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b8f9f6f-4d7b-4060-aefb-c695c5bfe864");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd76916-4e69-4cb0-ad72-8ae63efb943f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82b0ea4e-ca87-4b77-bd83-0a32f6894ce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fdc4230-4d48-4139-89aa-16dd57b4ae94");

            migrationBuilder.CreateTable(
                name: "AvailableReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ReservedAmount = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableReservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvailableReservationServiceTypeDcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableReservationId = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeDurationCostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableReservationServiceTypeDcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceTypeDcs_AvailableReservations_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceTypeDcs_ServiceTypeDurationCosts_ServiceTypeDurationCostId",
                        column: x => x.ServiceTypeDurationCostId,
                        principalTable: "ServiceTypeDurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableReservationServiceTypeDCId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    AvailableReservationId = table.Column<int>(type: "int", nullable: true),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    ReservationBookedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationFinishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedReservations_AvailableReservationServiceTypeDcs_AvailableReservationServiceTypeDCId",
                        column: x => x.AvailableReservationServiceTypeDCId,
                        principalTable: "AvailableReservationServiceTypeDcs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedReservations_AvailableReservations_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookedReservations_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_BookedReservations_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63f41267-98c2-47f5-be4b-ad3d61d3f1e4", 0, "362c1e30-8294-45ca-8b0c-626b95366001", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHvpzQUTy8U4rB+rFkgXzcJ6C4E6tWLIv3fzihgY17WIDM7uHGLNlRTwLfY/hHV1jg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e9c17763-94bc-4bd1-a492-1404e30056b1", false, "admin2@example.com" },
                    { "7f896736-82f8-4def-81ea-e3063ff3de37", 0, "19592689-9e58-4d7e-a86a-300a7550cc59", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJEpqxz6pi00FxoXNBIabQMJK8IAABFCvS78pyLKZ/vN0galMAUpFoG9FBnkVEg67g==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4e5fbd3-8ab3-4523-9148-9982e1cac8fe", false, "patient3@example.com" },
                    { "7fd53cba-392d-4d13-bc02-f7b6e40c35bd", 0, "d6c9f707-049f-4b19-8a2f-485058a1dca8", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMWV5MbP2Cdru/BLOH29A3F9Gb/s0yL80LklDcvvBnQRVbICcpzO5teN74/jpx4/uw==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7340961a-d609-4085-bfa2-1effca4139ed", false, "patient2@example.com" },
                    { "80d90c3b-bad0-4097-8635-13a269c314a3", 0, "005a5bbe-ac09-4555-9af6-623722f7884e", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFqWP0ssfODnnH6dHd7Ti6+X0vBAhYhn53RUg2cTG4Ff2vki5vH5zrBu/dZOt3Fwww==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e57121bf-b18e-4eea-9882-2c0e1d89aa8a", false, "admin@example.com" },
                    { "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0", 0, "d4b6b4dd-6ad0-4680-b6ea-4c85d1c46701", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGzHQ8HpVPY874jcutCMUSWknprpPT3DKoksU/ClMw5wzgcLv+LbylrpQSZvn5VALQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0f9541aa-9f72-4791-92d2-70dc52a29f57", false, "patient1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "63f41267-98c2-47f5-be4b-ad3d61d3f1e4" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7f896736-82f8-4def-81ea-e3063ff3de37" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7fd53cba-392d-4d13-bc02-f7b6e40c35bd" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80d90c3b-bad0-4097-8635-13a269c314a3" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationServiceTypeDcs_AvailableReservationId",
                table: "AvailableReservationServiceTypeDcs",
                column: "AvailableReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationServiceTypeDcs_ServiceTypeDurationCostId",
                table: "AvailableReservationServiceTypeDcs",
                column: "ServiceTypeDurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_AvailableReservationId",
                table: "BookedReservations",
                column: "AvailableReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_AvailableReservationServiceTypeDCId",
                table: "BookedReservations",
                column: "AvailableReservationServiceTypeDCId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_PatientId",
                table: "BookedReservations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_ServiceTypeId",
                table: "BookedReservations",
                column: "ServiceTypeId");
        }
    }
}
