using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class serviceTypeDateToNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f411e0ea-e26f-4bf5-92cf-ecb867406cd4", "AQAAAAIAAYagAAAAEE4czwQLVWIvDq40mACa9zGflnFBXFnc+vvKTbBovUjKowbRD7PKIDyaP9QSM2Ef6A==", "3f5fac69-b398-463e-9c00-aa3a2ba73008" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40f438ba-5f3e-49ed-a4a4-ea766deba087", "AQAAAAIAAYagAAAAEDMu6MTeAOd+z+kePslZ41UKzYagmKzDl6mCA8sxv5Cc9bCb7gKQ7t2HwUPc0h1EMQ==", "75797fe9-0148-4850-a731-dd88753ce293" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aa7b07e-7629-49ed-a5bd-4bfdfbfb3455", "AQAAAAIAAYagAAAAEEPnafCDLG+ptQQCJH54FznLdqv1OFs1VKzEPstEFgSTMO9uTlFc3hc5T0BEp6XYsw==", "a84f49bc-7062-42c1-a001-89cdfd73af77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1cede3b-495e-4ba4-9d7d-fffd1723c44f", "AQAAAAIAAYagAAAAEN+g1pIKErOnJhdlECPbZTVGbgYxvmvO4d04bckUSk80UGymFZO1zFgBV0J107ay/Q==", "14fb52c7-3a82-4767-8756-ead31702726d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d144a35b-71d8-4837-b4da-228e0f7a426e", "AQAAAAIAAYagAAAAECW8okXGDOcn5ui5psBozeDLx406AyyxlB50JijlYJxHTR9ImRm+iEJ07BR1bnAbnA==", "aaa628e8-bcaa-43aa-9faf-152d7bc70d90" });
        }
    }
}
