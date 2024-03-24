using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removedUnnecessaryIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3d496c3-1b00-4fe2-9dd2-984323a80f58", "AQAAAAIAAYagAAAAEL/mg6b6vhpLMl5SmbCvZZNIcjukTbiMUxNLwrmrKpZTHvuOuwLMHaqNjC7kuZfvVA==", "45b328dd-6d49-4a74-be83-a3bb2972c565" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d334489d-f630-4abd-a535-4802d908da61", "AQAAAAIAAYagAAAAEFWARv+/pBTDiVnPqJ3AeosnuBZMpwMptQXNus79JZYtGgRUKo07bGLmEYqixnoicA==", "a04b3ccd-d071-4155-9c0b-a23828aac533" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74d59542-c53f-4871-9817-2881bd367b3e", "AQAAAAIAAYagAAAAEDDrEe+8XiRUeUYB05e18evHpky0N+eCjpfqMkebgk/DENblRzOf8cBgwyCMhdVGMg==", "735e3b20-7ef0-4f61-8ab9-712ebfeb86cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c051afd-fe2d-4c62-982d-e831bf23d2ba", "AQAAAAIAAYagAAAAEA1aSmw+GlUW5mnUn5N9QO2SA/j7Wvf2ZJqeomR2BPTM8IMAlLTsR7+W+ojarj0KQQ==", "b6b394c6-9ff5-4bad-8cf8-37536e79c0e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d1b745d-881d-4868-84d2-4717049bb5e8", "AQAAAAIAAYagAAAAEFWODg17kc7FRL9iqA/Z1994m0qjowz//zAbnlw15kybpGC0kJy6NS5Z6Gwf6KY8Og==", "e31bd5b1-7650-4e5e-b5c8-fab924f8a42b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8967a087-34ac-497b-9737-b7388eb76741", "AQAAAAIAAYagAAAAENxRPWjXpkDBgPknONtPMHjIQQbErkYdr07gPpJ0TsSkG06QtzhQk4RcdlKO2oEcNw==", "4c3cd68b-d751-4649-a70d-a38c4afee640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a1964e7-9de3-4025-9ba4-ad2cbd324cfa", "AQAAAAIAAYagAAAAEDNRYF6H934a9gAlJAg9JtembW+ofArj5E7EOAan1YG7vwZoBA/9unfByZjVOFcppQ==", "fd806ad4-578f-488d-af88-d0ad083d89a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab16a20e-b8c2-4dff-9fe6-174f5c08eddd", "AQAAAAIAAYagAAAAEPD5XizV9a/Q9agh64uQd9aBtfyGL+OOxtsOKQ4zyf4kap3wtGyatVnon1cj812aQQ==", "8e1835d4-da93-4432-bff9-998f8d3a78b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31d9e855-b20b-4b00-8b2c-98772873ef51", "AQAAAAIAAYagAAAAEPdtU8lRAMCLnsdfxFEB0BPZwgpSV9TxMV12Cn56UiSNh0KVqDthwNrz8P2DchUR7w==", "8b0c3e90-5830-48dc-9a58-f7793ba6a937" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd2724ee-739e-4fb1-ae7c-9d2c028a755a", "AQAAAAIAAYagAAAAEMuTa/H4FLxmyjr8ktnVGCjU7JLml+4/+42huvNx/Zk0Oq36IBzAevqeS0RG5SxZXQ==", "8c0aaa77-faaa-42ab-9c92-d17013b5be10" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");
        }
    }
}
