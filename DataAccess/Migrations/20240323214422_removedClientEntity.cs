using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removedClientEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientNotes_Clients_ClientId",
                table: "ClientNotes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientNotes",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientNotes_ClientId",
                table: "ClientNotes",
                newName: "IX_ClientNotes_PersonId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "BookedAppointments",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedAppointments_ClientId",
                table: "BookedAppointments",
                newName: "IX_BookedAppointments_PersonId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Persons_PersonId",
                table: "BookedAppointments",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientNotes_Persons_PersonId",
                table: "ClientNotes",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Persons_PersonId",
                table: "BookedAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientNotes_Persons_PersonId",
                table: "ClientNotes");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "ClientNotes",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientNotes_PersonId",
                table: "ClientNotes",
                newName: "IX_ClientNotes_ClientId");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "BookedAppointments",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_BookedAppointments_PersonId",
                table: "BookedAppointments",
                newName: "IX_BookedAppointments_ClientId");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Clients_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99e927a4-de88-43d9-ac25-448bc06d7b0d", "AQAAAAIAAYagAAAAEHeLRCAPdVR+jAF3u6Bhzomgc/bFhz2jnYymobVHoMzG+FXLcZecjNXmpyXtx+kRKg==", "51e89629-7760-47f5-850e-2dd7658f457c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2713a011-09ba-408e-93ea-be676799f480", "AQAAAAIAAYagAAAAEM+94FxM2EDbtuSrhytYm6RJcNbiHP+IyKgSkWWrpB10tkEOWup4b3vW0fTooyl6WQ==", "df9e3613-1e9f-4df4-a504-10363016c50b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc099de-9c9c-440e-b7d6-7516e31a465d", "AQAAAAIAAYagAAAAEBVdAwPqIVWX9bSFWIQdeW/MmuZToEGn2SKSUXbuXyVPtBQXE3s4DSyacPC7a1Hbkw==", "46aa9fa9-1da7-48d3-a1dd-2027b66a85eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c156c2e8-8621-45ab-abb1-fdcdae8f9498", "AQAAAAIAAYagAAAAEB5d9HQLm1LGRp43fhjzyX4ZqGWmHBdxPRLe7c6HdcJWVNj4crZd81PrdRxpnoJ2Yw==", "b268cd91-5556-42b8-8d7c-e0dcc4dff4ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1520cdde-610f-4a28-9ed0-fdcce6a86f0c", "AQAAAAIAAYagAAAAEDl92b9ih63cqMgsr9S7pU7+3M8NKSzR0vgzZOro97rnYLPXGNfeaCjdfTAWICLlsQ==", "3d43379b-e41d-4831-8354-f5b0465e9569" });

            migrationBuilder.InsertData(
                table: "Clients",
                column: "PersonId",
                values: new object[]
                {
                    3,
                    4,
                    5
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientNotes_Clients_ClientId",
                table: "ClientNotes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
