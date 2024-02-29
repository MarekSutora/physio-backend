using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class appDetailsColRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "687b120e-1d35-4c74-8297-a3a0b46ca1eb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6af3c230-ec50-4645-bb57-e6cf40ec5eb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "810daee4-ba48-4a6b-9e3d-1d151798929e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "d33ff026-1f3b-41db-af55-8ceb734bbad5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "e1952da4-5e50-4f7b-8bbf-b411fbe09759" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "687b120e-1d35-4c74-8297-a3a0b46ca1eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af3c230-ec50-4645-bb57-e6cf40ec5eb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "810daee4-ba48-4a6b-9e3d-1d151798929e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33ff026-1f3b-41db-af55-8ceb734bbad5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1952da4-5e50-4f7b-8bbf-b411fbe09759");

            migrationBuilder.RenameColumn(
                name: "ExpectedNumberOfSets",
                table: "AppointmentExerciseDetails",
                newName: "NumberOfSets");

            migrationBuilder.RenameColumn(
                name: "ExpectedDurationInMinutes",
                table: "AppointmentExerciseDetails",
                newName: "DurationInMinutes");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c5e861f-811d-4de8-9277-b05373abc1d9", 0, "3f4ef0e2-20b2-4a85-a505-d0241197c450", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDKeJa0mVoW+PEKiZMoDlzej/hPeGB0kCfR2+UjwAa5s7FZelwCaL3z6UQH/SUoZ5g==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e7d89703-151d-4299-ac70-852fabda9d11", false, "patient2@example.com" },
                    { "30c750c7-73a0-497e-98f6-c1936d31c316", 0, "f5c26969-4a2c-417a-9947-a962e78aa1cb", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMZQxplUTOoxA68e2ftloe5PGCEEPxxYpR/EIchxLNz0CSgBH16d7/ND3pIzugP/Cg==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18eb6113-9864-48a1-bb45-947c2e51ce2c", false, "patient3@example.com" },
                    { "53f26347-2d27-4856-97b5-dd062f357720", 0, "baa392d5-a250-4c73-aefb-7b7b054b8508", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIn+DKvwKhJEiCZqT7MM4ABnXjEk/XaDnMatZmfLBQEcehNOWKBzkQanBGuYyDpZog==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22a38228-d715-4a69-b4fe-768d015f035d", false, "patient1@example.com" },
                    { "6388a86a-5f98-4313-95d8-cca824a055dd", 0, "510521ff-f21f-47c7-9228-7d7d76fd14ae", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHMUkZ1FhMlxMQRxyl4AeLMT/76skMdVlmSGj9rxyEITOj9jmqfU1D4FmVpGbCFrQA==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5e527a2e-f43b-4e45-9b73-4b062de11967", false, "admin@example.com" },
                    { "80cc3a0c-a003-452b-8901-d9fc840dbb11", 0, "c93511ab-75e5-4f1c-8b36-226e1a7c7be5", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAENtXulAXgdQPS9VvWvm4hhxOv0I8LPmO8T0eu88p6VyR18N4f8recPbHdeLR4Ycj9A==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "58a9fe47-3dad-42dd-aa6d-73d4f061b0ff", false, "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "2c5e861f-811d-4de8-9277-b05373abc1d9" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "30c750c7-73a0-497e-98f6-c1936d31c316" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "53f26347-2d27-4856-97b5-dd062f357720" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6388a86a-5f98-4313-95d8-cca824a055dd" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80cc3a0c-a003-452b-8901-d9fc840dbb11" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "2c5e861f-811d-4de8-9277-b05373abc1d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "30c750c7-73a0-497e-98f6-c1936d31c316" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "53f26347-2d27-4856-97b5-dd062f357720" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "6388a86a-5f98-4313-95d8-cca824a055dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "80cc3a0c-a003-452b-8901-d9fc840dbb11" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e861f-811d-4de8-9277-b05373abc1d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30c750c7-73a0-497e-98f6-c1936d31c316");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53f26347-2d27-4856-97b5-dd062f357720");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6388a86a-5f98-4313-95d8-cca824a055dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80cc3a0c-a003-452b-8901-d9fc840dbb11");

            migrationBuilder.RenameColumn(
                name: "NumberOfSets",
                table: "AppointmentExerciseDetails",
                newName: "ExpectedNumberOfSets");

            migrationBuilder.RenameColumn(
                name: "DurationInMinutes",
                table: "AppointmentExerciseDetails",
                newName: "ExpectedDurationInMinutes");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "687b120e-1d35-4c74-8297-a3a0b46ca1eb", 0, "1d08cd51-1cd3-44f3-8213-7619fe0575d9", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB64qt7N5DSQLHYXHZGEJ/vPFm6XGdu2BQKV1jwDXID+3orCg46d+jKFpthokF7jug==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dffbf7b2-7476-4d0a-860c-204c741e2435", false, "patient3@example.com" },
                    { "6af3c230-ec50-4645-bb57-e6cf40ec5eb8", 0, "ae443a2a-d496-4a7e-a9d1-855e6216f027", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOBjaS73eCWdtEh7mlPajDd2XHmVGLKd0TMJzqAL7Pxs7NNAcLqiPaTOpFDkMJ/TEw==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f26652ae-6b07-4d4b-a363-1202320271cc", false, "patient2@example.com" },
                    { "810daee4-ba48-4a6b-9e3d-1d151798929e", 0, "96a338de-ffbb-42e4-8f5c-c2971e471e9d", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHHNID15pP1SAaXPCM9+KOyR3i4ho6rMJDLV/thIzxos/MHDy362T6TRGt+E2LHsZw==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa9911a7-f324-49a4-b381-e1adb876331a", false, "admin@example.com" },
                    { "d33ff026-1f3b-41db-af55-8ceb734bbad5", 0, "df12ecc8-7059-4bf7-8443-885b4366ff43", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAU7hNDzVYqD9NqXnDb+spCJ9sMAPuuk4EYJZIfQBib3EZiiWQXjlznJV8dg7FSvZg==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c63eeaaa-fbed-4ad7-8823-31cf82593077", false, "admin2@example.com" },
                    { "e1952da4-5e50-4f7b-8bbf-b411fbe09759", 0, "8fee6739-6f1b-41bf-ad71-884912da4969", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ1uPiLJ5Ghx/URuJuACh5ZKBS1reCC0ofpAJEWI8kXQ+oXB76o1CTM8OFPxOZoFTA==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "58b1d07a-d050-490f-badc-6841f5571db9", false, "patient1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "687b120e-1d35-4c74-8297-a3a0b46ca1eb" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "6af3c230-ec50-4645-bb57-e6cf40ec5eb8" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "810daee4-ba48-4a6b-9e3d-1d151798929e" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "d33ff026-1f3b-41db-af55-8ceb734bbad5" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "e1952da4-5e50-4f7b-8bbf-b411fbe09759" }
                });
        }
    }
}
