using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class ReservationEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_ActivityType_ActivityTypeId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Person_PersonId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "ActivityType");

            migrationBuilder.DropTable(
                name: "DiagnosisPatient");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_PersonId",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "63eaca5d-e284-45f7-8738-c3160ca53b93" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c3235cea-19a5-4a0d-8f21-72f8d225eceb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63eaca5d-e284-45f7-8738-c3160ca53b93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3235cea-19a5-4a0d-8f21-72f8d225eceb");

            migrationBuilder.DropColumn(
                name: "EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Appointment",
                newName: "AppointmentDoneDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentCreatedDate",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AvailableAppointmentId",
                table: "Appointment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    HexColor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvailableAppointment",
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
                    table.PrimaryKey("PK_AvailableAppointment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnosis",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnosis", x => new { x.DiagnosisId, x.PatientId });
                    table.ForeignKey(
                        name: "FK_PatientDiagnosis_Diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiagnosis_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvailableAppointmentActivityType",
                columns: table => new
                {
                    AvailableAppointmentId = table.Column<int>(type: "int", nullable: false),
                    ActivityTypeId = table.Column<int>(type: "int", nullable: false)
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
                table: "ActivityType",
                columns: new[] { "Id", "Description", "Duration", "HexColor", "Name", "NormalCost" },
                values: new object[,]
                {
                    { 1, "Individuálna konzultácia", 30, "#007bff", "Konzultácia", 60m },
                    { 2, "Terapeutická fyzioterapia", 60, "#28a745", "Fyzioterapia", 50m },
                    { 3, "Relaxačná masáž", 45, "#dc3545", "Masáž", 40m },
                    { 4, "Rehabilitačné cvičenia", 60, "#ffc107", "Rehabilitácia", 40m }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "545BBA82-840A-4446-BFF6-64834A8DA52F",
                column: "Name",
                value: "Physiotherapist");

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
                name: "IX_Appointment_AvailableAppointmentId",
                table: "Appointment",
                column: "AvailableAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableAppointmentActivityType_AvailableAppointmentId",
                table: "AvailableAppointmentActivityType",
                column: "AvailableAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnosis_PatientId",
                table: "PatientDiagnosis",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_ActivityType_ActivityTypeId",
                table: "Appointment",
                column: "ActivityTypeId",
                principalTable: "ActivityType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AvailableAppointment_AvailableAppointmentId",
                table: "Appointment",
                column: "AvailableAppointmentId",
                principalTable: "AvailableAppointment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_ActivityType_ActivityTypeId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AvailableAppointment_AvailableAppointmentId",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "AvailableAppointmentActivityType");

            migrationBuilder.DropTable(
                name: "PatientDiagnosis");

            migrationBuilder.DropTable(
                name: "ActivityType");

            migrationBuilder.DropTable(
                name: "AvailableAppointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_AvailableAppointmentId",
                table: "Appointment");

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

            migrationBuilder.DropColumn(
                name: "AppointmentCreatedDate",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AvailableAppointmentId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "AppointmentDoneDate",
                table: "Appointment",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeTypeId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisPatient",
                columns: table => new
                {
                    DiagnosissId = table.Column<int>(type: "int", nullable: false),
                    PatientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisPatient", x => new { x.DiagnosissId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_DiagnosisPatient_Diagnosis_DiagnosissId",
                        column: x => x.DiagnosissId,
                        principalTable: "Diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisPatient_Patient_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "545BBA82-840A-4446-BFF6-64834A8DA52F",
                column: "Name",
                value: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63eaca5d-e284-45f7-8738-c3160ca53b93", 0, null, "464c747f-d7c7-48ff-af61-54ba61f7234a", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMBxvdExGhG02K+aflF20xl/POcWrZaSYZzM4Qsj4mhxqxMQ6i0DLw0NqxfQRLUMaQ==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5c665ee-1f3d-47f0-877a-8a56cf7f130c", false, "physiotherapist@example.com" },
                    { "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf", 0, null, "e669b558-518b-409a-ac03-d7421d5a9779", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEAJjmIZM7m+rC8ahd7auW4QZ+J6pZtH3AMzxPzs9CguHHSE+14AzcB2qaJktXNduA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1e567342-29b1-4408-82ba-2f64011a7efc", false, "admin@example.com" },
                    { "c3235cea-19a5-4a0d-8f21-72f8d225eceb", 0, null, "cbb9882e-91a2-4b74-a2e2-596005bdbd37", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIemm7UqN/vvA1/z2PFZtg7eXR9ssXYvoOVQdF5+i3Q/BlwPm8JbzqJr5/tRRvz82w==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "061a5b80-6bdd-42aa-90cd-5e17c2cab099", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "63eaca5d-e284-45f7-8738-c3160ca53b93" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c3235cea-19a5-4a0d-8f21-72f8d225eceb" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonId",
                table: "Employee",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisPatient_PatientsId",
                table: "DiagnosisPatient",
                column: "PatientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_ActivityType_ActivityTypeId",
                table: "Appointment",
                column: "ActivityTypeId",
                principalTable: "ActivityType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId",
                principalTable: "EmployeeType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Person_PersonId",
                table: "Employee",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
