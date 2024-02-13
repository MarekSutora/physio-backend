using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class finishedDateNN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07f0541e-3cdd-40da-a7d4-b33d69dd7918" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2a80d426-5c89-46e3-9a84-394a2965ba59" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6f313bcc-bda4-499c-b92f-8c6422b9fdd5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a76cac46-31e1-44d0-92fa-eb6046152e24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d052fc49-4a1d-4257-b19a-de10a4110669" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f0541e-3cdd-40da-a7d4-b33d69dd7918");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a80d426-5c89-46e3-9a84-394a2965ba59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f313bcc-bda4-499c-b92f-8c6422b9fdd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a76cac46-31e1-44d0-92fa-eb6046152e24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d052fc49-4a1d-4257-b19a-de10a4110669");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "BookedReservations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationFinishedDate",
                table: "BookedReservations",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63f41267-98c2-47f5-be4b-ad3d61d3f1e4", 0, "362c1e30-8294-45ca-8b0c-626b95366001", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHvpzQUTy8U4rB+rFkgXzcJ6C4E6tWLIv3fzihgY17WIDM7uHGLNlRTwLfY/hHV1jg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e9c17763-94bc-4bd1-a492-1404e30056b1", false, "admin2@example.com" },
                    { "7f896736-82f8-4def-81ea-e3063ff3de37", 0, "19592689-9e58-4d7e-a86a-300a7550cc59", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJEpqxz6pi00FxoXNBIabQMJK8IAABFCvS78pyLKZ/vN0galMAUpFoG9FBnkVEg67g==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f4e5fbd3-8ab3-4523-9148-9982e1cac8fe", false, "patient3@example.com" },
                    { "7fd53cba-392d-4d13-bc02-f7b6e40c35bd", 0, "d6c9f707-049f-4b19-8a2f-485058a1dca8", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMWV5MbP2Cdru/BLOH29A3F9Gb/s0yL80LklDcvvBnQRVbICcpzO5teN74/jpx4/uw==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7340961a-d609-4085-bfa2-1effca4139ed", false, "patient2@example.com" },
                    { "80d90c3b-bad0-4097-8635-13a269c314a3", 0, "005a5bbe-ac09-4555-9af6-623722f7884e", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFqWP0ssfODnnH6dHd7Ti6+X0vBAhYhn53RUg2cTG4Ff2vki5vH5zrBu/dZOt3Fwww==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e57121bf-b18e-4eea-9882-2c0e1d89aa8a", false, "admin@example.com" },
                    { "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0", 0, "d4b6b4dd-6ad0-4680-b6ea-4c85d1c46701", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGzHQ8HpVPY874jcutCMUSWknprpPT3DKoksU/ClMw5wzgcLv+LbylrpQSZvn5VALQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0f9541aa-9f72-4791-92d2-70dc52a29f57", false, "patient1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "63f41267-98c2-47f5-be4b-ad3d61d3f1e4" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7f896736-82f8-4def-81ea-e3063ff3de37" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7fd53cba-392d-4d13-bc02-f7b6e40c35bd" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80d90c3b-bad0-4097-8635-13a269c314a3" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "63f41267-98c2-47f5-be4b-ad3d61d3f1e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7f896736-82f8-4def-81ea-e3063ff3de37" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "7fd53cba-392d-4d13-bc02-f7b6e40c35bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80d90c3b-bad0-4097-8635-13a269c314a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63f41267-98c2-47f5-be4b-ad3d61d3f1e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f896736-82f8-4def-81ea-e3063ff3de37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fd53cba-392d-4d13-bc02-f7b6e40c35bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80d90c3b-bad0-4097-8635-13a269c314a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b934a769-a3f1-46ed-83eb-7f6d68d5b4d0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationFinishedDate",
                table: "BookedReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "BookedReservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07f0541e-3cdd-40da-a7d4-b33d69dd7918", 0, "8750e789-98fb-4a58-9e9e-916fc0e180c7", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPEuL7333mLBXDoeH1W1xwJl+1a01dflNK3J0eTbfOkq+0NRvjcnMSVLytj8nhqSlA==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "de013a78-f5e4-49e5-9460-422469423976", false, "patient3@example.com" },
                    { "2a80d426-5c89-46e3-9a84-394a2965ba59", 0, "0fe98064-9a07-4ed5-9347-c200667f9464", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAED50b4xXSeCld6E9ERRZ5Xz5UXwjPotVTsWZf5t92mPXBKsyg+wl7wUIiEsoezuuYw==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bcf39e1f-bfff-48e9-8692-5ef6f1a925bb", false, "admin2@example.com" },
                    { "6f313bcc-bda4-499c-b92f-8c6422b9fdd5", 0, "3784c9dc-264e-48dc-b7d1-fca56e1c963d", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOgd3clbjlpgEukLuLsz2alHkfWuvli/I/g8cBygdo+WG9Npg+dfy2sboNYEKpBPpA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4d50ab4-0f5b-401f-92c0-cac9023b15b0", false, "patient2@example.com" },
                    { "a76cac46-31e1-44d0-92fa-eb6046152e24", 0, "d39d2e9c-0d13-4cdd-bb90-def8779e7eae", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAYH3xY0TJiPciR94qBvvRiAUxaSWSzdvDPR1uUyIQKQRMSaJOkKJWaCQV9ZKdkQ3w==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9d387226-c2ea-4aed-b15f-c9cc29fc36fe", false, "admin@example.com" },
                    { "d052fc49-4a1d-4257-b19a-de10a4110669", 0, "cb54bca3-5c4e-46a3-9f45-1d470b65ee99", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAECTROU1e+zjK0cN7mPsL76rDhKQd/1teOvqSXWZB0n6vZcq5mmZsAuS3ADvXqrduNw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "700f1a5a-66cc-4b2c-b5f0-9075baf6c06e", false, "patient1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "07f0541e-3cdd-40da-a7d4-b33d69dd7918" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2a80d426-5c89-46e3-9a84-394a2965ba59" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6f313bcc-bda4-499c-b92f-8c6422b9fdd5" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a76cac46-31e1-44d0-92fa-eb6046152e24" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d052fc49-4a1d-4257-b19a-de10a4110669" }
                });
        }
    }
}
