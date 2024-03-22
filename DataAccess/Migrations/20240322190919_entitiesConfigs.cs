using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class entitiesConfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientNotes_Clients_ClientId",
                table: "ClientNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresss_AddressId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Addresss");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Persons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientNotes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "BookedAppointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OneDayReminderSent",
                table: "BookedAppointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SevenDaysReminderSent",
                table: "BookedAppointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "AppointmentDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "1234567890");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "1234567890");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: "1234567890");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhoneNumber",
                value: "1234567890");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhoneNumber",
                value: "1234567890");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientNotes_Clients_ClientId",
                table: "ClientNotes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientNotes_Clients_ClientId",
                table: "ClientNotes");

            migrationBuilder.DropColumn(
                name: "OneDayReminderSent",
                table: "BookedAppointments");

            migrationBuilder.DropColumn(
                name: "SevenDaysReminderSent",
                table: "BookedAppointments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "ServiceTypeDurationCosts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientNotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "BookedAppointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "AppointmentDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Addresss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TempAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresss", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064b6a0b-8c25-4710-8fc3-95e2d59be04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e109f1-da4a-4da8-903f-f6939ae284fe", "AQAAAAIAAYagAAAAEJyiMVojvsqAARNpxm9aeAbiZDW4mbRKlOxMxrAKkrSATSvceu5IqUZzA7bGMP0RJw==", "497f2aa4-ebcb-4873-adcf-fe6868098d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab97c50-052f-44af-8516-3a27e4ec3d72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4295a043-e836-403d-8d7c-9b3bb24adfb2", "AQAAAAIAAYagAAAAENHadkXJdSG14xO7Y5hVGHyoztsmpOIn5poYAx4Tl8+v7YFL7QQ+VsQ59U2YFeAzSA==", "63776fa8-45ae-4f3e-87cd-9d3a38f4c467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f7cc01-0e49-4cb0-bff8-aced0c399819",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6becb84-1ea5-4373-bbaf-d9ba6086a453", "AQAAAAIAAYagAAAAEEMa+sh7tn3M7jG+5/6yidfVlWQJ4JL9lWtFG/TEg6rDcctXNL17rRVud3E1tCSX7w==", "75b99927-7405-4621-aa9b-566bbbab86d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea4cbaeb-0869-493c-b80c-372a32b05539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8fc14bd-0315-41ff-a891-112fbc0db76b", "AQAAAAIAAYagAAAAEIWe2+vXIY43w5B58kfq9SOisOr92DoUiD9SCcozuRi3tN/Xj72w5zsBCc9Te3JYEA==", "2fa2b21a-557d-4459-8c7e-d21ad4df9436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa2cd95-a59c-4127-8f54-916deb38b612",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18eb8773-f0f5-4d10-b0d0-0e54197a0ad5", "AQAAAAIAAYagAAAAEH2qoZVH6eizSBrPpJyjbd9oP4A/WIWmYf9oc0ygI/LAaHr0c99IVCRxU8jidlgoBw==", "5dc694c9-da79-4f53-b9f0-53ab412b05db" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "PhoneNumber" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "PhoneNumber" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "PhoneNumber" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressId", "PhoneNumber" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddressId", "PhoneNumber" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookedAppointments_Clients_ClientId",
                table: "BookedAppointments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientNotes_Clients_ClientId",
                table: "ClientNotes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Addresss_AddressId",
                table: "Persons",
                column: "AddressId",
                principalTable: "Addresss",
                principalColumn: "Id");
        }
    }
}
