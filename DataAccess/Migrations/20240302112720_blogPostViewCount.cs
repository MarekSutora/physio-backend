using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class blogPostViewCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "2c5e861f-811d-4de8-9277-b05373abc1d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "30c750c7-73a0-497e-98f6-c1936d31c316" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "53f26347-2d27-4856-97b5-dd062f357720" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6388a86a-5f98-4313-95d8-cca824a055dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80cc3a0c-a003-452b-8901-d9fc840dbb11" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e861f-811d-4de8-9277-b05373abc1d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30c750c7-73a0-497e-98f6-c1936d31c316");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53f26347-2d27-4856-97b5-dd062f357720");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6388a86a-5f98-4313-95d8-cca824a055dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80cc3a0c-a003-452b-8901-d9fc840dbb11");

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "BlogPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25f8675b-7e11-4a9a-9fea-eb79f25962ef", 0, "425ba3e2-a49b-4f33-8459-ba923122a749", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG9on9/zkg47IVxOK/PBtTpjFZlLholOq32PcDg19Y1VDB5bO0UTkr7dgIiNnoBBKg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "53bc1cc2-03b5-48fb-8452-42c3e647a236", false, "admin2@example.com" },
                    { "5cbbec44-720a-4736-98e9-1c1950aa61b8", 0, "a5fd4fa3-4a0e-4a6d-b77c-3ebcd4f2745b", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMM0T52Aehwbo4DfZFdefm2FvYjUWktFikNxY5cEk8n2wvR9IzhVY+aiyJuhNszuVQ==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f0dcf257-4497-4e83-b98c-cb9696af3d9f", false, "patient1@example.com" },
                    { "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0", 0, "7784bcc9-0f95-402b-b0eb-1daae74b43da", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELYqLanCYYLW9qHuO74ySOSvR4tfK9NooFLChPfnxR4xvPSKdfUqTUOlHuNd016ARQ==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b109a60d-245c-4d92-ba43-e93f27adc707", false, "admin@example.com" },
                    { "af499760-047d-4171-8006-2d5c4abc7bee", 0, "f2d2e3a0-344a-42b7-84cf-65ab2bebda63", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKBhFJT22jdDK6H4w8haaBGuCr56FmRKZLHIklGzPAdzgN5b5Zm2iJsOIx5q0GXPvw==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9247be96-a567-4e1f-9b9e-6dd627bc8432", false, "patient2@example.com" },
                    { "d282e31b-8ee9-42d4-8a64-03356ef30d5f", 0, "dae6acc5-d9ad-4c22-94ce-dcd62e0f1f18", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEYrIkKr0vosidgTqHAQDKHJhRG8dNiEJD9fxrh25E5d3LwdBhswTW3r/ViSjNLK3w==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd23095b-b8ea-4483-9ad4-63871918a19e", false, "patient3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "25f8675b-7e11-4a9a-9fea-eb79f25962ef" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5cbbec44-720a-4736-98e9-1c1950aa61b8" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "af499760-047d-4171-8006-2d5c4abc7bee" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d282e31b-8ee9-42d4-8a64-03356ef30d5f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "25f8675b-7e11-4a9a-9fea-eb79f25962ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5cbbec44-720a-4736-98e9-1c1950aa61b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "af499760-047d-4171-8006-2d5c4abc7bee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "d282e31b-8ee9-42d4-8a64-03356ef30d5f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25f8675b-7e11-4a9a-9fea-eb79f25962ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cbbec44-720a-4736-98e9-1c1950aa61b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7928e3a0-7ea0-46c7-ace7-2f0695a60ae0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af499760-047d-4171-8006-2d5c4abc7bee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d282e31b-8ee9-42d4-8a64-03356ef30d5f");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "BlogPosts");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c5e861f-811d-4de8-9277-b05373abc1d9", 0, "3f4ef0e2-20b2-4a85-a505-d0241197c450", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDKeJa0mVoW+PEKiZMoDlzej/hPeGB0kCfR2+UjwAa5s7FZelwCaL3z6UQH/SUoZ5g==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e7d89703-151d-4299-ac70-852fabda9d11", false, "patient2@example.com" },
                    { "30c750c7-73a0-497e-98f6-c1936d31c316", 0, "f5c26969-4a2c-417a-9947-a962e78aa1cb", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMZQxplUTOoxA68e2ftloe5PGCEEPxxYpR/EIchxLNz0CSgBH16d7/ND3pIzugP/Cg==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18eb6113-9864-48a1-bb45-947c2e51ce2c", false, "patient3@example.com" },
                    { "53f26347-2d27-4856-97b5-dd062f357720", 0, "baa392d5-a250-4c73-aefb-7b7b054b8508", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIn+DKvwKhJEiCZqT7MM4ABnXjEk/XaDnMatZmfLBQEcehNOWKBzkQanBGuYyDpZog==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22a38228-d715-4a69-b4fe-768d015f035d", false, "patient1@example.com" },
                    { "6388a86a-5f98-4313-95d8-cca824a055dd", 0, "510521ff-f21f-47c7-9228-7d7d76fd14ae", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHMUkZ1FhMlxMQRxyl4AeLMT/76skMdVlmSGj9rxyEITOj9jmqfU1D4FmVpGbCFrQA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5e527a2e-f43b-4e45-9b73-4b062de11967", false, "admin@example.com" },
                    { "80cc3a0c-a003-452b-8901-d9fc840dbb11", 0, "c93511ab-75e5-4f1c-8b36-226e1a7c7be5", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAENtXulAXgdQPS9VvWvm4hhxOv0I8LPmO8T0eu88p6VyR18N4f8recPbHdeLR4Ycj9A==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "58a9fe47-3dad-42dd-aa6d-73d4f061b0ff", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "2c5e861f-811d-4de8-9277-b05373abc1d9" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "30c750c7-73a0-497e-98f6-c1936d31c316" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "53f26347-2d27-4856-97b5-dd062f357720" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6388a86a-5f98-4313-95d8-cca824a055dd" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80cc3a0c-a003-452b-8901-d9fc840dbb11" }
                });
        }
    }
}
