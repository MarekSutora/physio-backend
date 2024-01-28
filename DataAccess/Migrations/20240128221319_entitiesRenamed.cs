using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class entitiesRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "AvailableAppointmentActivityType");

            migrationBuilder.DropTable(
                name: "AvailableAppointment");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "cd587c87-3bac-45e8-90ed-26648463ee1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "d241185c-188e-46fc-a27e-f3b473d63d66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "ee45c805-addf-467b-a6e2-7cb95b82aece" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd587c87-3bac-45e8-90ed-26648463ee1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d241185c-188e-46fc-a27e-f3b473d63d66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee45c805-addf-467b-a6e2-7cb95b82aece");

            migrationBuilder.CreateTable(
                name: "AvailableReservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ReservedAmount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableReservation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvailableReservationActivityType",
                columns: table => new
                {
                    AvailableReservationId = table.Column<int>(type: "int", nullable: false),
                    ActivityTypeId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationDoneDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableReservationId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    ActivityTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_AvailableReservation_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });

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
                table: "AvailableReservation",
                columns: new[] { "Id", "Capacity", "Date", "ReservedAmount" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 4, new DateTime(2024, 1, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 4, new DateTime(2024, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 4, new DateTime(2024, 1, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 4, new DateTime(2024, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0 }
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

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationActivityType_AvailableReservationId",
                table: "AvailableReservationActivityType",
                column: "AvailableReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ActivityTypeId",
                table: "Reservation",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_AvailableReservationId",
                table: "Reservation",
                column: "AvailableReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PatientId",
                table: "Reservation",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PaymentId",
                table: "Reservation",
                column: "PaymentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailableReservationActivityType");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "AvailableReservation");

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

            migrationBuilder.CreateTable(
                name: "AvailableAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservedAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableAppointment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityTypeId = table.Column<int>(type: "int", nullable: true),
                    AvailableAppointmentId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    AppointmentCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentDoneDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_AvailableAppointment_AvailableAppointmentId",
                        column: x => x.AvailableAppointmentId,
                        principalTable: "AvailableAppointment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AvailableAppointmentActivityType",
                columns: table => new
                {
                    ActivityTypeId = table.Column<int>(type: "int", nullable: false),
                    AvailableAppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableAppointmentActivityType", x => new { x.ActivityTypeId, x.AvailableAppointmentId });
                    table.ForeignKey(
                        name: "FK_AvailableAppointmentActivityType_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableAppointmentActivityType_AvailableAppointment_AvailableAppointmentId",
                        column: x => x.AvailableAppointmentId,
                        principalTable: "AvailableAppointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cd587c87-3bac-45e8-90ed-26648463ee1c", 0, null, "db6a65b5-c4f9-4900-a191-11bc27285180", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMpCj6dbtmkDofNgQV1Jih+yUuObuw/hwdl1Eh8sts/AsNXDeqmFZ6l/SJv92G1pIA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "64558f53-b4de-4b43-a20e-7746435e453c", false, "admin@example.com" },
                    { "d241185c-188e-46fc-a27e-f3b473d63d66", 0, null, "41d86e24-0ce4-4826-8861-8ea2813bc192", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAELyU1TkQFZlXO5wJOxI+/SpXEYrC+IcWSH815TWEEKQDhVPA8lgfp3q48zWIqSsylQ==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7273d008-6993-4c09-afe2-b68a15389743", false, "physiotherapist@example.com" },
                    { "ee45c805-addf-467b-a6e2-7cb95b82aece", 0, null, "f859d0ca-9bf9-4f8e-8a1c-80fc6d89bf4a", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAECtzCjyxvCV7gzTlG2WlD1yXSxdQunWmoEFAIEdpGYdwVOyGYKlBPgTZPEPwQZXilg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3baa0212-1b9c-4630-91dd-f83702107739", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AvailableAppointment",
                columns: new[] { "Id", "Capacity", "Date", "ReservedAmount" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 4, new DateTime(2024, 1, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 4, new DateTime(2024, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 4, new DateTime(2024, 1, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 4, new DateTime(2024, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "cd587c87-3bac-45e8-90ed-26648463ee1c" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "d241185c-188e-46fc-a27e-f3b473d63d66" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "ee45c805-addf-467b-a6e2-7cb95b82aece" }
                });

            migrationBuilder.InsertData(
                table: "AvailableAppointmentActivityType",
                columns: new[] { "ActivityTypeId", "AvailableAppointmentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ActivityTypeId",
                table: "Appointment",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_AvailableAppointmentId",
                table: "Appointment",
                column: "AvailableAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientId",
                table: "Appointment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PaymentId",
                table: "Appointment",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableAppointmentActivityType_AvailableAppointmentId",
                table: "AvailableAppointmentActivityType",
                column: "AvailableAppointmentId");
        }
    }
}
