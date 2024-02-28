using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AppDetailUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bA_ExerciseDetails_Appointments_AppointmentId",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_bA_ExerciseDetails_ExerciseTypes_ExerciseTypeId",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_bA_ExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bA_ExerciseDetails",
                table: "bA_ExerciseDetails");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07634103-20d7-409a-8257-4f7738147c81" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "28970d98-8ff4-4965-af2f-2777617a175b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "ca95dc85-2ad7-4ab2-aa76-1bc795c3ef04" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d23b34a0-d320-4858-b8de-22c6654b6584" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "dbb9b7d3-6b9a-4329-92f0-fba51af680c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07634103-20d7-409a-8257-4f7738147c81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28970d98-8ff4-4965-af2f-2777617a175b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca95dc85-2ad7-4ab2-aa76-1bc795c3ef04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d23b34a0-d320-4858-b8de-22c6654b6584");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbb9b7d3-6b9a-4329-92f0-fba51af680c6");

            migrationBuilder.DropColumn(
                name: "ActualDurationInMinutes",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropColumn(
                name: "ActualNumberOfRepetitions",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropColumn(
                name: "ActualNumberOfSets",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropColumn(
                name: "ActualRestAfterExerciseInMinutes",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropColumn(
                name: "ActualRestBetweenSetsInMinutes",
                table: "bA_ExerciseDetails");

            migrationBuilder.RenameTable(
                name: "bA_ExerciseDetails",
                newName: "AppointmentExerciseDetails");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "appointmentDetails",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "PlannedRestBetweenSetsInMinutes",
                table: "AppointmentExerciseDetails",
                newName: "RestBetweenSetsInMinutes");

            migrationBuilder.RenameColumn(
                name: "PlannedRestAfterExerciseInMinutes",
                table: "AppointmentExerciseDetails",
                newName: "RestAfterExerciseInMinutes");

            migrationBuilder.RenameColumn(
                name: "PlannedNumberOfRepetitions",
                table: "AppointmentExerciseDetails",
                newName: "NumberOfRepetitions");

            migrationBuilder.RenameColumn(
                name: "PlannedExpectedNumberOfSets",
                table: "AppointmentExerciseDetails",
                newName: "ExpectedNumberOfSets");

            migrationBuilder.RenameColumn(
                name: "PlannedExpectedDurationInMinutes",
                table: "AppointmentExerciseDetails",
                newName: "ExpectedDurationInMinutes");

            migrationBuilder.RenameIndex(
                name: "IX_bA_ExerciseDetails_ExerciseTypeId",
                table: "AppointmentExerciseDetails",
                newName: "IX_AppointmentExerciseDetails_ExerciseTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_bA_ExerciseDetails_AppointmentId",
                table: "AppointmentExerciseDetails",
                newName: "IX_AppointmentExerciseDetails_AppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_bA_ExerciseDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails",
                newName: "IX_AppointmentExerciseDetails_AppointmentDetailAppointmentId");

            migrationBuilder.AddColumn<bool>(
                name: "SuccessfulyPerformed",
                table: "AppointmentExerciseDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "AppointmentExerciseDetails",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentExerciseDetails",
                table: "AppointmentExerciseDetails",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2cd7622a-6718-4cee-bbc2-cc91f7d2b868", 0, "b2c974a9-eea2-41d7-81ec-572d8a84a400", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHBmFmjlNL7KXnyH2dsE/1n8RnmksKK6wV+IvP/gmHMg/ciwanEaNI5avk9Jh9CkgA==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c3683945-5d6d-457c-a1b6-6bc40def1f21", false, "admin2@example.com" },
                    { "32b8401c-3b68-41ba-b58c-211f79ceb7f0", 0, "30884ad5-bb92-42bd-bb51-05b36266de24", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH97Y7OJeyk5P+uwHjycxbxsDAL5n9gsGvaQaBR1EqoYwgDSuyG8J+J/0t8n1ava3A==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6ca24992-17ba-44af-92f5-364818219c1e", false, "admin@example.com" },
                    { "42dfdd7e-8749-4ccc-8648-ff02321e3d45", 0, "f19d00b2-8680-40d6-982f-d70a996ecc42", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAED9NWfhDlS1S/5ue2New/pN3ZvctSttlpT7RvDvbaopvmEIFwHFEKd/zo7ys5Rh9Hg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9e844f8b-8827-4641-82a7-07e38fa90b96", false, "patient1@example.com" },
                    { "57004464-20fb-42c0-96ff-cf24b42e2cd1", 0, "9f46e286-4459-48c5-942a-7cc9270e71b3", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO0+Uhg0gHa6Stt0M+hF1L40hGzQpkGwyCWTaR18lK0jBtxCdpeySmZDS62zlgWEKA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ceff032f-8749-4ec2-8609-df00fc123102", false, "patient2@example.com" },
                    { "5dfa3417-ec18-4a1c-9ec7-1a7295155602", 0, "228c75c4-f8aa-4642-ae9b-261b4414ee22", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHm1HjL0cZ5w315DTLd/L7wmbAX1zCkvOEu+RgdFTGTsYWfcsFanyzK/0ZJmO0N3ag==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "73a61742-8dd6-4f5f-9dc1-546fc8a476bf", false, "patient3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2cd7622a-6718-4cee-bbc2-cc91f7d2b868" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "32b8401c-3b68-41ba-b58c-211f79ceb7f0" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "42dfdd7e-8749-4ccc-8648-ff02321e3d45" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "57004464-20fb-42c0-96ff-cf24b42e2cd1" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5dfa3417-ec18-4a1c-9ec7-1a7295155602" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentExerciseDetails_Appointments_AppointmentId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentExerciseDetails_ExerciseTypes_ExerciseTypeId",
                table: "AppointmentExerciseDetails",
                column: "ExerciseTypeId",
                principalTable: "ExerciseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentDetailAppointmentId",
                principalTable: "appointmentDetails",
                principalColumn: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentExerciseDetails_Appointments_AppointmentId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentExerciseDetails_ExerciseTypes_ExerciseTypeId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentExerciseDetails",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2cd7622a-6718-4cee-bbc2-cc91f7d2b868" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "32b8401c-3b68-41ba-b58c-211f79ceb7f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "42dfdd7e-8749-4ccc-8648-ff02321e3d45" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "57004464-20fb-42c0-96ff-cf24b42e2cd1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5dfa3417-ec18-4a1c-9ec7-1a7295155602" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd7622a-6718-4cee-bbc2-cc91f7d2b868");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32b8401c-3b68-41ba-b58c-211f79ceb7f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42dfdd7e-8749-4ccc-8648-ff02321e3d45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57004464-20fb-42c0-96ff-cf24b42e2cd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dfa3417-ec18-4a1c-9ec7-1a7295155602");

            migrationBuilder.DropColumn(
                name: "SuccessfulyPerformed",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AppointmentExerciseDetails");

            migrationBuilder.RenameTable(
                name: "AppointmentExerciseDetails",
                newName: "bA_ExerciseDetails");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "appointmentDetails",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "RestBetweenSetsInMinutes",
                table: "bA_ExerciseDetails",
                newName: "PlannedRestBetweenSetsInMinutes");

            migrationBuilder.RenameColumn(
                name: "RestAfterExerciseInMinutes",
                table: "bA_ExerciseDetails",
                newName: "PlannedRestAfterExerciseInMinutes");

            migrationBuilder.RenameColumn(
                name: "NumberOfRepetitions",
                table: "bA_ExerciseDetails",
                newName: "PlannedNumberOfRepetitions");

            migrationBuilder.RenameColumn(
                name: "ExpectedNumberOfSets",
                table: "bA_ExerciseDetails",
                newName: "PlannedExpectedNumberOfSets");

            migrationBuilder.RenameColumn(
                name: "ExpectedDurationInMinutes",
                table: "bA_ExerciseDetails",
                newName: "PlannedExpectedDurationInMinutes");

            migrationBuilder.RenameIndex(
                name: "IX_AppointmentExerciseDetails_ExerciseTypeId",
                table: "bA_ExerciseDetails",
                newName: "IX_bA_ExerciseDetails_ExerciseTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AppointmentExerciseDetails_AppointmentId",
                table: "bA_ExerciseDetails",
                newName: "IX_bA_ExerciseDetails_AppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppointmentExerciseDetails_AppointmentDetailAppointmentId",
                table: "bA_ExerciseDetails",
                newName: "IX_bA_ExerciseDetails_AppointmentDetailAppointmentId");

            migrationBuilder.AddColumn<int>(
                name: "ActualDurationInMinutes",
                table: "bA_ExerciseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActualNumberOfRepetitions",
                table: "bA_ExerciseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActualNumberOfSets",
                table: "bA_ExerciseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActualRestAfterExerciseInMinutes",
                table: "bA_ExerciseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActualRestBetweenSetsInMinutes",
                table: "bA_ExerciseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_bA_ExerciseDetails",
                table: "bA_ExerciseDetails",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07634103-20d7-409a-8257-4f7738147c81", 0, "626a75a3-0abc-4cdd-9966-10847c355d1c", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOYAYdUx7JLC3OZM/fzkvcIHsaTfROR8609e9ck0LZSitJ9p8m1P0xQvWuMnqFEgSg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b17f10e5-55af-4f21-9b4f-0ec8ba81c63b", false, "patient1@example.com" },
                    { "28970d98-8ff4-4965-af2f-2777617a175b", 0, "29dee37d-d190-4cdc-a7c3-6724e78aa520", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKRUFctt9T/+0oXrGAk/K6EAV2Us0yEewB2Hgf7DB+oD1LHePqgCIG//LIwuZmLkXg==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ca5061e8-af41-46d1-8b0a-1146bd2ffad1", false, "patient2@example.com" },
                    { "ca95dc85-2ad7-4ab2-aa76-1bc795c3ef04", 0, "f2e0b2e8-fbfd-46ab-9838-64579295aff6", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECg+5wRxrSbIVwG51rLvee3MO2kRQZccXm1xd3iNYntSm8tA7y2IKSHQb9zpr0pDLQ==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "032ae8e3-28e9-4249-81fb-8975892e5884", false, "admin@example.com" },
                    { "d23b34a0-d320-4858-b8de-22c6654b6584", 0, "ab992993-8c41-4b15-84ea-062b90db072c", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJJP2z3ZmdEjVomyb7+JCrPKSWgMRk9bMAkLgoPthqMYE0thmEJPAvFWpdgpKkw1kg==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5ed2a188-1981-4652-aa59-d900f50dfdd2", false, "patient3@example.com" },
                    { "dbb9b7d3-6b9a-4329-92f0-fba51af680c6", 0, "7a306e0f-33bd-4ea8-84fb-f0e7542b1922", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDBWVQRmT8RbidOXFJyezzCV9x6hwHtlpU9Z6Wlxa4sDUn+Z/exOvG8sRrj0Dyp8vg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b54a0cf4-ff04-478d-aa42-fc69b104348e", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07634103-20d7-409a-8257-4f7738147c81" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "28970d98-8ff4-4965-af2f-2777617a175b" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "ca95dc85-2ad7-4ab2-aa76-1bc795c3ef04" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d23b34a0-d320-4858-b8de-22c6654b6584" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "dbb9b7d3-6b9a-4329-92f0-fba51af680c6" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_bA_ExerciseDetails_Appointments_AppointmentId",
                table: "bA_ExerciseDetails",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bA_ExerciseDetails_ExerciseTypes_ExerciseTypeId",
                table: "bA_ExerciseDetails",
                column: "ExerciseTypeId",
                principalTable: "ExerciseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bA_ExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "bA_ExerciseDetails",
                column: "AppointmentDetailAppointmentId",
                principalTable: "appointmentDetails",
                principalColumn: "AppointmentId");
        }
    }
}
