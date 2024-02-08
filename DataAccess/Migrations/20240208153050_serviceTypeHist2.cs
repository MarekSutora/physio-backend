using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class serviceTypeHist2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedReservations_ServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "BookedReservations");

            migrationBuilder.DropIndex(
                name: "IX_BookedReservations_ServiceTypeDurationCostId",
                table: "BookedReservations");

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
                name: "ServiceTypeDurationCostId",
                table: "BookedReservations");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBecomingInactive",
                table: "ServiceTypeDurationCosts",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "DateOfBecomingInactive",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeDurationCostId",
                table: "BookedReservations",
                type: "int",
                nullable: true);

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
                name: "IX_BookedReservations_ServiceTypeDurationCostId",
                table: "BookedReservations",
                column: "ServiceTypeDurationCostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedReservations_ServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "BookedReservations",
                column: "ServiceTypeDurationCostId",
                principalTable: "ServiceTypeDurationCosts",
                principalColumn: "Id");
        }
    }
}
