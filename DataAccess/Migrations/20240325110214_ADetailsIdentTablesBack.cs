using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ADetailsIdentTablesBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentExerciseDetails_Appointments_AppointmentId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "AppointmentServiceTypeDurationCosts");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentExerciseDetails_AppointmentId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "AppointmentExerciseDetails");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "AppointmentExerciseDetails",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<bool>(
                name: "SuccessfulyPerformed",
                table: "AppointmentExerciseDetails",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "RestBetweenSetsInMinutes",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RestAfterExerciseInMinutes",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfSets",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfRepetitions",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DurationInMinutes",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                values: new object[] { "ac779c36-5088-424c-8375-4ca80c978876", "AQAAAAIAAYagAAAAEAikEfgQmzCXV2XPGe3QWhReHm5+jrg76hOd0PM38BFgmgKMYHReJxcHCv+3l1PcOw==", "75245dce-14be-4702-9995-8acfa81a1bc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45bd5e1b-56a9-4d53-a561-ee6c0ec8d92d", "AQAAAAIAAYagAAAAEEXwaD+fmfn4pH7o0L00JFpN/ttHuIWfzFTIU6WYnykSJyOVEmknXL8RuK/3AqNHQg==", "8b83c77c-23ed-469f-9ffa-e578631e3de0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a696286-133c-4c09-ba99-a6bab736cad8", "AQAAAAIAAYagAAAAEETn3JAz4ESoFfaPojK08iW37tTrqGLM9n5AGUbsQAvfTUopT2dDgKgYxsnW1SVhLQ==", "b5e85045-1dd6-4129-ae7b-91202fc85411" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e5e2b2d-182c-4005-810e-4e5f2163eba8", "AQAAAAIAAYagAAAAEIJ8hWMbxnJ8lZ06fgl856rA37ThuNGcww6BepBbkjvHSVR5C0IETkBdzYX4G3TKyw==", "79c3564a-656e-4ce4-a3f6-6b8dc1eb45f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a693675-cfba-4d48-adaa-6f7f8ab39891", "AQAAAAIAAYagAAAAEE+V2mMlVS2soU6t+G4ticZsoFK8mwk7SIGgdvzufHkHiQ7HTmCeQ3+01g8lAbXNpw==", "986f11a3-69bf-4f6d-becc-94a921e3e80e" });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts",
                columns: new[] { "ServiceTypeDurationCostId", "AppointmentId" },
                unique: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "AppointmentExerciseDetails",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SuccessfulyPerformed",
                table: "AppointmentExerciseDetails",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RestBetweenSetsInMinutes",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RestAfterExerciseInMinutes",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfSets",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfRepetitions",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DurationInMinutes",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "AppointmentExerciseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCostId",
                table: "AppointmentServiceTypeDurationCosts",
                column: "ServiceTypeDurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentExerciseDetails_AppointmentId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentExerciseDetails_Appointments_AppointmentId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
