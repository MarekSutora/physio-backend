using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "b5717850-2f96-4a9b-9151-14ffb6762dc0", "AQAAAAIAAYagAAAAEFzI8wIKSqRHAMevzZ8uEVWcLewwxJwMyh1RItHJsRbJtaKX7A+yse8Aw+0nET+7Ng==", new DateTime(2024, 6, 18, 21, 34, 12, 371, DateTimeKind.Utc).AddTicks(3071), "5164130d-60ef-48d9-8532-75f1e3ce19f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "d098ccf4-8755-4f41-b020-14e35eb517d5", "AQAAAAIAAYagAAAAEBZp+q7Pc5ovd5hU5VjnDKLmLjGnKKoyL3HKWCFJail3HqkKLdMRYHp826zYnUN7iQ==", new DateTime(2024, 6, 18, 21, 34, 12, 211, DateTimeKind.Utc).AddTicks(8498), "c5a2bc2b-3a40-4959-a973-2f451938ab1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "2ee3dbde-b835-4f84-b1ae-b2d3b5f2248f", "AQAAAAIAAYagAAAAEMxlN45qmXZqyqt3DSCHJfd6wN1wVbDf6sbvcZgxXktinEi7qY2xIoFbSXSCbNt7Pg==", new DateTime(2024, 6, 18, 21, 34, 12, 331, DateTimeKind.Utc).AddTicks(3041), "e273e939-323e-4232-bd55-d368dbab4275" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "a1933f78-e9d8-4860-8b48-e817fa4a0bee", "AQAAAAIAAYagAAAAED77RAzYJ/Upq/OAb2L0UqiPearxwVOuZ4vDz1YnJ8usEV7yBtrYJOQHLkULUrWZsg==", new DateTime(2024, 6, 18, 21, 34, 12, 292, DateTimeKind.Utc).AddTicks(16), "ed473f05-3b41-4f63-8dc4-73ad67ba1b4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "5ccbc88b-215a-45ca-a3c8-f731cdc11ef0", "AQAAAAIAAYagAAAAEAk3LLOlTlfL5S2pu8D3NfiRCGwoaLBDRrcIl4Pu+lolcG7giP2pd/ZC3gi++K5XNQ==", new DateTime(2024, 6, 18, 21, 34, 12, 251, DateTimeKind.Utc).AddTicks(9324), "0c72db44-406a-4fa2-b408-cc4cbf10798a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "47e4dbc0-0c71-4072-aa5a-822e11a3e394", "AQAAAAIAAYagAAAAEJpFK9bDC2eLZZ9fv7c1KFy13jy0ARhAR2JlKLF201D1tK1zPVxohhR7qQDJWmIbJA==", new DateTime(2024, 4, 10, 14, 56, 5, 772, DateTimeKind.Utc).AddTicks(64), "6ac11919-bd6c-4c27-b5c4-88ef748b5356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "c9e14ee1-78e4-44fe-8f38-0e5dabe323c9", "AQAAAAIAAYagAAAAECxB+0nPfRIwJAOUbw/D9Ic4WaGOK1lSk5inRRzl0R242DHUyZNADDq253dWwAg/pA==", new DateTime(2024, 4, 10, 14, 56, 5, 616, DateTimeKind.Utc).AddTicks(4818), "81702178-8e20-4e07-bc21-b48ee30dcdbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "b304184c-abfa-4cee-ad6c-bfc0553216ff", "AQAAAAIAAYagAAAAEEG5yeDWE78+VaoULDPI5NuGraPoh9CrjTptkYI3lQ/dFkhcRpTYDcgRL+ePX6pQEg==", new DateTime(2024, 4, 10, 14, 56, 5, 732, DateTimeKind.Utc).AddTicks(5456), "3ed56292-530c-4047-b3f1-fce3d49c9303" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "6b19d19e-98cb-4e1b-b28d-4f1d29af1f15", "AQAAAAIAAYagAAAAEIjd5n07YybKu1zWGQQkQEmilI1q6EIlmN/xnb8UdQnvsBWq6p5n8L1LGC3nfyxRhA==", new DateTime(2024, 4, 10, 14, 56, 5, 694, DateTimeKind.Utc).AddTicks(5626), "bd92a420-e499-47a0-9dbc-931ecf89b185" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "bf199220-4fae-4eb0-b1c8-f67264237d08", "AQAAAAIAAYagAAAAEFlrKNQLswrZ1c0mwjbYW004bRtljc/RYPBDHdLn6aJ8Y/4xTZhGuuqXKOuO9Cenbw==", new DateTime(2024, 4, 10, 14, 56, 5, 656, DateTimeKind.Utc).AddTicks(281), "f63f80c1-08ac-4df4-a8ba-736e5d2d63c2" });
        }
    }
}
