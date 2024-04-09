using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class astdcChangedBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "AppointmentServiceTypeDurationCosts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "05e54b12-023a-4e4e-ba9d-7a8b397e79ec", "AQAAAAIAAYagAAAAEPsujVAh6Z20p/Bht4MCzMqvYFxso1+TXJdKFtyh3sshLQN5tMYOH3dyerozZHaJlw==", new DateTime(2024, 4, 9, 21, 26, 0, 535, DateTimeKind.Utc).AddTicks(8152), "9e9bf0a4-f218-42a3-a364-197edbcf1c00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "812aed82-0649-45ba-af8a-c035e58557a6", "AQAAAAIAAYagAAAAEPfn5BO6Vw8LgkTXvlQPi5LnoaLYQTXy0q/XAwuKj8I8xUUcPwgNoezRVfRMyxADmg==", new DateTime(2024, 4, 9, 21, 26, 0, 377, DateTimeKind.Utc).AddTicks(8206), "aae463b0-49a4-4584-bfd7-48fae8623f71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "1ab63333-59d6-40d3-9eaf-3f59f7c3e266", "AQAAAAIAAYagAAAAEPMKipcNaXE8Lloojmgt+JfBx960DCZ5h8wHY+ZwoFnrB3CTcSviF2EohernDn1t5w==", new DateTime(2024, 4, 9, 21, 26, 0, 495, DateTimeKind.Utc).AddTicks(9659), "9cd4a39e-3a76-44f1-b863-6ab179a59e45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "06fc2d68-0627-49ec-a7e0-7e0cb35404d6", "AQAAAAIAAYagAAAAEIuu1+6QyPxbqglIf3xauxYf2N2Ksuil5EK3skDszjfrizcBQVBZDRGuPgS616mdYA==", new DateTime(2024, 4, 9, 21, 26, 0, 456, DateTimeKind.Utc).AddTicks(3988), "d215b30a-17bf-462b-bd7b-313ea0416838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "0d08a389-9840-43d0-ae76-b3a7ce565e87", "AQAAAAIAAYagAAAAEDFgjy/0dAD/A0zvOqJpaGqKMUhoyX2Bp6o/dwxjYiwzR6FmGx0160UQCFXYzw8L+w==", new DateTime(2024, 4, 9, 21, 26, 0, 417, DateTimeKind.Utc).AddTicks(8392), "f305bd93-db6e-4f93-be32-4f550aacbfca" });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts",
                columns: new[] { "ServiceTypeDurationCostId", "AppointmentId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts");

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
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "AppointmentServiceTypeDurationCosts",
                column: "ServiceTypeDurationCostId");
        }
    }
}
