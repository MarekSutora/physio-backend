using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class patientNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointmentDetails_Appointments_AppointmentId",
                table: "appointmentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_ServiceTypes_ServiceTypeId",
                table: "BookedAppointments");

            migrationBuilder.DropIndex(
                name: "IX_BookedAppointments_ServiceTypeId",
                table: "BookedAppointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointmentDetails",
                table: "appointmentDetails");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "25f8675b-7e11-4a9a-9fea-eb79f25962ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5cbbec44-720a-4736-98e9-1c1950aa61b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "af499760-047d-4171-8006-2d5c4abc7bee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d282e31b-8ee9-42d4-8a64-03356ef30d5f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f8675b-7e11-4a9a-9fea-eb79f25962ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cbbec44-720a-4736-98e9-1c1950aa61b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af499760-047d-4171-8006-2d5c4abc7bee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d282e31b-8ee9-42d4-8a64-03356ef30d5f");

            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "BookedAppointments");

            migrationBuilder.RenameTable(
                name: "appointmentDetails",
                newName: "AppointmentDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails",
                column: "AppointmentId");

            migrationBuilder.CreateTable(
                name: "PatientNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientNotes_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1815c5dc-afdb-46b0-8441-5fdb8c2be512", 0, "68eb3c3a-a56b-4dcf-a176-35f16ce260b8", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFvDUARl9IyCYFoRLY6cRRt9jNKUmWqLHanXkn32V0X2qu4Rp28ePS5EOH9tGBTa9Q==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ca8703f8-76e1-4f2d-95b3-8126335b2897", false, "admin2@example.com" },
                    { "8d90d26f-e8cf-4c83-9109-2ac37ab03829", 0, "47b7fb04-a23b-441c-94a1-af23765378c0", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIhWA2KP0oqhK/OBDc2hhi+YmWnaZnz4/4m2EOsAGDtG4s3KRvyk1zqI2l77WFNgNg==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd42e3bd-a8ca-4d7e-8dd7-9ce14074992a", false, "admin@example.com" },
                    { "900825bf-be88-44c8-9afb-8d58b0eaada5", 0, "14ca8d9e-b305-44ad-a24a-c78a2766868c", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJE0MYN8T1TEnCvX0SSzK+IaUzwlI5Go87b6798jA4uGnm7H2M4EU2YR2vGZGg4yYg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14bc0e90-d3e4-427b-b2cf-ade0fef36795", false, "patient1@example.com" },
                    { "9aa8d7db-0b97-429e-b216-3adaa32da195", 0, "85d4ba2a-a178-44a4-97fe-9f962113f305", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH8yjQELwrnBREBg6f0cjqXbJfjwVSAq+3Kwd/TXY7t/aILunYdFkmjuioplmOsF/g==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aa231845-d9ba-4db3-8e15-05cfe78525eb", false, "patient2@example.com" },
                    { "b3554944-3d99-48f4-a929-d19b4855e5fd", 0, "8ccfcd92-a810-43c7-99d7-49e475ff436f", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPbVrjByOHPjpS42JIohgHVwA6mbig4RQ9UCmPmPmB8I/8GvfyGuY9M778/FRyK7AQ==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "186a032b-9b5a-43e2-8fbc-9d1a1ec8a917", false, "patient3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "1815c5dc-afdb-46b0-8441-5fdb8c2be512" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "8d90d26f-e8cf-4c83-9109-2ac37ab03829" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "900825bf-be88-44c8-9afb-8d58b0eaada5" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "9aa8d7db-0b97-429e-b216-3adaa32da195" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "b3554944-3d99-48f4-a929-d19b4855e5fd" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientNotes_PatientId",
                table: "PatientNotes",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentDetails_Appointments_AppointmentId",
                table: "AppointmentDetails",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentExerciseDetails_AppointmentDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentDetailAppointmentId",
                principalTable: "AppointmentDetails",
                principalColumn: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentDetails_Appointments_AppointmentId",
                table: "AppointmentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentExerciseDetails_AppointmentDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropTable(
                name: "PatientNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "1815c5dc-afdb-46b0-8441-5fdb8c2be512" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "8d90d26f-e8cf-4c83-9109-2ac37ab03829" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "900825bf-be88-44c8-9afb-8d58b0eaada5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "9aa8d7db-0b97-429e-b216-3adaa32da195" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "b3554944-3d99-48f4-a929-d19b4855e5fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1815c5dc-afdb-46b0-8441-5fdb8c2be512");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d90d26f-e8cf-4c83-9109-2ac37ab03829");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900825bf-be88-44c8-9afb-8d58b0eaada5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9aa8d7db-0b97-429e-b216-3adaa32da195");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3554944-3d99-48f4-a929-d19b4855e5fd");

            migrationBuilder.RenameTable(
                name: "AppointmentDetails",
                newName: "appointmentDetails");

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeId",
                table: "BookedAppointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointmentDetails",
                table: "appointmentDetails",
                column: "AppointmentId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25f8675b-7e11-4a9a-9fea-eb79f25962ef", 0, "425ba3e2-a49b-4f33-8459-ba923122a749", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG9on9/zkg47IVxOK/PBtTpjFZlLholOq32PcDg19Y1VDB5bO0UTkr7dgIiNnoBBKg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "53bc1cc2-03b5-48fb-8452-42c3e647a236", false, "admin2@example.com" },
                    { "5cbbec44-720a-4736-98e9-1c1950aa61b8", 0, "a5fd4fa3-4a0e-4a6d-b77c-3ebcd4f2745b", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMM0T52Aehwbo4DfZFdefm2FvYjUWktFikNxY5cEk8n2wvR9IzhVY+aiyJuhNszuVQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f0dcf257-4497-4e83-b98c-cb9696af3d9f", false, "patient1@example.com" },
                    { "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0", 0, "7784bcc9-0f95-402b-b0eb-1daae74b43da", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELYqLanCYYLW9qHuO74ySOSvR4tfK9NooFLChPfnxR4xvPSKdfUqTUOlHuNd016ARQ==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b109a60d-245c-4d92-ba43-e93f27adc707", false, "admin@example.com" },
                    { "af499760-047d-4171-8006-2d5c4abc7bee", 0, "f2d2e3a0-344a-42b7-84cf-65ab2bebda63", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKBhFJT22jdDK6H4w8haaBGuCr56FmRKZLHIklGzPAdzgN5b5Zm2iJsOIx5q0GXPvw==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9247be96-a567-4e1f-9b9e-6dd627bc8432", false, "patient2@example.com" },
                    { "d282e31b-8ee9-42d4-8a64-03356ef30d5f", 0, "dae6acc5-d9ad-4c22-94ce-dcd62e0f1f18", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEYrIkKr0vosidgTqHAQDKHJhRG8dNiEJD9fxrh25E5d3LwdBhswTW3r/ViSjNLK3w==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd23095b-b8ea-4483-9ad4-63871918a19e", false, "patient3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "25f8675b-7e11-4a9a-9fea-eb79f25962ef" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5cbbec44-720a-4736-98e9-1c1950aa61b8" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "af499760-047d-4171-8006-2d5c4abc7bee" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d282e31b-8ee9-42d4-8a64-03356ef30d5f" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_ServiceTypeId",
                table: "BookedAppointments",
                column: "ServiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointmentDetails_Appointments_AppointmentId",
                table: "appointmentDetails",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentDetailAppointmentId",
                principalTable: "appointmentDetails",
                principalColumn: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_ServiceTypes_ServiceTypeId",
                table: "BookedAppointments",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id");
        }
    }
}
