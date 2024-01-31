using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PersonRelationshipChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_Patient_PatientId",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Patient_PatientId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Patient_PersonId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "a5d9a70f-c8fa-4e1d-8d93-c46afa657f9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a737762e-b7b3-4333-ad6a-47684bd2d01d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "ef67c72c-c548-41ca-af20-8ddab55acfbe" });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 3 });

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
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5d9a70f-c8fa-4e1d-8d93-c46afa657f9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a737762e-b7b3-4333-ad6a-47684bd2d01d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef67c72c-c548-41ca-af20-8ddab55acfbe");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Patient");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "PersonId");

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
                    { 1, 2 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 15 },
                    { 1, 17 },
                    { 2, 8 },
                    { 2, 13 },
                    { 2, 15 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 12 },
                    { 3, 13 },
                    { 4, 4 },
                    { 4, 10 },
                    { 4, 11 }
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
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_Patient_PatientId",
                table: "PatientDiagnosis",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Patient_PatientId",
                table: "Reservation",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_Patient_PatientId",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Patient_PatientId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonId",
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
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 1, 12 });

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
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 2, 15 });

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
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "AvailableReservationActivityType",
                keyColumns: new[] { "ActivityTypeId", "AvailableReservationId" },
                keyValues: new object[] { 4, 11 });

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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Patient",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a5d9a70f-c8fa-4e1d-8d93-c46afa657f9b", 0, null, "f6dcc418-3f66-42e4-89b2-7a816876b560", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOG6DAuwyjWjEidVSiak/IEZ2IUf7oULwKikRjJitbefqiK+huPXPUaGIRlYTvTXPw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2c1387c9-458e-4e17-a4ec-545bbe82c162", false, "patient@example.com" },
                    { "a737762e-b7b3-4333-ad6a-47684bd2d01d", 0, null, "d3b632c6-2ba8-4c55-b1e1-8029bf9be117", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECkPbiRo73ZxL79Uk7eSVLtY7daBp3yk73DvWSr0J/adUY8qJNxRLBwlCpIx43j6wA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8213ccc0-3e39-4dcd-98ca-492a946a41b1", false, "admin@example.com" },
                    { "ef67c72c-c548-41ca-af20-8ddab55acfbe", 0, null, "7ca8f56a-ec42-4bbd-963a-83b068d36f22", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAECMkTLbRCe8SCsgoITL3k/ocmKNyWinkLJuXNsRHodOBsRASYECw/uOCIT4Qi5feXQ==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "165a03a6-62b4-4b8f-9af9-1eb967960dac", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AvailableReservationActivityType",
                columns: new[] { "ActivityTypeId", "AvailableReservationId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 10 },
                    { 1, 14 },
                    { 1, 16 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 12 },
                    { 3, 2 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 3, 15 },
                    { 4, 1 },
                    { 4, 5 },
                    { 4, 14 },
                    { 4, 17 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "a5d9a70f-c8fa-4e1d-8d93-c46afa657f9b" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a737762e-b7b3-4333-ad6a-47684bd2d01d" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "ef67c72c-c548-41ca-af20-8ddab55acfbe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PersonId",
                table: "Patient",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_Patient_PatientId",
                table: "PatientDiagnosis",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Patient_PatientId",
                table: "Reservation",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");
        }
    }
}
