using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class NewBlogDiagnosisPatientEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Appointment_AppointmentId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_AppointmentId",
                table: "Payment");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6bdb90ef-a318-42f1-8fda-cb714b0b0045" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "afbfb812-6142-45f3-82ad-9d4ea70b6250" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "de4d21de-535e-4ff3-a849-7164c971a6cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bdb90ef-a318-42f1-8fda-cb714b0b0045");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afbfb812-6142-45f3-82ad-9d4ea70b6250");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de4d21de-535e-4ff3-a849-7164c971a6cb");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "AspNetUsers",
                newName: "RegisteredDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCreated",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Appointment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "ActivityType",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4124aeeb-07b9-4466-baab-e910bfdaf26a", 0, null, "bc8d48e6-f1d8-48dc-bf4f-30dc4d46e3cc", "patient@example.com", true, false, null, "patient@EXAMPLE.COM", "PATIENT@PATIENT.COM", "AQAAAAIAAYagAAAAENlHyBcyVbV0LauIrUUnep/pREjhdt199iBYjLY0uac4YKWBRGZwUXZ4/QuMiQNWyA==", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "patient@example.com" },
                    { "81c95449-6ba1-463d-b15f-8e2098972958", 0, null, "600e57fd-8095-4624-a72c-68a16db1a2fb", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL17XIArfzI5DT13qSUQ51QDfzmvlBOSP+ztE/aUGWDWZ4qyCeLGjtGpiqz5Nw0JNQ==", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "admin@example.com" },
                    { "d94ec95c-8841-4897-9588-358f39797e3d", 0, null, "29a90191-da23-48b0-951c-a0f43e90c184", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@PHYSIOTHERAPIST.COM", "AQAAAAIAAYagAAAAEB/MZVoooPiCd8KqxCOc1nwz5MfyTlD2g6KidJJRFj/3ter2cUqrk+shIkWtBXj15A==", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4124aeeb-07b9-4466-baab-e910bfdaf26a" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "81c95449-6ba1-463d-b15f-8e2098972958" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "d94ec95c-8841-4897-9588-358f39797e3d" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PersonId",
                table: "Patient",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonId",
                table: "Employee",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PaymentId",
                table: "Appointment",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisPatient_PatientsId",
                table: "DiagnosisPatient",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AddressId",
                table: "Person",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Payment_PaymentId",
                table: "Appointment",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Person_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                principalTable: "Person",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Payment_PaymentId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Person_PersonId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeType_EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Person_PersonId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient");

            migrationBuilder.DropTable(
                name: "DiagnosisPatient");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Patient_PersonId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_PersonId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_PaymentId",
                table: "Appointment");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4124aeeb-07b9-4466-baab-e910bfdaf26a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "81c95449-6ba1-463d-b15f-8e2098972958" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "d94ec95c-8841-4897-9588-358f39797e3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4124aeeb-07b9-4466-baab-e910bfdaf26a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81c95449-6ba1-463d-b15f-8e2098972958");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d94ec95c-8841-4897-9588-358f39797e3d");

            migrationBuilder.DropColumn(
                name: "DateTimeCreated",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ActivityType");

            migrationBuilder.RenameColumn(
                name: "RegisteredDate",
                table: "AspNetUsers",
                newName: "DateCreated");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "AddressId", "BirthDate", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6bdb90ef-a318-42f1-8fda-cb714b0b0045", 0, false, null, null, "18cba12b-131d-4cdb-9f78-8c71bf57cd25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "patient@example.com", true, false, null, null, "patient@EXAMPLE.COM", "PATIENT@PATIENT.COM", "AQAAAAIAAYagAAAAEEMaKaHboevPWMX68BEhlOVnp6ffOMwJQXgNq88PSreeXuMFgaRuyz3CPF0bUxm4ig==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", null, false, "patient@example.com" },
                    { "afbfb812-6142-45f3-82ad-9d4ea70b6250", 0, false, null, null, "aa47db27-6a67-45c8-ac6c-de24d01a2dfb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "physiotherapist@example.com", true, false, null, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@PHYSIOTHERAPIST.COM", "AQAAAAIAAYagAAAAECqH5L1+XI11K00bdxkoZkGyP8qgpwVYs4XWZm1h9RyrNt82vLYw4nAodChq+vswqQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", null, false, "physiotherapist@example.com" },
                    { "de4d21de-535e-4ff3-a849-7164c971a6cb", 0, false, null, null, "e40ed039-2c74-4e5a-98a9-c191e5cc80fe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, false, null, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPj31FAC487fBEOeXb0BcGkHMRVdfOFFTrXDEj1WnwasLTrQMohzxbEJHks819DwvA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", null, false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6bdb90ef-a318-42f1-8fda-cb714b0b0045" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "afbfb812-6142-45f3-82ad-9d4ea70b6250" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "de4d21de-535e-4ff3-a849-7164c971a6cb" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_AppointmentId",
                table: "Payment",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Appointment_AppointmentId",
                table: "Payment",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
