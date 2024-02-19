using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class blogAdjustments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Blogs_BlogId",
                table: "BlogPosts");

            migrationBuilder.DropTable(
                name: "BlogPostKeywords");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_BlogId",
                table: "BlogPosts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "132fb38f-7690-4521-a3ac-64e2bd0f680e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5ad31b21-38f6-4159-b20f-544d45803ea8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "b597c871-0dd5-45f0-8683-67a66920271a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c74ccb80-ad1e-4373-a2ef-b05f428665b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "e934755e-634a-466e-ba7a-fea0c6f9ed16" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132fb38f-7690-4521-a3ac-64e2bd0f680e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ad31b21-38f6-4159-b20f-544d45803ea8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b597c871-0dd5-45f0-8683-67a66920271a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ccb80-ad1e-4373-a2ef-b05f428665b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e934755e-634a-466e-ba7a-fea0c6f9ed16");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "date",
                table: "BlogPosts");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "BlogPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HTMLContent",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "BlogPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KeywordsString",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Author",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "HTMLContent",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "KeywordsString",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "BlogPosts");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "BlogPosts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "BlogPosts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BlogPostKeywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "132fb38f-7690-4521-a3ac-64e2bd0f680e", 0, "b2619a63-5ea3-4633-a537-30645a7eddfd", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDHR8SYC54Lka4k2lKb63RlRuwvgVl/HaY+/qYi+FsFknZgBLW4YwwF8V0ewYIqmfw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "20ca0dd8-e880-4d7b-aac7-eae2b3f7f84b", false, "admin2@example.com" },
                    { "5ad31b21-38f6-4159-b20f-544d45803ea8", 0, "e36d0632-20db-41dd-8a08-033a38946d60", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIfriJGyFcF/0/B+pPRzbMN9n5r8KAkVr+tYkVhnLu9eHkjgWTC/6ISSjM/5nUPE7w==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ced15cc-88cf-411b-97a4-f8cf9fe1e257", false, "patient2@example.com" },
                    { "b597c871-0dd5-45f0-8683-67a66920271a", 0, "697dcaf0-8560-4d25-a0ed-d88a1108d751", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM0WqaFY5F9N8E6s+wERRr6ZPMBobrwBIbXs7T0yCAIJUKASqtjoANQyDnjoSfHmsg==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1cdfc52d-10be-4149-88c0-cea82434f624", false, "admin@example.com" },
                    { "c74ccb80-ad1e-4373-a2ef-b05f428665b9", 0, "d7f65e75-5110-4ba3-8d2b-356413d95178", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDRQWpoSyV53Iy0ev96Fx8XHV2O791Em/8wT9UrxP/5DA/OrS7u9oVn2aBclal2w7Q==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bc36c7fb-70d2-4c6c-9691-21694c15b9a3", false, "patient1@example.com" },
                    { "e934755e-634a-466e-ba7a-fea0c6f9ed16", 0, "b1156dd4-f6f5-4d21-a36d-dfe8bf50829b", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOnFD5XTEx9bERbQ3Fl08HNZs/qjsZv+BfVie9NlTs0RAmRJJHyoeZwUDXR3s3xq+Q==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2473f8c4-192e-4ed4-8104-b3d7eebcf065", false, "patient3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "132fb38f-7690-4521-a3ac-64e2bd0f680e" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5ad31b21-38f6-4159-b20f-544d45803ea8" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "b597c871-0dd5-45f0-8683-67a66920271a" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "c74ccb80-ad1e-4373-a2ef-b05f428665b9" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "e934755e-634a-466e-ba7a-fea0c6f9ed16" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_BlogId",
                table: "BlogPosts",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostKeywords_BlogPostId",
                table: "BlogPostKeywords",
                column: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_Blogs_BlogId",
                table: "BlogPosts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");
        }
    }
}
