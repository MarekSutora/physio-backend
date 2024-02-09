using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class csharpPropertiesAdjustments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_AspNetUsers_ApplicationUserId",
                table: "BlogPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Blogs_BlogId",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_ApplicationUserId",
                table: "BlogPosts");

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
                name: "DateOfBirth",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "BlogPosts");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Diagnosiss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "BlogPosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "BlogPosts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d0d9f32-5926-4286-8312-a3b0920ccacf", 0, "051228e7-529c-45d0-92db-4768e83f1d7a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELImT4NbNrxchfKL6gbO7y3Cv0BAMcdhk5XvoTdEJ5qWaCrjBcrc6/G5HqNUkXfOWQ==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8bf9b7c1-2fe5-4381-a4ef-15003ae9f27a", false, "admin@example.com" },
                    { "6bbec599-63e9-495c-abf9-c72845c8ec71", 0, "f8879d9f-659a-4452-aa08-b5f634ef017e", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHG7w7evJP7bPeX5pdIu2ZqYFknsurUXX8Wypg8w8LAjnhAVGuLEX0GRjDMTtkttKg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a6992436-0de2-4a8e-bf1e-aea73737763c", false, "physiotherapist@example.com" },
                    { "9d92412f-c325-4620-a4d0-1bd547ed88e1", 0, "901af2ef-3dbe-4e74-b8b6-cfec1cc367dd", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBQahFlZZoxTY7k6bp5ziyrrcq5x+Ohh7R4FHf3xwvwjGzcCwuZPugFc39a9aoyubA==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2aed5303-79ee-4df3-a6c3-edb87bc34bf6", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "3d0d9f32-5926-4286-8312-a3b0920ccacf" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "3d0d9f32-5926-4286-8312-a3b0920ccacf" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6bbec599-63e9-495c-abf9-c72845c8ec71" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "9d92412f-c325-4620-a4d0-1bd547ed88e1" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_Blogs_BlogId",
                table: "BlogPosts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Blogs_BlogId",
                table: "BlogPosts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "3d0d9f32-5926-4286-8312-a3b0920ccacf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "3d0d9f32-5926-4286-8312-a3b0920ccacf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "6bbec599-63e9-495c-abf9-c72845c8ec71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "9d92412f-c325-4620-a4d0-1bd547ed88e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d0d9f32-5926-4286-8312-a3b0920ccacf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bbec599-63e9-495c-abf9-c72845c8ec71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d92412f-c325-4620-a4d0-1bd547ed88e1");

            migrationBuilder.DropColumn(
                name: "date",
                table: "BlogPosts");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Persons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Diagnosiss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "BlogPosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "BlogPosts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16947b0f-5673-494f-80da-21c9c591af8e", 0, "3556d77c-19ce-4141-871c-d790e1f01201", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOg4oTPN65ALuQT4E2JRSldCnl+OfAQmjF+gtgINlhb6YiJKszYQJoPnkVZR+pSUsQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "75cdc2ba-9212-4dfd-a609-92b575c0f607", false, "patient@example.com" },
                    { "bad71e53-0f89-4f98-84d0-b1c54450abb1", 0, "53a79c5e-516e-4ccd-b09d-73750ea33005", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGjuWP8GGsx34F1WoYPnctrUUZVTRHU32itbJ76yE8T+Ov9MnwCiP3HjWQojgPGK2A==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a826ec23-e667-4ac3-bb0e-21097c098db4", false, "physiotherapist@example.com" },
                    { "f1b49085-01d5-4462-9760-2e1e2370479e", 0, "3bcf5524-59bb-4069-87a8-9c711c8172f4", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAmdTRhLU1rOU0lwWQnNdBrwDdWwnv9THIwHXO38em7bnhtFYMGcGo6Cdw/5HELRhA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "547f3647-0d3f-4e46-96d9-7f58ed37314d", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "EmailAddress", "Title" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "EmailAddress", "Title" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "EmailAddress", "Title" },
                values: new object[] { null, null, null });

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
                name: "IX_BlogPosts_ApplicationUserId",
                table: "BlogPosts",
                column: "ApplicationUserId");

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
        }
    }
}
