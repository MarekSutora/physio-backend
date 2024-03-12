using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class beforeDeployment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "893b0d2b-7a13-49f6-b356-00c5c8e4159c", "AQAAAAIAAYagAAAAEOcu1hPAShFAoy+PMgMyeWYdCrhl22xr0C6yiax3a8Vqd70uSQeF3O8pHQBlN9KOLA==", "ed58ceda-1e2a-412e-8547-7e8b70114847" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb137798-abcc-4668-8ebc-6c55a138cb76", "AQAAAAIAAYagAAAAEJ5zsgeaPnA/IjHQWa8MzRqskOSJ6PC8HbWw47GTYdLoAXw1/1CjVWuaY3oSu1sXpw==", "33b8ffb4-e528-4734-bd8c-40570310e794" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd1dd11-c402-44ef-9301-f3623216fd65", "AQAAAAIAAYagAAAAEPXUtlRxzosfammWslxR5/jl1tqfBxhuGTGXFVXIitRzxBvHfXDa9hTnF2q+0rg4Dw==", "e9a7cfbf-ad0f-49c0-9cd9-2ce84defb742" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46772e67-218e-44c9-967a-073ef488b13c", "AQAAAAIAAYagAAAAEDaC9fQVvpS0eYhn5PURbzuO/zDyZhcbd3NCOV1lNAPKvQQyf3a1WwVcDet260Uiqw==", "74e75259-7652-4a96-90fd-cef4ab9a813c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b37c7f93-2f02-4b3d-b7ea-daf6b302a066", "AQAAAAIAAYagAAAAENmn/xKMpBgR3wWrkshOZO/MSIA18WwxpE3eRjYVokAUOb1+ikoAwEJW3eahRmKHYA==", "4586b6f6-8bd5-4c8a-9df1-df1b4c2a049e" });
        }
    }
}
