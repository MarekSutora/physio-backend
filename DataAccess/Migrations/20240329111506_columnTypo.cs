using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class columnTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuccessfulyPerformed",
                table: "AppointmentExerciseDetails",
                newName: "SuccessfullyPerformed");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuccessfullyPerformed",
                table: "AppointmentExerciseDetails",
                newName: "SuccessfulyPerformed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "85933212-8dfd-418b-963a-41f62218ab10", "AQAAAAIAAYagAAAAEAhS5elXU3aG5c8Vovif+EDgzjpXgS5NMthPryMgNPnUswwTrK1B7JhRLqiomeeHHg==", new DateTime(2024, 3, 28, 21, 0, 31, 38, DateTimeKind.Utc).AddTicks(3875), "b1dd6080-b351-4241-88d1-9a5de84d28e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "f7a71802-7e59-4e96-a7b3-be5e4ff1d020", "AQAAAAIAAYagAAAAEDB7O4XKD+EfpzgLe/puV7LtYvFSdnvpuwokldJheQPsSl37zdwNHGfxOOPIKxhYew==", new DateTime(2024, 3, 28, 21, 0, 30, 873, DateTimeKind.Utc).AddTicks(9304), "33d31421-c93c-4cfd-a471-709545eb89fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "59bbb5fb-1121-48b7-b51a-70f05a2b5a44", "AQAAAAIAAYagAAAAEB4AEPkpZr+wR4bD4rfABEeqlkViVrirEqi47YNliVsQH1k/IJESrVn4ZS0LwQDEKQ==", new DateTime(2024, 3, 28, 21, 0, 30, 996, DateTimeKind.Utc).AddTicks(8526), "93db6beb-8421-4c0e-865d-40ecf989d487" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "ae0418de-3cc6-45fa-9b11-b5ddd9bb8177", "AQAAAAIAAYagAAAAEAIbanE4MkyLrOr96QOPPOGyEYTVldUaPTB2iwy9wEY9lDhruS3pfHYkKAohzFJP5A==", new DateTime(2024, 3, 28, 21, 0, 30, 954, DateTimeKind.Utc).AddTicks(6978), "62d2f499-b71f-4d93-b457-d3fecf49b82a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "1e41a1f1-43eb-4a5d-93dc-c31f7e9291f6", "AQAAAAIAAYagAAAAEFq7UdBEEz6lnoV16GYy3+Z2oGJ3Yh56XseiyWsdmSXPBtGrIMQfLxkUsJoMXZjbUQ==", new DateTime(2024, 3, 28, 21, 0, 30, 914, DateTimeKind.Utc).AddTicks(5444), "b3e91b39-4aea-4efa-8c9c-3a03deae0c19" });
        }
    }
}
