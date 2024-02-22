using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BlogSlugAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "07cd8e13-1893-40b9-87bf-697bbb69d6de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "52652a00-afbd-40aa-9030-711e1c0bc3a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6586809e-3f2c-452f-b695-14f2524d34e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "82451cba-985b-4cd7-94ed-36636d1147ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "ff92d413-11a6-42cb-91c7-47d1406a3364" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07cd8e13-1893-40b9-87bf-697bbb69d6de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52652a00-afbd-40aa-9030-711e1c0bc3a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6586809e-3f2c-452f-b695-14f2524d34e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82451cba-985b-4cd7-94ed-36636d1147ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff92d413-11a6-42cb-91c7-47d1406a3364");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "BlogPosts",
                newName: "Slug");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "BlogPosts",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07cd8e13-1893-40b9-87bf-697bbb69d6de", 0, "24b6b1be-6f8d-4a43-ab1b-6311c0b1e5ef", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMoLRpf0sV2YKhMifgRv4VqApzYInnzg/vjRDLXIuDOaRBzXUibyODUJiD+9tZYN1g==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "769bd1ab-c4aa-4d3f-90f9-0b5013b3c9c8", false, "admin@example.com" },
                    { "52652a00-afbd-40aa-9030-711e1c0bc3a4", 0, "8dca9177-7ede-4b4c-b92e-316379048483", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBO87qWkPvkfcyrGBon8u46rWo5aBzfnnweRNl8YKrUVfEdC0M33xs+iOe/ZnCcT6Q==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1545b682-0151-44c0-99cf-9da7bda9895e", false, "patient3@example.com" },
                    { "6586809e-3f2c-452f-b695-14f2524d34e3", 0, "b87e426b-fbc8-49a4-8f5c-b7245c4a81de", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF2fAIrhJ9eX6lk9N6gXCtFHeThPZBAzXRF4tIUPpXpC3W67SySOUU3kyBhpUTqE1A==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "052e874a-c1bd-40fb-9c51-817c2f793b09", false, "admin2@example.com" },
                    { "82451cba-985b-4cd7-94ed-36636d1147ce", 0, "9edf59ae-1bd1-4d54-8150-e142c114dfe4", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPDfY7HiKPnSSmIEG6B2/7fQQdJJgwlHYGCby7prgUFBucPL3KOYvj2hpSTg+n1Dcg==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fb182a99-937f-4d55-9e31-5aba843173aa", false, "patient2@example.com" },
                    { "ff92d413-11a6-42cb-91c7-47d1406a3364", 0, "3e291bdf-6abe-4506-8bf2-4143879b3b33", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENPrD3LSXZt0PPwSM7IIJ7cShDFPtaTlu5JvQjB1qtIRC9F/kB2dY4JvV4eTGEae0Q==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc20c4f7-47b1-4695-bd71-306ee038c77f", false, "patient1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "07cd8e13-1893-40b9-87bf-697bbb69d6de" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "52652a00-afbd-40aa-9030-711e1c0bc3a4" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6586809e-3f2c-452f-b695-14f2524d34e3" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "82451cba-985b-4cd7-94ed-36636d1147ce" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "ff92d413-11a6-42cb-91c7-47d1406a3364" }
                });
        }
    }
}
