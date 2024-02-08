using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class servtypeHist3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "faadef4d-9268-487b-b825-820c67db9404" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9b27b68-c753-4b99-b6a3-86b58cf1d199");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faadef4d-9268-487b-b825-820c67db9404");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropColumn(
                name: "DateOfBecomingInactive",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.AlterColumn<int>(
                name: "DurationMinutes",
                table: "ServiceTypeDurationCosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "ServiceTypeDurationCosts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInactive",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3c443c93-df53-4d5b-9a30-8eabfbf11258", 0, "f32629ba-a60c-448e-b9ce-fe59d6e007e1", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFOL7eUJ5IU990BKQIGEA3hUVI18Rax3JgAHGm7qvf7y/bNlCas6dYeYFlOjZ72x/w==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbb35ee1-cc47-4513-ab02-8a7eefc8b002", false, "admin@example.com" },
                    { "47df776e-fcc7-4842-a6f7-d9a7917c9e33", 0, "15136962-219c-4f23-9ff5-d2458ad064be", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKIqf+RJTpTNRlnWJ3DJCBTiNK2aDecaW6xlhghZ+u+STpEAV5DmF06cht3bciOVig==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5a8e00d-25f5-4964-99e4-639b76acbb46", false, "physiotherapist@example.com" },
                    { "68021f5d-dad8-4865-b50d-87905bd24e41", 0, "0e8fc89e-ea0c-43fd-b96c-876da3d67d03", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHaI88ngPGk50kfhztkmbdt5DiyJzkiLYK6FffcFV8e2IW41HOLimVuMC1V7yxf9lw==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72496859-f229-4000-9cca-5f6661ac70a0", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "3c443c93-df53-4d5b-9a30-8eabfbf11258" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "3c443c93-df53-4d5b-9a30-8eabfbf11258" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "47df776e-fcc7-4842-a6f7-d9a7917c9e33" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "68021f5d-dad8-4865-b50d-87905bd24e41" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "3c443c93-df53-4d5b-9a30-8eabfbf11258" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "3c443c93-df53-4d5b-9a30-8eabfbf11258" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "545BBA82-840A-4446-BFF6-64834A8DA52F", "47df776e-fcc7-4842-a6f7-d9a7917c9e33" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "68021f5d-dad8-4865-b50d-87905bd24e41" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c443c93-df53-4d5b-9a30-8eabfbf11258");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47df776e-fcc7-4842-a6f7-d9a7917c9e33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68021f5d-dad8-4865-b50d-87905bd24e41");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.DropColumn(
                name: "DateInactive",
                table: "ServiceTypeDurationCosts");

            migrationBuilder.AlterColumn<int>(
                name: "DurationMinutes",
                table: "ServiceTypeDurationCosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "ServiceTypeDurationCosts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ServiceTypeDurationCosts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Property for statistics in case cost or duration gets updated");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBecomingInactive",
                table: "ServiceTypeDurationCosts",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a9b27b68-c753-4b99-b6a3-86b58cf1d199", 0, "a8e0485e-391b-43ca-a4fa-b3bc9101002d", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHOLb5+zvtL/szElrBQCNU9odrof26sIJrSAxTcdBpV/xyFk7i+nk/8Ohx1oX/27sw==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "543fec4c-61a0-4642-ac23-7556d7f65d4b", false, "admin@example.com" },
                    { "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11", 0, "ada305b3-15ab-4cb0-9aea-280024ba15df", "physiotherapist@example.com", true, false, null, "PHYSIOTHERAPIST@EXAMPLE.COM", "PHYSIOTHERAPIST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKBGNSX6TEtS4EusUFr5Wzp55Rq0DnDhR2viF102e2Kb1vc6NLInXxQ/9/jjMcQTWg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c25959ba-9bd2-4a29-bdee-a3358c69e97a", false, "physiotherapist@example.com" },
                    { "faadef4d-9268-487b-b825-820c67db9404", 0, "29183e68-3b60-45bf-92d4-d2326dd61957", "patient@example.com", true, false, null, "PATIENT@EXAMPLE.COM", "PATIENT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHToPRFp6t3Vq3juLtNFhu3k2I3u+aWavG8WVB2H5ZHkL3caksyAwSkT2WZNy5xF6Q==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa711b6e-0f17-450b-8bf5-9b382d30a740", false, "patient@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "a9b27b68-c753-4b99-b6a3-86b58cf1d199" },
                    { "545BBA82-840A-4446-BFF6-64834A8DA52F", "b91fc4e1-c2c7-4b00-86c3-ae01a02a5c11" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "faadef4d-9268-487b-b825-820c67db9404" }
                });
        }
    }
}
