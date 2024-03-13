using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class STIconImageAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconName",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconName",
                table: "ServiceTypes");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ServiceTypes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd0ba43a-7f45-496e-a726-10dc98e89289", "AQAAAAIAAYagAAAAELpvEYRHO+tG6N+65mm4gL9+0POrV6wEtn6iUufjDeZo3NuFj/Xzzkq1Stihm6ntTQ==", "9fb05718-47ec-421f-aac1-b6f6cb0eb4ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6f3f1db-1988-42c8-b182-d2b2a3b90c19", "AQAAAAIAAYagAAAAEP3QBblPXrmF9/pl7RIbanf+cUL1Gt1V2nP1kfQrV9rznnUNYKnmY8iyEPTyWMro6Q==", "8cc540bb-9297-4cae-b9e3-83bd9db57174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da01f067-efc8-4f39-98a7-11a546e4aecf", "AQAAAAIAAYagAAAAEB9o2bOWt4hjSEeEO7KPoIIm1hiO48pdtY3SKHUjEPubpwIouPAMeGjKg33dRupzQg==", "25d91cf4-b17e-4acc-a9e8-98b76859d699" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a499fdb-33cb-4e8b-ae29-4ba980043d00", "AQAAAAIAAYagAAAAEJBE/XJ3nzFkmVhNqXS/2QKiu90zRI1TK322DCFqtP8dv5w+rGV+b4ujJUh3LqfppQ==", "2df4660a-6238-4c22-afed-c9ea053954fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b05c22d5-e22b-4b4d-9c36-53a6f8fe17a5", "AQAAAAIAAYagAAAAECsIVaU5uUUUSe1HC44lUWaOd4+Es8IGAXCB42Mr1UVJx7KiW25CnOQ+ewr1frO9mw==", "b7757d14-3762-4f86-a95e-cda4dcb3b558" });
        }
    }
}
