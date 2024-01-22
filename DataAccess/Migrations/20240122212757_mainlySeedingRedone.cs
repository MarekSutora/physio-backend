using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diploma_thesis_backend.Migrations
{
    /// <inheritdoc />
    public partial class mainlySeedingRedone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "BlogPost",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "BlogPost",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "BlogPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "AddressId", "DateOfBirth", "EmailAddress", "FirstName", "LastName", "PhoneNumber", "Title" },
                values: new object[,]
                {
                    { 1, null, null, null, "Admin", "User", null, null },
                    { 2, null, null, null, "John", "Doe", null, null },
                    { 3, null, null, null, "Jane", "Doe", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63eaca5d-e284-45f7-8738-c3160ca53b93", 0, null, "464c747f-d7c7-48ff-af61-54ba61f7234a", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMBxvdExGhG02K+aflF20xl/POcWrZaSYZzM4Qsj4mhxqxMQ6i0DLw0NqxfQRLUMaQ==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5c665ee-1f3d-47f0-877a-8a56cf7f130c", false, "physiotherapist@example.com" },
                    { "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf", 0, null, "e669b558-518b-409a-ac03-d7421d5a9779", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEAJjmIZM7m+rC8ahd7auW4QZ+J6pZtH3AMzxPzs9CguHHSE+14AzcB2qaJktXNduA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1e567342-29b1-4408-82ba-2f64011a7efc", false, "admin@example.com" },
                    { "c3235cea-19a5-4a0d-8f21-72f8d225eceb", 0, null, "cbb9882e-91a2-4b74-a2e2-596005bdbd37", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIemm7UqN/vvA1/z2PFZtg7eXR9ssXYvoOVQdF5+i3Q/BlwPm8JbzqJr5/tRRvz82w==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "061a5b80-6bdd-42aa-90cd-5e17c2cab099", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "63eaca5d-e284-45f7-8738-c3160ca53b93" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c3235cea-19a5-4a0d-8f21-72f8d225eceb" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_ApplicationUserId1",
                table: "BlogPost",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogId",
                table: "BlogPost",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_AspNetUsers_ApplicationUserId1",
                table: "BlogPost",
                column: "ApplicationUserId1",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_AspNetUsers_ApplicationUserId1",
                table: "BlogPost");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_Blog_BlogId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_ApplicationUserId1",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_BlogId",
                table: "BlogPost");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "63eaca5d-e284-45f7-8738-c3160ca53b93" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c3235cea-19a5-4a0d-8f21-72f8d225eceb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63eaca5d-e284-45f7-8738-c3160ca53b93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3235cea-19a5-4a0d-8f21-72f8d225eceb");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "BlogPost");

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
        }
    }
}
