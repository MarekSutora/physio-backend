using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class blogIdRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BlogPosts");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "BlogPosts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "Slug");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afa324f6-eefd-4a81-b3d4-d060b2bb6033", "AQAAAAIAAYagAAAAENuQMiYxa1+bH6gRa6sZITNBft4vVyRutHWI/FMU0tR5UuLvMzNB3NTinyDyHNiUvg==", "be5fc06d-3514-4a04-8bdc-951e732ca41d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca06af9e-bf2d-48ad-845f-1e8452b69de6", "AQAAAAIAAYagAAAAEIK84aMp7QU+wHDyW5gPPR4Bu4cLWH/4kZwR97FFUYEo+CLqeF/lua8MjyMcM5QEgQ==", "57cf0e0c-2e4f-47bb-a73a-b21f45575ff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "629a974b-5f5c-46a1-9986-48546462da7b", "AQAAAAIAAYagAAAAEPBob/7YzJnu6I0FjiKduSxk4BteECWL/N903h5+Kit0vcou29DKhDtspC8xllVTcg==", "c03e7cdc-479c-47b4-9e41-bba7d949dfc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e405ab35-863a-4b6c-8390-80c3384e2d0d", "AQAAAAIAAYagAAAAEPfCLU86ecNbceTuRDjcsGCoyiidoD4QZoe8OmmPmpVTNmEjWLs5+t/VT2RNq4bE0w==", "6684bf59-579d-4349-86e8-225102e07161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6da6035-26eb-4d23-b763-75a7d1088a1f", "AQAAAAIAAYagAAAAEJh5eFy8NMyL1NQcQtUlpOTcQHUAIK9pHTxbWi6aoVb0LcSRT4Xu9/eTiDGp4baR/A==", "29b5eea5-a987-4f12-a98a-2496dd327b44" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
        }
    }
}
