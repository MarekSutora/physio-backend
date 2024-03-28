using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class bringBackEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost");

            migrationBuilder.RenameTable(
                name: "BlogPost",
                newName: "BlogPosts");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPost_Title",
                table: "BlogPosts",
                newName: "IX_BlogPosts_Title");

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
                    AppointmentDetailId = table.Column<int>(type: "int", nullable: false),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    NumberOfRepetitions = table.Column<int>(type: "int", nullable: true),
                    NumberOfSets = table.Column<int>(type: "int", nullable: true),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: true),
                    RestAfterExerciseInMinutes = table.Column<int>(type: "int", nullable: true),
                    RestBetweenSetsInMinutes = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    SuccessfulyPerformed = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentExerciseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentExerciseDetails_AppointmentDetails_AppointmentDetailId",
                        column: x => x.AppointmentDetailId,
                        principalTable: "AppointmentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentExerciseDetails_AppointmentDetailId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentExerciseDetails_ExerciseTypeId",
                table: "AppointmentExerciseDetails",
                column: "ExerciseTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentExerciseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.RenameTable(
                name: "BlogPosts",
                newName: "BlogPost");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPosts_Title",
                table: "BlogPost",
                newName: "IX_BlogPost_Title");

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
        }
    }
}
