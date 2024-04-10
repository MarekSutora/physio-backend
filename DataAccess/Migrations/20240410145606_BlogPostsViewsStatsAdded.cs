using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BlogPostsViewsStatsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPostsViewsStats",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostsViewsStats", x => new { x.Year, x.Month });
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostsViewsStats");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "05e54b12-023a-4e4e-ba9d-7a8b397e79ec", "AQAAAAIAAYagAAAAEPsujVAh6Z20p/Bht4MCzMqvYFxso1+TXJdKFtyh3sshLQN5tMYOH3dyerozZHaJlw==", new DateTime(2024, 4, 9, 21, 26, 0, 535, DateTimeKind.Utc).AddTicks(8152), "9e9bf0a4-f218-42a3-a364-197edbcf1c00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "812aed82-0649-45ba-af8a-c035e58557a6", "AQAAAAIAAYagAAAAEPfn5BO6Vw8LgkTXvlQPi5LnoaLYQTXy0q/XAwuKj8I8xUUcPwgNoezRVfRMyxADmg==", new DateTime(2024, 4, 9, 21, 26, 0, 377, DateTimeKind.Utc).AddTicks(8206), "aae463b0-49a4-4584-bfd7-48fae8623f71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "1ab63333-59d6-40d3-9eaf-3f59f7c3e266", "AQAAAAIAAYagAAAAEPMKipcNaXE8Lloojmgt+JfBx960DCZ5h8wHY+ZwoFnrB3CTcSviF2EohernDn1t5w==", new DateTime(2024, 4, 9, 21, 26, 0, 495, DateTimeKind.Utc).AddTicks(9659), "9cd4a39e-3a76-44f1-b863-6ab179a59e45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "06fc2d68-0627-49ec-a7e0-7e0cb35404d6", "AQAAAAIAAYagAAAAEIuu1+6QyPxbqglIf3xauxYf2N2Ksuil5EK3skDszjfrizcBQVBZDRGuPgS616mdYA==", new DateTime(2024, 4, 9, 21, 26, 0, 456, DateTimeKind.Utc).AddTicks(3988), "d215b30a-17bf-462b-bd7b-313ea0416838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "0d08a389-9840-43d0-ae76-b3a7ce565e87", "AQAAAAIAAYagAAAAEDFgjy/0dAD/A0zvOqJpaGqKMUhoyX2Bp6o/dwxjYiwzR6FmGx0160UQCFXYzw8L+w==", new DateTime(2024, 4, 9, 21, 26, 0, 417, DateTimeKind.Utc).AddTicks(8392), "f305bd93-db6e-4f93-be32-4f550aacbfca" });
        }
    }
}
