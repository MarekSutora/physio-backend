using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class appDetailChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bA_ExerciseDetails_BookedAppointments_BookedAppointmentId",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_bA_ExerciseDetails_bookedAppointmentDetails_BookedAppointmentDetailBookedAppointmentId",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropTable(
                name: "bookedAppointmentDetails");

            migrationBuilder.DropIndex(
                name: "IX_bA_ExerciseDetails_BookedAppointmentId",
                table: "bA_ExerciseDetails");

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

            migrationBuilder.RenameColumn(
                name: "BookedAppointmentId",
                table: "bA_ExerciseDetails",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "BookedAppointmentDetailBookedAppointmentId",
                table: "bA_ExerciseDetails",
                newName: "AppointmentDetailAppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_bA_ExerciseDetails_BookedAppointmentDetailBookedAppointmentId",
                table: "bA_ExerciseDetails",
                newName: "IX_bA_ExerciseDetails_AppointmentDetailAppointmentId");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "bA_ExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "appointmentDetails",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointmentDetails", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_appointmentDetails_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_bA_ExerciseDetails_AppointmentId",
                table: "bA_ExerciseDetails",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_bA_ExerciseDetails_Appointments_AppointmentId",
                table: "bA_ExerciseDetails",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bA_ExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "bA_ExerciseDetails",
                column: "AppointmentDetailAppointmentId",
                principalTable: "appointmentDetails",
                principalColumn: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bA_ExerciseDetails_Appointments_AppointmentId",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_bA_ExerciseDetails_appointmentDetails_AppointmentDetailAppointmentId",
                table: "bA_ExerciseDetails");

            migrationBuilder.DropTable(
                name: "appointmentDetails");

            migrationBuilder.DropIndex(
                name: "IX_bA_ExerciseDetails_AppointmentId",
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
                name: "AppointmentId",
                table: "bA_ExerciseDetails");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "bA_ExerciseDetails",
                newName: "BookedAppointmentId");

            migrationBuilder.RenameColumn(
                name: "AppointmentDetailAppointmentId",
                table: "bA_ExerciseDetails",
                newName: "BookedAppointmentDetailBookedAppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_bA_ExerciseDetails_AppointmentDetailAppointmentId",
                table: "bA_ExerciseDetails",
                newName: "IX_bA_ExerciseDetails_BookedAppointmentDetailBookedAppointmentId");

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
                name: "IX_bA_ExerciseDetails_BookedAppointmentId",
                table: "bA_ExerciseDetails",
                column: "BookedAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_bA_ExerciseDetails_BookedAppointments_BookedAppointmentId",
                table: "bA_ExerciseDetails",
                column: "BookedAppointmentId",
                principalTable: "BookedAppointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bA_ExerciseDetails_bookedAppointmentDetails_BookedAppointmentDetailBookedAppointmentId",
                table: "bA_ExerciseDetails",
                column: "BookedAppointmentDetailBookedAppointmentId",
                principalTable: "bookedAppointmentDetails",
                principalColumn: "BookedAppointmentId");
        }
    }
}
