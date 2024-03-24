using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removedUnnecessaryColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaadfeba-6b53-4ed3-a010-9184ba4a31eb", "AQAAAAIAAYagAAAAEMcaF0QyhjB3IbNDKnR4mQrskTQpxvrZkwOmt0rIUBp+ZobZ4M8DEdFKgzcw+PYS8w==", "00947511-c4e8-4aa0-adb1-fcea54bc0a77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0946203-96fd-4656-9647-571c5e3907ab", "AQAAAAIAAYagAAAAEGoHqQTmJY9HVj7Um0JsZ5sDk6qzwY/SQUqnFsZcz+vNRb29FZfhhNpvhT3R4jDUAA==", "042e361f-bb82-464e-b84a-8d6a4d68d50b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09fd93d9-a07e-4164-a4de-5ea083eb7add", "AQAAAAIAAYagAAAAEB8Zge21mkhaAmJKPzGXJUq0KZl1CkhNQB6qDFAV1wU6if6PpJ2GaFPOzZ7aH+1n+A==", "d9eeee1e-2a53-4b69-ab00-ea346cdaab9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4e880db-7bed-474c-9029-ac668b58c720", "AQAAAAIAAYagAAAAEPJAqljgj27kz7KoF9g2+2QgzzFVXRayNjOlvnq6b4yHPLJa84lTnuIXyhngCkq78g==", "a59a0709-359e-46ee-a5f8-dcd1e60b07e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5cf4380-7a70-4822-8829-97160bfd454f", "AQAAAAIAAYagAAAAELrcpTdnprSxny5tnE36tiXlSqM2gY+VMQv4Lpf95r1O9PK9sic4cZCjMU5SJD9p8w==", "4ecdbbc4-f715-4e3b-885b-3c37032a9111" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { "e3d496c3-1b00-4fe2-9dd2-984323a80f58", "AQAAAAIAAYagAAAAEL/mg6b6vhpLMl5SmbCvZZNIcjukTbiMUxNLwrmrKpZTHvuOuwLMHaqNjC7kuZfvVA==", null, false, "45b328dd-6d49-4a74-be83-a3bb2972c565", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { "d334489d-f630-4abd-a535-4802d908da61", "AQAAAAIAAYagAAAAEFWARv+/pBTDiVnPqJ3AeosnuBZMpwMptQXNus79JZYtGgRUKo07bGLmEYqixnoicA==", null, false, "a04b3ccd-d071-4155-9c0b-a23828aac533", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { "74d59542-c53f-4871-9817-2881bd367b3e", "AQAAAAIAAYagAAAAEDDrEe+8XiRUeUYB05e18evHpky0N+eCjpfqMkebgk/DENblRzOf8cBgwyCMhdVGMg==", null, false, "735e3b20-7ef0-4f61-8ab9-712ebfeb86cf", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { "7c051afd-fe2d-4c62-982d-e831bf23d2ba", "AQAAAAIAAYagAAAAEA1aSmw+GlUW5mnUn5N9QO2SA/j7Wvf2ZJqeomR2BPTM8IMAlLTsR7+W+ojarj0KQQ==", null, false, "b6b394c6-9ff5-4bad-8cf8-37536e79c0e2", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { "2d1b745d-881d-4868-84d2-4717049bb5e8", "AQAAAAIAAYagAAAAEFWODg17kc7FRL9iqA/Z1994m0qjowz//zAbnlw15kybpGC0kJy6NS5Z6Gwf6KY8Og==", null, false, "e31bd5b1-7650-4e5e-b5c8-fab924f8a42b", false });
        }
    }
}
