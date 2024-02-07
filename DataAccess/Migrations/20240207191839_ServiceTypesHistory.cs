using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ServiceTypesHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogKeywords");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "ServiceTypeToDisplays");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "29aa6dbf-c1df-4ae7-88ee-1054832a8d09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "f13a2170-2de4-4021-bf08-fa87df056aca" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29aa6dbf-c1df-4ae7-88ee-1054832a8d09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d5c1d61-4f4b-4f78-a7dd-fa6313326584");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f13a2170-2de4-4021-bf08-fa87df056aca");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HexColor",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ServiceTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ServiceTypeDurationCosts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Property for statistics in case cost or duration gets updated");

            migrationBuilder.CreateTable(
                name: "BlogPostKeywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostKeywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPostKeywords_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    ReservationBookedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationFinishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableReservationId = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeDurationCostId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedReservations_AvailableReservations_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedReservations_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_BookedReservations_ServiceTypeDurationCosts_ServiceTypeDurationCostId",
                        column: x => x.ServiceTypeDurationCostId,
                        principalTable: "ServiceTypeDurationCosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookedReservations_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07f3e8eb-b4a4-49ea-976e-af252693d5cc", 0, "44f1dd54-463f-443c-a159-0570e9065156", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOJ4sWRNBYcdy3RaT5r8GruhX/rMAjFyC9yieiem+yRZZ8foRnlJQz2hYc+xNeT6Bg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3d353975-0a71-4898-b9f3-c840e87ce23d", false, "patient@example.com" },
                    { "150f1376-3e28-4e1a-9d33-7f576144c6b2", 0, "ef81a4fa-d043-465d-ac38-f23628320d5b", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPEsOr+M/km0TgprsqYMn2jtP48oFK+ukUW0NsTWZt3q6sIQ3/jWfzInuDaSBkTAOg==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "87c2624c-f774-4df9-bd33-4c9df6b09a21", false, "admin@example.com" },
                    { "eb991196-c592-4243-809b-961d159367a8", 0, "47c46908-2250-4ac8-be4c-b3b9c353d9f3", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKDvNr3rxfqt0JzU5rEJ17A8zm61lrh8F9KE8DWTr+WEi+Cjwde4hmvj8j7RpYjP2Q==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a05f571-c8b4-4562-ba67-bd727b2458e3", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07f3e8eb-b4a4-49ea-976e-af252693d5cc" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "150f1376-3e28-4e1a-9d33-7f576144c6b2" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "150f1376-3e28-4e1a-9d33-7f576144c6b2" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "eb991196-c592-4243-809b-961d159367a8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostKeywords_BlogPostId",
                table: "BlogPostKeywords",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_AvailableReservationId",
                table: "BookedReservations",
                column: "AvailableReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_PatientId",
                table: "BookedReservations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_ServiceTypeDurationCostId",
                table: "BookedReservations",
                column: "ServiceTypeDurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_ServiceTypeId",
                table: "BookedReservations",
                column: "ServiceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostKeywords");

            migrationBuilder.DropTable(
                name: "BookedReservations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07f3e8eb-b4a4-49ea-976e-af252693d5cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "150f1376-3e28-4e1a-9d33-7f576144c6b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "150f1376-3e28-4e1a-9d33-7f576144c6b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "eb991196-c592-4243-809b-961d159367a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f3e8eb-b4a4-49ea-976e-af252693d5cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "150f1376-3e28-4e1a-9d33-7f576144c6b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb991196-c592-4243-809b-961d159367a8");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ServiceTypes");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HexColor",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BlogKeywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogKeywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogKeywords_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EndedWorkingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartedWorkingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypeToDisplays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypeToDisplays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableReservationId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationFinishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AvailableReservations_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Reservations_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29aa6dbf-c1df-4ae7-88ee-1054832a8d09", 0, "07280a3d-b913-4f20-8b59-5de72cd900e9", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAIRNZVIh0Gs+X2tpN+94OsHXn7d9SxxGtpeliXVBKSq4UtBkGP2Gu71tOdiDkJsGw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ffdde672-d56a-428b-ade0-5e5bb9d92678", false, "patient@example.com" },
                    { "7d5c1d61-4f4b-4f78-a7dd-fa6313326584", 0, "80412e42-1d3e-43da-b2fc-a22af1bad134", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ1ZpykxPTnEP4jyyHKDsvw/etnQb20dZ1UQIaB+cuMoQYX8WZ+zEdnd9SauoSmV/g==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "93b0589f-8086-445a-8c9c-eb3cf8fb0b4d", false, "admin@example.com" },
                    { "f13a2170-2de4-4021-bf08-fa87df056aca", 0, "10012c79-7248-402d-9db2-a5bfa01a293a", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPF6yCCV9NhFCD1tZNHxPYhZIsiGIzPzoqJCP1IiZ3FNqpe0lLBk20oqBa4hxJc+YQ==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2367df58-47fb-4a5d-9f3d-c38a5a0266f4", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "29aa6dbf-c1df-4ae7-88ee-1054832a8d09" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7d5c1d61-4f4b-4f78-a7dd-fa6313326584" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "f13a2170-2de4-4021-bf08-fa87df056aca" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogKeywords_BlogPostId",
                table: "BlogKeywords",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ApplicationUserId",
                table: "Employees",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AvailableReservationId",
                table: "Reservations",
                column: "AvailableReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PatientId",
                table: "Reservations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PaymentId",
                table: "Reservations",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ServiceTypeId",
                table: "Reservations",
                column: "ServiceTypeId");
        }
    }
}
