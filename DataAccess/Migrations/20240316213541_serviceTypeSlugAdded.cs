using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class serviceTypeSlugAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e109f1-da4a-4da8-903f-f6939ae284fe", "AQAAAAIAAYagAAAAEJyiMVojvsqAARNpxm9aeAbiZDW4mbRKlOxMxrAKkrSATSvceu5IqUZzA7bGMP0RJw==", "497f2aa4-ebcb-4873-adcf-fe6868098d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4295a043-e836-403d-8d7c-9b3bb24adfb2", "AQAAAAIAAYagAAAAENHadkXJdSG14xO7Y5hVGHyoztsmpOIn5poYAx4Tl8+v7YFL7QQ+VsQ59U2YFeAzSA==", "63776fa8-45ae-4f3e-87cd-9d3a38f4c467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6becb84-1ea5-4373-bbaf-d9ba6086a453", "AQAAAAIAAYagAAAAEEMa+sh7tn3M7jG+5/6yidfVlWQJ4JL9lWtFG/TEg6rDcctXNL17rRVud3E1tCSX7w==", "75b99927-7405-4621-aa9b-566bbbab86d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8fc14bd-0315-41ff-a891-112fbc0db76b", "AQAAAAIAAYagAAAAEIWe2+vXIY43w5B58kfq9SOisOr92DoUiD9SCcozuRi3tN/Xj72w5zsBCc9Te3JYEA==", "2fa2b21a-557d-4459-8c7e-d21ad4df9436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18eb8773-f0f5-4d10-b0d0-0e54197a0ad5", "AQAAAAIAAYagAAAAEH2qoZVH6eizSBrPpJyjbd9oP4A/WIWmYf9oc0ygI/LAaHr0c99IVCRxU8jidlgoBw==", "5dc694c9-da79-4f53-b9f0-53ab412b05db" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "ServiceTypes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7768869f-7cd4-4d89-9092-cf290a35b4dc", "AQAAAAIAAYagAAAAEF/hS3ffaZkI4CUEi1L/i8pbApacxiFK5/ORNdYowya30pygpKRO1Zg/etB7LuYG6Q==", "9a496fb6-b250-44e3-8b08-3755e5c155bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b801ca4d-d9b5-41f0-9060-286d7f23f182", "AQAAAAIAAYagAAAAEBNtiOPGtIE6o5I91WzTQvhT5wLnkuM9T/ZdoTVwy7Vz03snnNe/JoZt+Ux7mW7gfw==", "1bb71553-f217-45af-b6c1-d2c7dec0c341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50e5c8ac-6ae2-4849-b748-bef0fa2b1a39", "AQAAAAIAAYagAAAAEB1DDLG+EcEeCdKYnmVW9p+cdgEi28MN8c7VxAaenJjSJTnzjY33gSUsBTY7Nsljqg==", "106471bb-3112-4270-8d9a-ca265eddba10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a1f2d41-f067-4442-900a-fc7e50718d7f", "AQAAAAIAAYagAAAAEMqd6yCYztRUHJjM5RSXw4ynV8jSo7UVreN6kRNda2WNuLF3Xcb4LimZ9O7GLqVGyw==", "467d439a-1c9c-400a-b8f7-916977b80eba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ff66004-5ba9-4799-8804-5db5afba68cc", "AQAAAAIAAYagAAAAEHCuYaigH2B+0K//1xPtziTYb0ly/33ecv9Xlfaug1X5gtE8D3hcUAK0Fl4uWBb3ig==", "3a275508-d0ca-4b12-b812-991c7bc5a946" });
        }
    }
}
