using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newServiceTypeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedReservations_AvailableReservations_AvailableReservationId",
                table: "BookedReservations");

            migrationBuilder.DropTable(
                name: "AvailableReservationServiceTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "faadef4d-9268-487b-b825-820c67db9404" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9b27b68-c753-4b99-b6a3-86b58cf1d199");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faadef4d-9268-487b-b825-820c67db9404");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropColumn(
                name: "DateOfBecomingInactive",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.RenameColumn(
                name: "DurationMinutes",
                table: "ServiceTypeDurationCosts",
                newName: "DurationCostId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFrom",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTo",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "AvailableReservationId",
                table: "BookedReservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AvailableReservationServiceTypeDCId",
                table: "BookedReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AvailableReservationServiceTypeDcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeDurationCostId = table.Column<int>(type: "int", nullable: false),
                    AvailableReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableReservationServiceTypeDcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceTypeDcs_AvailableReservations_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceTypeDcs_ServiceTypeDurationCosts_ServiceTypeDurationCostId",
                        column: x => x.ServiceTypeDurationCostId,
                        principalTable: "ServiceTypeDurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DurationCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurationCosts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16947b0f-5673-494f-80da-21c9c591af8e", 0, "3556d77c-19ce-4141-871c-d790e1f01201", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOg4oTPN65ALuQT4E2JRSldCnl+OfAQmjF+gtgINlhb6YiJKszYQJoPnkVZR+pSUsQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "75cdc2ba-9212-4dfd-a609-92b575c0f607", false, "patient@example.com" },
                    { "bad71e53-0f89-4f98-84d0-b1c54450abb1", 0, "53a79c5e-516e-4ccd-b09d-73750ea33005", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGjuWP8GGsx34F1WoYPnctrUUZVTRHU32itbJ76yE8T+Ov9MnwCiP3HjWQojgPGK2A==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a826ec23-e667-4ac3-bb0e-21097c098db4", false, "physiotherapist@example.com" },
                    { "f1b49085-01d5-4462-9760-2e1e2370479e", 0, "3bcf5524-59bb-4069-87a8-9c711c8172f4", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAmdTRhLU1rOU0lwWQnNdBrwDdWwnv9THIwHXO38em7bnhtFYMGcGo6Cdw/5HELRhA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "547f3647-0d3f-4e46-96d9-7f58ed37314d", false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "16947b0f-5673-494f-80da-21c9c591af8e" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "bad71e53-0f89-4f98-84d0-b1c54450abb1" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "f1b49085-01d5-4462-9760-2e1e2370479e" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "f1b49085-01d5-4462-9760-2e1e2370479e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDurationCosts_DurationCostId",
                table: "ServiceTypeDurationCosts",
                column: "DurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedReservations_AvailableReservationServiceTypeDCId",
                table: "BookedReservations",
                column: "AvailableReservationServiceTypeDCId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationServiceTypeDcs_AvailableReservationId",
                table: "AvailableReservationServiceTypeDcs",
                column: "AvailableReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationServiceTypeDcs_ServiceTypeDurationCostId",
                table: "AvailableReservationServiceTypeDcs",
                column: "ServiceTypeDurationCostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedReservations_AvailableReservationServiceTypeDcs_AvailableReservationServiceTypeDCId",
                table: "BookedReservations",
                column: "AvailableReservationServiceTypeDCId",
                principalTable: "AvailableReservationServiceTypeDcs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookedReservations_AvailableReservations_AvailableReservationId",
                table: "BookedReservations",
                column: "AvailableReservationId",
                principalTable: "AvailableReservations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypeDurationCosts_DurationCosts_DurationCostId",
                table: "ServiceTypeDurationCosts",
                column: "DurationCostId",
                principalTable: "DurationCosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedReservations_AvailableReservationServiceTypeDcs_AvailableReservationServiceTypeDCId",
                table: "BookedReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_BookedReservations_AvailableReservations_AvailableReservationId",
                table: "BookedReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypeDurationCosts_DurationCosts_DurationCostId",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropTable(
                name: "AvailableReservationServiceTypeDcs");

            migrationBuilder.DropTable(
                name: "DurationCosts");

            migrationBuilder.DropIndex(
                name: "IX_ServiceTypeDurationCosts_DurationCostId",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropIndex(
                name: "IX_BookedReservations_AvailableReservationServiceTypeDCId",
                table: "BookedReservations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "16947b0f-5673-494f-80da-21c9c591af8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "bad71e53-0f89-4f98-84d0-b1c54450abb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "f1b49085-01d5-4462-9760-2e1e2370479e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "f1b49085-01d5-4462-9760-2e1e2370479e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16947b0f-5673-494f-80da-21c9c591af8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bad71e53-0f89-4f98-84d0-b1c54450abb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1b49085-01d5-4462-9760-2e1e2370479e");

            migrationBuilder.DropColumn(
                name: "DateFrom",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropColumn(
                name: "DateTo",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropColumn(
                name: "AvailableReservationServiceTypeDCId",
                table: "BookedReservations");

            migrationBuilder.RenameColumn(
                name: "DurationCostId",
                table: "ServiceTypeDurationCosts",
                newName: "DurationMinutes");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ServiceTypeDurationCosts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Property for statistics in case cost or duration gets updated");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "ServiceTypeDurationCosts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBecomingInactive",
                table: "ServiceTypeDurationCosts",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AlterColumn<int>(
                name: "AvailableReservationId",
                table: "BookedReservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AvailableReservationServiceTypes",
                columns: table => new
                {
                    AvailableReservationId = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableReservationServiceTypes", x => new { x.AvailableReservationId, x.ServiceTypeId });
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceTypes_AvailableReservations_AvailableReservationId",
                        column: x => x.AvailableReservationId,
                        principalTable: "AvailableReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableReservationServiceTypes_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a9b27b68-c753-4b99-b6a3-86b58cf1d199", 0, "a8e0485e-391b-43ca-a4fa-b3bc9101002d", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHOLb5+zvtL/szElrBQCNU9odrof26sIJrSAxTcdBpV/xyFk7i+nk/8Ohx1oX/27sw==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "543fec4c-61a0-4642-ac23-7556d7f65d4b", false, "admin@example.com" },
                    { "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11", 0, "ada305b3-15ab-4cb0-9aea-280024ba15df", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKBGNSX6TEtS4EusUFr5Wzp55Rq0DnDhR2viF102e2Kb1vc6NLInXxQ/9/jjMcQTWg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c25959ba-9bd2-4a29-bdee-a3358c69e97a", false, "physiotherapist@example.com" },
                    { "faadef4d-9268-487b-b825-820c67db9404", 0, "29183e68-3b60-45bf-92d4-d2326dd61957", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHToPRFp6t3Vq3juLtNFhu3k2I3u+aWavG8WVB2H5ZHkL3caksyAwSkT2WZNy5xF6Q==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa711b6e-0f17-450b-8bf5-9b382d30a740", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "faadef4d-9268-487b-b825-820c67db9404" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableReservationServiceTypes_ServiceTypeId",
                table: "AvailableReservationServiceTypes",
                column: "ServiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedReservations_AvailableReservations_AvailableReservationId",
                table: "BookedReservations",
                column: "AvailableReservationId",
                principalTable: "AvailableReservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
