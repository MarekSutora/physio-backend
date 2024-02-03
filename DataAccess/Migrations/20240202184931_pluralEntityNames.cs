using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class pluralEntityNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Person_PersonId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AvailableReservationServiceType_AvailableReservation_AvailableReservationId",
                table: "AvailableReservationServiceType");

            migrationBuilder.DropForeignKey(
                name: "FK_AvailableReservationServiceType_ServiceType_ServiceTypeId",
                table: "AvailableReservationServiceType");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogKeyword_BlogPost_BlogPostId",
                table: "BlogKeyword");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_AspNetUsers_ApplicationUserId",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_Blog_BlogId",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AspNetUsers_ApplicationUserId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_Diagnosis_DiagnosisId",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosis_Patient_PatientId",
                table: "PatientDiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AvailableReservation_AvailableReservationId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Patient_PatientId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Payment_PaymentId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_ServiceType_ServiceTypeId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypeDurationCost_ServiceType_ServiceTypeId",
                table: "ServiceTypeDurationCost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypeToDisplay",
                table: "ServiceTypeToDisplay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientDiagnosis",
                table: "PatientDiagnosis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogKeyword",
                table: "BlogKeyword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AvailableReservationServiceType",
                table: "AvailableReservationServiceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AvailableReservation",
                table: "AvailableReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

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

            migrationBuilder.RenameTable(
                name: "ServiceTypeToDisplay",
                newName: "ServiceTypeToDisplays");

            migrationBuilder.RenameTable(
                name: "ServiceType",
                newName: "ServiceTypes");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "PatientDiagnosis",
                newName: "PatientDiagnosiss");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Diagnosis",
                newName: "Diagnosiss");

            migrationBuilder.RenameTable(
                name: "BlogPost",
                newName: "BlogPosts");

            migrationBuilder.RenameTable(
                name: "BlogKeyword",
                newName: "BlogKeywords");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameTable(
                name: "AvailableReservationServiceType",
                newName: "AvailableReservationServiceTypes");

            migrationBuilder.RenameTable(
                name: "AvailableReservation",
                newName: "AvailableReservations");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresss");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ServiceTypeId",
                table: "Reservations",
                newName: "IX_Reservations_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PaymentId",
                table: "Reservations",
                newName: "IX_Reservations_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PatientId",
                table: "Reservations",
                newName: "IX_Reservations_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_AvailableReservationId",
                table: "Reservations",
                newName: "IX_Reservations_AvailableReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_AddressId",
                table: "Persons",
                newName: "IX_Persons_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosis_PatientId",
                table: "PatientDiagnosiss",
                newName: "IX_PatientDiagnosiss_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ApplicationUserId",
                table: "Employees",
                newName: "IX_Employees_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPost_BlogId",
                table: "BlogPosts",
                newName: "IX_BlogPosts_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPost_ApplicationUserId",
                table: "BlogPosts",
                newName: "IX_BlogPosts_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogKeyword_BlogPostId",
                table: "BlogKeywords",
                newName: "IX_BlogKeywords_BlogPostId");

            migrationBuilder.RenameIndex(
                name: "IX_AvailableReservationServiceType_ServiceTypeId",
                table: "AvailableReservationServiceTypes",
                newName: "IX_AvailableReservationServiceTypes_ServiceTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypeToDisplays",
                table: "ServiceTypeToDisplays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientDiagnosiss",
                table: "PatientDiagnosiss",
                columns: new[] { "DiagnosisId", "PatientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnosiss",
                table: "Diagnosiss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogKeywords",
                table: "BlogKeywords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AvailableReservationServiceTypes",
                table: "AvailableReservationServiceTypes",
                columns: new[] { "AvailableReservationId", "ServiceTypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AvailableReservations",
                table: "AvailableReservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresss",
                table: "Addresss",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f30ff4c-e382-4f36-b52e-c5996b4a4b06", 0, "b57de4ba-990a-4215-a509-dc482ab4c353", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN0M4n0mpPFmPzDvbTwv5oszy4qJtL8si947gO7RFXuXmLtGUUwTLnaROWwF9O2LiQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d76e1c5-6f8f-405a-b0fb-87fe79c0ce45", false, "patient@example.com" },
                    { "60827d6b-e111-4981-a82f-a61959ccd62c", 0, "d2fdadc7-f28a-4a45-89ac-56ab51f1eb45", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAECrQXjuKg1dfH9Qv4+IolP+SVK9a3QguB1crCd3RalnjGLI1049aTybX0EPbIRYewA==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cdffde19-9ed8-43f6-996a-ef59b7bd4aee", false, "physiotherapist@example.com" },
                    { "717f24fb-6e48-457e-8211-ce6aee89d849", 0, "c34ee3a1-3e80-4836-bc24-8a0ff42350e1", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOsYqkWwF4JY1ZCwVEUCLnOhFesxWil1lu3skWGlFu6RCmhNxYZoVzDCkM+H6LVcPg==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "acad0193-2d23-416b-b7ea-9c7f9b497b78", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4f30ff4c-e382-4f36-b52e-c5996b4a4b06" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "60827d6b-e111-4981-a82f-a61959ccd62c" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "717f24fb-6e48-457e-8211-ce6aee89d849" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "717f24fb-6e48-457e-8211-ce6aee89d849" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Persons_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableReservationServiceTypes_AvailableReservations_AvailableReservationId",
                table: "AvailableReservationServiceTypes",
                column: "AvailableReservationId",
                principalTable: "AvailableReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableReservationServiceTypes_ServiceTypes_ServiceTypeId",
                table: "AvailableReservationServiceTypes",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogKeywords_BlogPosts_BlogPostId",
                table: "BlogKeywords",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_AspNetUsers_ApplicationUserId",
                table: "BlogPosts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_Blogs_BlogId",
                table: "BlogPosts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_ApplicationUserId",
                table: "Employees",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosiss_Diagnosiss_DiagnosisId",
                table: "PatientDiagnosiss",
                column: "DiagnosisId",
                principalTable: "Diagnosiss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosiss_Patients_PatientId",
                table: "PatientDiagnosiss",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Persons_PersonId",
                table: "Patients",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Addresss_AddressId",
                table: "Persons",
                column: "AddressId",
                principalTable: "Addresss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AvailableReservations_AvailableReservationId",
                table: "Reservations",
                column: "AvailableReservationId",
                principalTable: "AvailableReservations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Patients_PatientId",
                table: "Reservations",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Payments_PaymentId",
                table: "Reservations",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ServiceTypes_ServiceTypeId",
                table: "Reservations",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypeDurationCost_ServiceTypes_ServiceTypeId",
                table: "ServiceTypeDurationCost",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Persons_PersonId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AvailableReservationServiceTypes_AvailableReservations_AvailableReservationId",
                table: "AvailableReservationServiceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AvailableReservationServiceTypes_ServiceTypes_ServiceTypeId",
                table: "AvailableReservationServiceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogKeywords_BlogPosts_BlogPostId",
                table: "BlogKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_AspNetUsers_ApplicationUserId",
                table: "BlogPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Blogs_BlogId",
                table: "BlogPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_ApplicationUserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosiss_Diagnosiss_DiagnosisId",
                table: "PatientDiagnosiss");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDiagnosiss_Patients_PatientId",
                table: "PatientDiagnosiss");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Persons_PersonId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresss_AddressId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AvailableReservations_AvailableReservationId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Patients_PatientId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Payments_PaymentId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ServiceTypes_ServiceTypeId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypeDurationCost_ServiceTypes_ServiceTypeId",
                table: "ServiceTypeDurationCost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypeToDisplays",
                table: "ServiceTypeToDisplays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientDiagnosiss",
                table: "PatientDiagnosiss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnosiss",
                table: "Diagnosiss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogKeywords",
                table: "BlogKeywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AvailableReservationServiceTypes",
                table: "AvailableReservationServiceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AvailableReservations",
                table: "AvailableReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresss",
                table: "Addresss");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "4f30ff4c-e382-4f36-b52e-c5996b4a4b06" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "60827d6b-e111-4981-a82f-a61959ccd62c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "717f24fb-6e48-457e-8211-ce6aee89d849" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "717f24fb-6e48-457e-8211-ce6aee89d849" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f30ff4c-e382-4f36-b52e-c5996b4a4b06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60827d6b-e111-4981-a82f-a61959ccd62c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "717f24fb-6e48-457e-8211-ce6aee89d849");

            migrationBuilder.RenameTable(
                name: "ServiceTypeToDisplays",
                newName: "ServiceTypeToDisplay");

            migrationBuilder.RenameTable(
                name: "ServiceTypes",
                newName: "ServiceType");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "PatientDiagnosiss",
                newName: "PatientDiagnosis");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Diagnosiss",
                newName: "Diagnosis");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameTable(
                name: "BlogPosts",
                newName: "BlogPost");

            migrationBuilder.RenameTable(
                name: "BlogKeywords",
                newName: "BlogKeyword");

            migrationBuilder.RenameTable(
                name: "AvailableReservationServiceTypes",
                newName: "AvailableReservationServiceType");

            migrationBuilder.RenameTable(
                name: "AvailableReservations",
                newName: "AvailableReservation");

            migrationBuilder.RenameTable(
                name: "Addresss",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ServiceTypeId",
                table: "Reservation",
                newName: "IX_Reservation_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PaymentId",
                table: "Reservation",
                newName: "IX_Reservation_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PatientId",
                table: "Reservation",
                newName: "IX_Reservation_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_AvailableReservationId",
                table: "Reservation",
                newName: "IX_Reservation_AvailableReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_AddressId",
                table: "Person",
                newName: "IX_Person_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientDiagnosiss_PatientId",
                table: "PatientDiagnosis",
                newName: "IX_PatientDiagnosis_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ApplicationUserId",
                table: "Employee",
                newName: "IX_Employee_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPosts_BlogId",
                table: "BlogPost",
                newName: "IX_BlogPost_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPosts_ApplicationUserId",
                table: "BlogPost",
                newName: "IX_BlogPost_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogKeywords_BlogPostId",
                table: "BlogKeyword",
                newName: "IX_BlogKeyword_BlogPostId");

            migrationBuilder.RenameIndex(
                name: "IX_AvailableReservationServiceTypes_ServiceTypeId",
                table: "AvailableReservationServiceType",
                newName: "IX_AvailableReservationServiceType_ServiceTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypeToDisplay",
                table: "ServiceTypeToDisplay",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientDiagnosis",
                table: "PatientDiagnosis",
                columns: new[] { "DiagnosisId", "PatientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogKeyword",
                table: "BlogKeyword",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AvailableReservationServiceType",
                table: "AvailableReservationServiceType",
                columns: new[] { "AvailableReservationId", "ServiceTypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AvailableReservation",
                table: "AvailableReservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Person_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableReservationServiceType_AvailableReservation_AvailableReservationId",
                table: "AvailableReservationServiceType",
                column: "AvailableReservationId",
                principalTable: "AvailableReservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableReservationServiceType_ServiceType_ServiceTypeId",
                table: "AvailableReservationServiceType",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogKeyword_BlogPost_BlogPostId",
                table: "BlogKeyword",
                column: "BlogPostId",
                principalTable: "BlogPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_AspNetUsers_ApplicationUserId",
                table: "BlogPost",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_Blog_BlogId",
                table: "BlogPost",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AspNetUsers_ApplicationUserId",
                table: "Employee",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDiagnosis_Diagnosis_DiagnosisId",
                table: "PatientDiagnosis",
                column: "DiagnosisId",
                principalTable: "Diagnosis",
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
                name: "FK_Person_Address_AddressId",
                table: "Person",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AvailableReservation_AvailableReservationId",
                table: "Reservation",
                column: "AvailableReservationId",
                principalTable: "AvailableReservation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Patient_PatientId",
                table: "Reservation",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Payment_PaymentId",
                table: "Reservation",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_ServiceType_ServiceTypeId",
                table: "Reservation",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypeDurationCost_ServiceType_ServiceTypeId",
                table: "ServiceTypeDurationCost",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
