using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class blogIdAddedBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BlogPosts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "Id");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BlogPosts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "Slug");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "d3d23431-ef57-4b1d-adcc-cdac2e7397a5", "AQAAAAIAAYagAAAAEOdc2prjZSdUrWI0OqETPfrznx7waM5lOB8eFyRqSm6HB09x1zp1fNyQCPdTEYNxOA==", new DateTime(2024, 3, 29, 11, 15, 5, 588, DateTimeKind.Utc).AddTicks(1828), "4f2f5044-dc25-4faa-ad35-d6524825eef3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "fabd06ff-9393-4f0f-ae72-9576977a7b24", "AQAAAAIAAYagAAAAEL8nytPX5oWi/oeeWSZ05BAddxm/jPz2LepIS9qTz8hGDyyvFrfcF+RvnRANxB7KOA==", new DateTime(2024, 3, 29, 11, 15, 5, 420, DateTimeKind.Utc).AddTicks(966), "917596d0-5ca5-4a65-940c-e90fb686175b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "89e20ac4-29cb-4114-92c1-c6cb0b963268", "AQAAAAIAAYagAAAAEAr+q+VS5Hwr5p9mjMCPJ5CA9JpYgVo8CML+/Mt77dRZZW/Lba5saK1Xsf7U5Za1Fw==", new DateTime(2024, 3, 29, 11, 15, 5, 546, DateTimeKind.Utc).AddTicks(639), "af7d294f-b9a2-49b5-9f8c-3deb1bc856b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "cdb33dd3-9ec8-4dea-a0b4-e6d2d2f514b4", "AQAAAAIAAYagAAAAEOeQb6xWul39lfZL9j40ljz0s3+zEFSqiZuXeYZYrfiafCwdeoxB+7Lk/NdsyZLrIA==", new DateTime(2024, 3, 29, 11, 15, 5, 504, DateTimeKind.Utc).AddTicks(193), "6ce4760b-9506-4f09-81b8-0eab69a2177c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "991e58c6-44e2-4a21-a806-cba404b67f0f", "AQAAAAIAAYagAAAAENMgnYQd5smUyuoQ63WAkO+hJ0ObKH9MVqx1d77/VW8GDj7nE7l9CczNSk0cebjTlA==", new DateTime(2024, 3, 29, 11, 15, 5, 462, DateTimeKind.Utc).AddTicks(6604), "b29bfc5e-9bec-46c2-83cf-9013890cddb2" });
        }
    }
}
