using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class astdcChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts");

            migrationBuilder.AlterColumn<string>(
                name: "IconName",
                table: "ServiceTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "fabc38f0-7605-4357-82ad-f0d0a9fa0c7f", "AQAAAAIAAYagAAAAEOJFD4Fxz29hGvtU/AwcoRWqAEcLMi00X9yHzwOWgqUW0i23yoGl29pTZdDi+FJ/7A==", new DateTime(2024, 4, 9, 20, 19, 4, 588, DateTimeKind.Utc).AddTicks(9410), "cd16e3d8-cd24-4893-ac62-4039f6dec614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "7feccffd-aa13-41b6-8c8d-4f71e27a169e", "AQAAAAIAAYagAAAAEMnlkj9a7bHIF+chvnvwWXMJwsIFQNQJ1yvd7yI4P482kKMvjGI4Eyb7g1gQaPYMpg==", new DateTime(2024, 4, 9, 20, 19, 4, 426, DateTimeKind.Utc).AddTicks(7731), "44a90ff7-121c-43cd-a7a4-ea1490e65e28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "03a5c32d-1624-442a-abe3-eeab6eaa0571", "AQAAAAIAAYagAAAAEEk4ZDY5LGHuCLf4fDoDb/s6QfVRMX1Ru0Zd5WoxoyAw8kHuM3p3aY7D15nHA4jNmA==", new DateTime(2024, 4, 9, 20, 19, 4, 549, DateTimeKind.Utc).AddTicks(2729), "1a640f1e-0b9b-4e2a-888e-ba4e3ed34758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "597db75b-09ba-40e6-bef2-67b3fa881e27", "AQAAAAIAAYagAAAAELDvdZLWFFSTSHP+5dzAogo5VEhWme99mpDzxZgvrYDQJ/bPSxD3ZD0sFnKpktprdw==", new DateTime(2024, 4, 9, 20, 19, 4, 502, DateTimeKind.Utc).AddTicks(7368), "4b4fe74d-1636-4576-8e14-a8baa7973530" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "951c499e-f288-44ad-a8c1-e91e28a81963", "AQAAAAIAAYagAAAAED10AyLDLvLrrhg7Nbd5LTSUmX8ztmbUtkU4xvYlXFP+30XP3xTBka21sG3EjeFWTA==", new DateTime(2024, 4, 9, 20, 19, 4, 464, DateTimeKind.Utc).AddTicks(1973), "04dc2043-dc31-4fb0-ade6-6c154ee08eef" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_Slug",
                table: "BlogPosts",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "AppointmentServiceTypeDurationCosts",
                column: "ServiceTypeDurationCostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_Slug",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "AppointmentServiceTypeDurationCosts");

            migrationBuilder.AlterColumn<string>(
                name: "IconName",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "08132109-3ffc-4612-a417-6c1f79be703b", "AQAAAAIAAYagAAAAEFr/rJBUFb9psqEY2VglZkZLtv50k4KiUpBAfzG2HRsgLGHrLvzl+d+uidJiuzwePg==", new DateTime(2024, 4, 3, 8, 1, 30, 657, DateTimeKind.Utc).AddTicks(7927), "e28a3502-29e7-4e27-95ea-d50e8d5ba4e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "b5e23d57-fb7a-4ed5-b1f6-45726ebfe60f", "AQAAAAIAAYagAAAAEE69mSgFmu++vsL5McsXmzyw99WVNRM1VaMZLtKnqTb5bFFeIoATV3iXywG+NOe/Hg==", new DateTime(2024, 4, 3, 8, 1, 30, 483, DateTimeKind.Utc).AddTicks(9303), "362f07d4-cdb5-4636-96fd-eb330629daba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "fc2bba0d-9b23-452a-8829-b9e13c9c7a5b", "AQAAAAIAAYagAAAAEEgVfzIMxCY/KgSuHYF/LTXyPruyQZ9FUxlYmZYnRUW2rlok3BzU4v8TIFwrVFD+rQ==", new DateTime(2024, 4, 3, 8, 1, 30, 612, DateTimeKind.Utc).AddTicks(5133), "a3ca22c8-8707-49b5-b6d9-cd96299085bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "69d73e5c-1f32-4df1-8347-8ae4f29b489c", "AQAAAAIAAYagAAAAEJFzkEpjl/keclKlXp/GjpVw1cRq+rogA5ZBE3B4Ti3bGTpOjF6yy5EXaZOYLcRkUA==", new DateTime(2024, 4, 3, 8, 1, 30, 567, DateTimeKind.Utc).AddTicks(7272), "a26be4fe-4d97-47dd-9e07-63b1d1b05562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "6a8023e7-97c4-4ff9-887e-143bfc64bf20", "AQAAAAIAAYagAAAAEB8xA6LWGU1R683p/t/hmiKrdWab4LpanyxDLr6Jx+W92IZqqEVdAWFzlhEbR0T2zg==", new DateTime(2024, 4, 3, 8, 1, 30, 527, DateTimeKind.Utc).AddTicks(6126), "a97a8e07-f9dc-40ec-90b6-78b6d79311e5" });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts",
                columns: new[] { "ServiceTypeDurationCostId", "AppointmentId" },
                unique: true);
        }
    }
}
