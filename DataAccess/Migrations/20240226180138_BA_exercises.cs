using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BA_exercises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "13cf3ebf-ad8c-40b5-a998-28d76b6b59d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2830798a-0c57-4af9-b689-94fc98077de2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "496711bf-7b76-4f68-a046-aa738ed82142" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "8118aa16-1002-45b5-809f-d71402cc3876" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a51d0b86-a363-41bf-846e-ca5a8c14bcd0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13cf3ebf-ad8c-40b5-a998-28d76b6b59d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2830798a-0c57-4af9-b689-94fc98077de2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "496711bf-7b76-4f68-a046-aa738ed82142");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8118aa16-1002-45b5-809f-d71402cc3876");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a51d0b86-a363-41bf-846e-ca5a8c14bcd0");

            migrationBuilder.DropColumn(
                name: "CancellationDate",
                table: "BookedAppointments");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "DurationCosts",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "BookedAppointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "bookedAppointmentDetails",
                columns: table => new
                {
                    BookedAppointmentId = table.Column<int>(type: "int", nullable: false),
                    Finished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookedAppointmentDetails", x => x.BookedAppointmentId);
                    table.ForeignKey(
                        name: "FK_bookedAppointmentDetails_BookedAppointments_BookedAppointmentId",
                        column: x => x.BookedAppointmentId,
                        principalTable: "BookedAppointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bA_ExerciseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false),
                    BookedAppointmentId = table.Column<int>(type: "int", nullable: false),
                    PlannedNumberOfRepetitions = table.Column<int>(type: "int", nullable: true),
                    PlannedExpectedNumberOfSets = table.Column<int>(type: "int", nullable: true),
                    PlannedExpectedDurationInMinutes = table.Column<int>(type: "int", nullable: true),
                    PlannedRestAfterExerciseInMinutes = table.Column<int>(type: "int", nullable: true),
                    PlannedRestBetweenSetsInMinutes = table.Column<int>(type: "int", nullable: true),
                    ActualNumberOfRepetitions = table.Column<int>(type: "int", nullable: true),
                    ActualNumberOfSets = table.Column<int>(type: "int", nullable: true),
                    ActualDurationInMinutes = table.Column<int>(type: "int", nullable: true),
                    ActualRestAfterExerciseInMinutes = table.Column<int>(type: "int", nullable: true),
                    ActualRestBetweenSetsInMinutes = table.Column<int>(type: "int", nullable: true),
                    BookedAppointmentDetailBookedAppointmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bA_ExerciseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bA_ExerciseDetails_BookedAppointments_BookedAppointmentId",
                        column: x => x.BookedAppointmentId,
                        principalTable: "BookedAppointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bA_ExerciseDetails_ExerciseTypes_ExerciseTypeId",
                        column: x => x.ExerciseTypeId,
                        principalTable: "ExerciseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bA_ExerciseDetails_bookedAppointmentDetails_BookedAppointmentDetailBookedAppointmentId",
                        column: x => x.BookedAppointmentDetailBookedAppointmentId,
                        principalTable: "bookedAppointmentDetails",
                        principalColumn: "BookedAppointmentId");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d411ebd-58b3-429a-b638-a944ece95ed7", 0, "b0542031-0ebf-4bcd-af1b-b3cc2ebde0a7", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM4hn8wxusGWCuiwJKoV2kpXqce6Q3HstJiq733sojDSveT0lQh0iktSbeCk6Kanrw==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5894db19-0de0-4dc8-8800-ca3b3d9273dd", false, "admin@example.com" },
                    { "59b7e54b-00b1-4d10-b6d7-f557eac4b5e1", 0, "f416c0b6-0345-4f21-9a8b-c0520e6d11cb", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBQEhTEOeoeRt7MKQP860GjohFX19kjZwKVL0yJg3hYpNCKS01cT931dtot940MZ7g==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1d9e420b-377d-4b41-8ef6-37624d409824", false, "admin2@example.com" },
                    { "5ef5c831-03b7-44e9-bf23-a8a01d4b8cc5", 0, "2b4a8698-ed6e-4e6e-bb18-3211afab76a4", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFjWSKBvVXRoTCIIFxkGhBmg5L9Hx+ZVZvYcVnj1WbgRtYoCJJ3GLeoN+RDKzQJmjw==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "74e32fc1-470f-4094-bc3b-81accc3f9055", false, "patient3@example.com" },
                    { "72049b40-7eaa-463c-a39e-f9e613c34922", 0, "cadd6ae7-ab15-40b9-bf18-53092dc6c27e", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK9xJlSACXkxAuh7VhjI8KlL1DxmxJ1MDPSIOSsgWT8//lezFaDhPDFgoH1okPnrvQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "35fd97c8-25da-470d-8691-ed7629adc876", false, "patient1@example.com" },
                    { "7b976029-fa41-4bac-a5e0-3e21cc7aebd9", 0, "97d74bbf-ab41-4e6e-94b6-c2d9d04de90d", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJnxC4iZLmTDNxTElAgEWYWbM0qUtBSTLLrIflo68HlniE2J4OQxPdG92aQI7C/eJA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ea150ba1-b87a-4f4c-9739-c3f018f0749d", false, "patient2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2d411ebd-58b3-429a-b638-a944ece95ed7" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "59b7e54b-00b1-4d10-b6d7-f557eac4b5e1" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5ef5c831-03b7-44e9-bf23-a8a01d4b8cc5" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "72049b40-7eaa-463c-a39e-f9e613c34922" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7b976029-fa41-4bac-a5e0-3e21cc7aebd9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bA_ExerciseDetails_BookedAppointmentDetailBookedAppointmentId",
                table: "bA_ExerciseDetails",
                column: "BookedAppointmentDetailBookedAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_bA_ExerciseDetails_BookedAppointmentId",
                table: "bA_ExerciseDetails",
                column: "BookedAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_bA_ExerciseDetails_ExerciseTypeId",
                table: "bA_ExerciseDetails",
                column: "ExerciseTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bA_ExerciseDetails");

            migrationBuilder.DropTable(
                name: "ExerciseTypes");

            migrationBuilder.DropTable(
                name: "bookedAppointmentDetails");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2d411ebd-58b3-429a-b638-a944ece95ed7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "59b7e54b-00b1-4d10-b6d7-f557eac4b5e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5ef5c831-03b7-44e9-bf23-a8a01d4b8cc5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "72049b40-7eaa-463c-a39e-f9e613c34922" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7b976029-fa41-4bac-a5e0-3e21cc7aebd9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d411ebd-58b3-429a-b638-a944ece95ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59b7e54b-00b1-4d10-b6d7-f557eac4b5e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ef5c831-03b7-44e9-bf23-a8a01d4b8cc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72049b40-7eaa-463c-a39e-f9e613c34922");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b976029-fa41-4bac-a5e0-3e21cc7aebd9");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "BookedAppointments");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "DurationCosts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CancellationDate",
                table: "BookedAppointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13cf3ebf-ad8c-40b5-a998-28d76b6b59d0", 0, "ee92c9fd-c828-4e37-b73a-e52dfea05be3", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHJQ6QwVsQ/c0/Gmn7N+h36UVFfl4QCnl89ZHjHgs+4jhj3/PCrQe8b9lVM0tpJM5A==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "23eae6d8-5a87-4628-a254-f3651238b2c3", false, "patient2@example.com" },
                    { "2830798a-0c57-4af9-b689-94fc98077de2", 0, "00e47b02-d438-48a2-a306-13be5d3bafaf", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJRFmDYmHFMi0Vm8vmlfvd//tuZTFA1/EMDgNahd0VQOY6EnM/NhLub2wNAaT7xvHw==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42d49b66-2109-4151-8bbc-94cba51d0f5a", false, "admin@example.com" },
                    { "496711bf-7b76-4f68-a046-aa738ed82142", 0, "fc86610d-8d20-4e9b-8e6c-de99c8a4d695", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENztMeKYGeIvhoNyUSbd68X4+fXNM928cszACXIpf89In7tEQPSwvTF6GV0yd9FkfQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1d36c1b7-1d7c-49a4-a554-9a5c53e19810", false, "patient1@example.com" },
                    { "8118aa16-1002-45b5-809f-d71402cc3876", 0, "b2d5b2cb-57d8-40c0-a9e2-1283465c1ccd", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEVT3Hu8uggTaQf/iPz32jIUkM0LNPK7DFswzjloc+BSpo3aJS0iOYG1YgJvXFLuKw==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cd68ac29-2872-4d30-8a65-5db94a0e8bba", false, "patient3@example.com" },
                    { "a51d0b86-a363-41bf-846e-ca5a8c14bcd0", 0, "39f859e2-1d99-4f37-8c21-2a0dcad49c3d", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEILt6GOcYu2OscsKtxXRtZiffqM6cR+ljDVBIQR2F3KiRodeu+Z6XisNnLrCpVbCtA==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ec93554a-ffee-41e5-812b-ea18a120ca67", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "13cf3ebf-ad8c-40b5-a998-28d76b6b59d0" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2830798a-0c57-4af9-b689-94fc98077de2" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "496711bf-7b76-4f68-a046-aa738ed82142" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "8118aa16-1002-45b5-809f-d71402cc3876" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a51d0b86-a363-41bf-846e-ca5a8c14bcd0" }
                });
        }
    }
}
