using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class PatientDiagnosisChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient");

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

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Patient",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogKeyword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogKeyword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogKeyword_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "093e0e2b-e37a-4118-bc00-55d1bcd93b17", 0, null, "e1de13e1-1db0-455f-afee-3fa5468d2d96", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGVwJcpMi6Tunl6aSMq8p3I41szWuu0nkHK2ZGR3eAXyRDwToC75iB5yO96dmZCGSA==", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "admin@example.com" },
                    { "408a39c3-160e-4154-85fd-bd3f9c447364", 0, null, "9d92a66c-35a4-4c62-8329-4ca41b3e503a", "patient@example.com", true, false, null, "patient@EXAMPLE.COM", "PATIENT@PATIENT.COM", "AQAAAAIAAYagAAAAEJ72f6B6euW1ONbM4oxHWAd0GNYsWMwUnIU1hqRIHDTtnWyAw7G5HB3au6NS0INkuw==", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "patient@example.com" },
                    { "bb640d04-0531-4474-88f5-e7bd841ee440", 0, null, "a623756a-b593-4b02-a895-33a2b8f92800", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@PHYSIOTHERAPIST.COM", "AQAAAAIAAYagAAAAEKpDNi4NLwf0dakh5twH94fVn5VHeU1QjjfXw3M7ZELl7hycNBRIDEFTFjKpgtcBcA==", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000-0000-0000-0000-000000000000", false, "physiotherapist@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "093e0e2b-e37a-4118-bc00-55d1bcd93b17" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "408a39c3-160e-4154-85fd-bd3f9c447364" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "bb640d04-0531-4474-88f5-e7bd841ee440" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogKeyword_BlogPostId",
                table: "BlogKeyword",
                column: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "BlogKeyword");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "093e0e2b-e37a-4118-bc00-55d1bcd93b17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "408a39c3-160e-4154-85fd-bd3f9c447364" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "bb640d04-0531-4474-88f5-e7bd841ee440" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "093e0e2b-e37a-4118-bc00-55d1bcd93b17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408a39c3-160e-4154-85fd-bd3f9c447364");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb640d04-0531-4474-88f5-e7bd841ee440");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Person_PersonId",
                table: "Patient",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
