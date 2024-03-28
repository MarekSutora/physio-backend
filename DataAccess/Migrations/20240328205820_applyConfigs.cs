using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class applyConfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentExerciseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.RenameTable(
                name: "BlogPosts",
                newName: "BlogPost");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "ServiceTypes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ServiceTypes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HexColor",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "#14746F",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "ServiceTypes",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ExerciseTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "DurationCosts",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AppointmentDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "BlogPost",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KeywordsString",
                table: "BlogPost",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "BlogPost",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "BlogPost",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost",
                column: "Slug");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "803d672f-0057-456d-9186-2b269e8eeb80", "AQAAAAIAAYagAAAAEN6C4Hla+RIquWvhHx0bF8pQrQ3YH/FPIBCQr2LyILzLSdSzwYivZ4vs/g7M73/zvQ==", new DateTime(2024, 3, 28, 20, 58, 20, 271, DateTimeKind.Utc).AddTicks(7316), "f08c5246-b668-4de0-a105-5ee36bdffd2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "89d2adbb-f40e-4053-8a5e-ab94ed72671c", "AQAAAAIAAYagAAAAEFnhKP3E4Vl7ivcOsfS+9yBaG6gOhKpdWLEh89r9Nmz1z2lpfoDbzMcsSlttd7qdzg==", new DateTime(2024, 3, 28, 20, 58, 20, 109, DateTimeKind.Utc).AddTicks(1434), "51dec330-6016-4b9c-9d9d-73e3b8e82bfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "7d375774-7f23-4411-a8d1-7b88cc896217", "AQAAAAIAAYagAAAAEBogKdDcBQd0yVFSoVC4aKKAXusLPIsa6LezBWw7tNaorIQssW6lZCpz0fQHjW6xng==", new DateTime(2024, 3, 28, 20, 58, 20, 231, DateTimeKind.Utc).AddTicks(6621), "d8bf09fe-b00a-4032-8831-c65bfe8e7098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "2fd35aab-b586-415d-ae26-2532d3eddfdc", "AQAAAAIAAYagAAAAEPTy3DE/WDcdDXK+r4OudOjuZu9yWUl/BnKQd4Pc0YEes0K3yt9NPUHzxq/EhUyAAw==", new DateTime(2024, 3, 28, 20, 58, 20, 190, DateTimeKind.Utc).AddTicks(6650), "ba0d9ffb-13b5-4a92-9129-7a1613918cc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "5e29ee30-1d43-49fd-a462-41ef4a2cfdd9", "AQAAAAIAAYagAAAAEG5o5l0WFx+8v0TwSM0u+CKYI0+rR3no065c60vI6D60lNuUv6qtSQZe50qfprlbVA==", new DateTime(2024, 3, 28, 20, 58, 20, 149, DateTimeKind.Utc).AddTicks(7751), "564a1f8a-3ab0-4b7e-8967-9d3ebdec4889" });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_Name",
                table: "ServiceTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_Slug",
                table: "ServiceTypes",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_AppointmentId",
                table: "AppointmentDetails",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_Title",
                table: "BlogPost",
                column: "Title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ServiceTypes_Name",
                table: "ServiceTypes");

            migrationBuilder.DropIndex(
                name: "IX_ServiceTypes_Slug",
                table: "ServiceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentDetails_AppointmentId",
                table: "AppointmentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_Title",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppointmentDetails");

            migrationBuilder.RenameTable(
                name: "BlogPost",
                newName: "BlogPosts");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "HexColor",
                table: "ServiceTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "#14746F");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "ServiceTypes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ExerciseTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "DurationCosts",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "KeywordsString",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "BlogPosts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails",
                column: "AppointmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "Slug");

            migrationBuilder.CreateTable(
                name: "AppointmentExerciseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDetailAppointmentId = table.Column<int>(type: "int", nullable: true),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: true),
                    NumberOfRepetitions = table.Column<int>(type: "int", nullable: true),
                    NumberOfSets = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    RestAfterExerciseInMinutes = table.Column<int>(type: "int", nullable: true),
                    RestBetweenSetsInMinutes = table.Column<int>(type: "int", nullable: true),
                    SuccessfulyPerformed = table.Column<bool>(type: "bit", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentExerciseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentExerciseDetails_AppointmentDetails_AppointmentDetailAppointmentId",
                        column: x => x.AppointmentDetailAppointmentId,
                        principalTable: "AppointmentDetails",
                        principalColumn: "AppointmentId");
                    table.ForeignKey(
                        name: "FK_AppointmentExerciseDetails_ExerciseTypes_ExerciseTypeId",
                        column: x => x.ExerciseTypeId,
                        principalTable: "ExerciseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "afa324f6-eefd-4a81-b3d4-d060b2bb6033", "AQAAAAIAAYagAAAAENuQMiYxa1+bH6gRa6sZITNBft4vVyRutHWI/FMU0tR5UuLvMzNB3NTinyDyHNiUvg==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "be5fc06d-3514-4a04-8bdc-951e732ca41d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "ca06af9e-bf2d-48ad-845f-1e8452b69de6", "AQAAAAIAAYagAAAAEIK84aMp7QU+wHDyW5gPPR4Bu4cLWH/4kZwR97FFUYEo+CLqeF/lua8MjyMcM5QEgQ==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "57cf0e0c-2e4f-47bb-a73a-b21f45575ff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "629a974b-5f5c-46a1-9986-48546462da7b", "AQAAAAIAAYagAAAAEPBob/7YzJnu6I0FjiKduSxk4BteECWL/N903h5+Kit0vcou29DKhDtspC8xllVTcg==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c03e7cdc-479c-47b4-9e41-bba7d949dfc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "e405ab35-863a-4b6c-8390-80c3384e2d0d", "AQAAAAIAAYagAAAAEPfCLU86ecNbceTuRDjcsGCoyiidoD4QZoe8OmmPmpVTNmEjWLs5+t/VT2RNq4bE0w==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6684bf59-579d-4349-86e8-225102e07161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate", "SecurityStamp" },
                values: new object[] { "e6da6035-26eb-4d23-b763-75a7d1088a1f", "AQAAAAIAAYagAAAAEJh5eFy8NMyL1NQcQtUlpOTcQHUAIK9pHTxbWi6aoVb0LcSRT4Xu9/eTiDGp4baR/A==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "29b5eea5-a987-4f12-a98a-2496dd327b44" });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentExerciseDetails_AppointmentDetailAppointmentId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentDetailAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentExerciseDetails_ExerciseTypeId",
                table: "AppointmentExerciseDetails",
                column: "ExerciseTypeId");
        }
    }
}
