using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cb137798-abcc-4668-8ebc-6c55a138cb76", "admin1@example.com", "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ5zsgeaPnA/IjHQWa8MzRqskOSJ6PC8HbWw47GTYdLoAXw1/1CjVWuaY3oSu1sXpw==", "33b8ffb4-e528-4734-bd8c-40570310e794", "admin1@example.com" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e2fbfa-680b-45c8-99f2-4e76adacc60c", "AQAAAAIAAYagAAAAEMRBt7+rg2DynHx3GW5St6gbbWbGSNYf6dUyYC/BPMO4jNeyKll59whTFFu0McK+NA==", "cb79886f-c559-49d8-b76d-4b940afc931a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "10d5729d-f69f-410b-8e08-ca6ee8763c8f", "admin@example.com", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKyaoHsQrFg6VqQHNuhpvv+tn/dOjL1RniaBD+ecyX30ZAQrW1KS9Ykc90Zli/YKbQ==", "9576e59d-9b55-4c1c-ae34-dfb047b83f7e", "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f68840-611e-49aa-a199-7d3beaa0daf2", "AQAAAAIAAYagAAAAEA5KLl/CUw3rGBmRPN8VSzMNLAe4gPSHzy79cT1qVl7TJ+Ylp5oPEJVpfa/lZ219kQ==", "54569759-51b6-43e4-a2b3-7e508de4a643" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0eeadc9-2add-4349-a6b4-9785402b123c", "AQAAAAIAAYagAAAAEJiiF1Dl3/yUaoCusECWcrRjXopR6+aKuWAyMUk/g/QrPMOGUjrNt+t5pMssRSxtcg==", "7c178912-d976-4f2d-9339-3e900bbd6eef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10fb76e3-2f31-4456-830b-8491aa589055", "AQAAAAIAAYagAAAAED1jsHPX+lK9AyjGTNcEmajZfLBpvUk7G+T5Ovqf5PHnrTFjkSh0caEAVww/eo/TUg==", "f1f881ad-418f-43d1-af07-e2d63215c9a0" });
        }
    }
}
