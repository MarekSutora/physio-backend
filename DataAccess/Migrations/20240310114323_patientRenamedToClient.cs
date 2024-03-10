using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class patientRenamedToClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Patients_PatientId",
                table: "BookedAppointments");

            migrationBuilder.DropTable(
                name: "PatientDiagnosiss");

            migrationBuilder.DropTable(
                name: "PatientNotes");

            migrationBuilder.DropTable(
                name: "Diagnosiss");

            migrationBuilder.DropTable(
                name: "Patients");

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

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "BookedAppointments",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedAppointments_PatientId",
                table: "BookedAppointments",
                newName: "IX_BookedAppointments_ClientId");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Clients_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientNotes_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "PersonId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C7D20194-9C7E-40DB-9C63-F71D20116529",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "064b6a0b-8c25-4710-8fc3-95e2d59be04e", 0, "11e2fbfa-680b-45c8-99f2-4e76adacc60c", "client3@example.com", true, false, null, "CLIENT3@EXAMPLE.COM", "CLIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMRBt7+rg2DynHx3GW5St6gbbWbGSNYf6dUyYC/BPMO4jNeyKll59whTFFu0McK+NA==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cb79886f-c559-49d8-b76d-4b940afc931a", false, "client3@example.com" },
                    { "4ab97c50-052f-44af-8516-3a27e4ec3d72", 0, "10d5729d-f69f-410b-8e08-ca6ee8763c8f", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKyaoHsQrFg6VqQHNuhpvv+tn/dOjL1RniaBD+ecyX30ZAQrW1KS9Ykc90Zli/YKbQ==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9576e59d-9b55-4c1c-ae34-dfb047b83f7e", false, "admin@example.com" },
                    { "55f7cc01-0e49-4cb0-bff8-aced0c399819", 0, "45f68840-611e-49aa-a199-7d3beaa0daf2", "client2@example.com", true, false, null, "CLIENT12@EXAMPLE.COM", "CLIENT12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA5KLl/CUw3rGBmRPN8VSzMNLAe4gPSHzy79cT1qVl7TJ+Ylp5oPEJVpfa/lZ219kQ==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "54569759-51b6-43e4-a2b3-7e508de4a643", false, "client2@example.com" },
                    { "ea4cbaeb-0869-493c-b80c-372a32b05539", 0, "b0eeadc9-2add-4349-a6b4-9785402b123c", "client1@example.com", true, false, null, "CLIENT1@EXAMPLE.COM", "client1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJiiF1Dl3/yUaoCusECWcrRjXopR6+aKuWAyMUk/g/QrPMOGUjrNt+t5pMssRSxtcg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7c178912-d976-4f2d-9339-3e900bbd6eef", false, "client1@example.com" },
                    { "faa2cd95-a59c-4127-8f54-916deb38b612", 0, "10fb76e3-2f31-4456-830b-8491aa589055", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAED1jsHPX+lK9AyjGTNcEmajZfLBpvUk7G+T5Ovqf5PHnrTFjkSh0caEAVww/eo/TUg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f1f881ad-418f-43d1-af07-e2d63215c9a0", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                column: "PersonId",
                values: new object[]
                {
                    3,
                    4,
                    5
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "FirstName",
                value: "Client");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "FirstName",
                value: "Client");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "FirstName",
                value: "Client");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "064b6a0b-8c25-4710-8fc3-95e2d59be04e" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "4ab97c50-052f-44af-8516-3a27e4ec3d72" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "55f7cc01-0e49-4cb0-bff8-aced0c399819" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "ea4cbaeb-0869-493c-b80c-372a32b05539" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "faa2cd95-a59c-4127-8f54-916deb38b612" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_ClientId",
                table: "ClientNotes",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments");

            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "064b6a0b-8c25-4710-8fc3-95e2d59be04e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "4ab97c50-052f-44af-8516-3a27e4ec3d72" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "55f7cc01-0e49-4cb0-bff8-aced0c399819" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "ea4cbaeb-0869-493c-b80c-372a32b05539" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "faa2cd95-a59c-4127-8f54-916deb38b612" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "BookedAppointments",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedAppointments_ClientId",
                table: "BookedAppointments",
                newName: "IX_BookedAppointments_PatientId");

            migrationBuilder.CreateTable(
                name: "Diagnosiss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosiss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Patients_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnosiss",
                columns: table => new
                {
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnosiss", x => new { x.DiagnosisId, x.PatientId });
                    table.ForeignKey(
                        name: "FK_PatientDiagnosiss_Diagnosiss_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosiss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiagnosiss_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C7D20194-9C7E-40DB-9C63-F71D20116529",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Patient", "PATIENT" });

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
                table: "Patients",
                column: "PersonId",
                values: new object[]
                {
                    3,
                    4,
                    5
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "FirstName",
                value: "Patient");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "FirstName",
                value: "Patient");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "FirstName",
                value: "Patient");

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
                name: "IX_PatientDiagnosiss_PatientId",
                table: "PatientDiagnosiss",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientNotes_PatientId",
                table: "PatientNotes",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Patients_PatientId",
                table: "BookedAppointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PersonId");
        }
    }
}
