using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class exerciseTypesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2cd7622a-6718-4cee-bbc2-cc91f7d2b868" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "32b8401c-3b68-41ba-b58c-211f79ceb7f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "42dfdd7e-8749-4ccc-8648-ff02321e3d45" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "57004464-20fb-42c0-96ff-cf24b42e2cd1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5dfa3417-ec18-4a1c-9ec7-1a7295155602" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd7622a-6718-4cee-bbc2-cc91f7d2b868");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32b8401c-3b68-41ba-b58c-211f79ceb7f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42dfdd7e-8749-4ccc-8648-ff02321e3d45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57004464-20fb-42c0-96ff-cf24b42e2cd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dfa3417-ec18-4a1c-9ec7-1a7295155602");

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
                table: "ExerciseTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shoulder Press" },
                    { 2, "Bench Press" },
                    { 3, "Squat" },
                    { 4, "Deadlift" },
                    { 5, "Pull Up" },
                    { 6, "Push Up" },
                    { 7, "Sit Up" },
                    { 8, "Plank" },
                    { 9, "Lunges" },
                    { 10, "Burpees" },
                    { 11, "Mountain Climbers" },
                    { 12, "Jumping Jacks" },
                    { 13, "Squat Jumps" },
                    { 14, "Box Jumps" },
                    { 15, "Wall Balls" },
                    { 16, "Kettlebell Swings" },
                    { 17, "Thrusters" },
                    { 18, "Power Cleans" },
                    { 19, "Snatches" },
                    { 20, "Clean and Jerk" },
                    { 21, "Overhead Squat" },
                    { 22, "Front Squat" },
                    { 23, "Back Squat" },
                    { 24, "Sumo Deadlift High Pull" },
                    { 25, "Turkish Get Up" },
                    { 26, "Handstand Push Up" },
                    { 27, "Muscle Up" },
                    { 28, "Toes to Bar" },
                    { 29, "Double Unders" },
                    { 30, "Skipping Rope" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: 30);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2cd7622a-6718-4cee-bbc2-cc91f7d2b868", 0, "b2c974a9-eea2-41d7-81ec-572d8a84a400", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHBmFmjlNL7KXnyH2dsE/1n8RnmksKK6wV+IvP/gmHMg/ciwanEaNI5avk9Jh9CkgA==", 2, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c3683945-5d6d-457c-a1b6-6bc40def1f21", false, "admin2@example.com" },
                    { "32b8401c-3b68-41ba-b58c-211f79ceb7f0", 0, "30884ad5-bb92-42bd-bb51-05b36266de24", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH97Y7OJeyk5P+uwHjycxbxsDAL5n9gsGvaQaBR1EqoYwgDSuyG8J+J/0t8n1ava3A==", 1, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6ca24992-17ba-44af-92f5-364818219c1e", false, "admin@example.com" },
                    { "42dfdd7e-8749-4ccc-8648-ff02321e3d45", 0, "f19d00b2-8680-40d6-982f-d70a996ecc42", "patient1@example.com", true, false, null, "PATIENT1@EXAMPLE.COM", "PATIENT1@EXAMPLE.COM", "AQAAAAIAAYagAAAAED9NWfhDlS1S/5ue2New/pN3ZvctSttlpT7RvDvbaopvmEIFwHFEKd/zo7ys5Rh9Hg==", 3, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9e844f8b-8827-4641-82a7-07e38fa90b96", false, "patient1@example.com" },
                    { "57004464-20fb-42c0-96ff-cf24b42e2cd1", 0, "9f46e286-4459-48c5-942a-7cc9270e71b3", "patient2@example.com", true, false, null, "PATIENT2@EXAMPLE.COM", "PATIENT2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO0+Uhg0gHa6Stt0M+hF1L40hGzQpkGwyCWTaR18lK0jBtxCdpeySmZDS62zlgWEKA==", 4, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ceff032f-8749-4ec2-8609-df00fc123102", false, "patient2@example.com" },
                    { "5dfa3417-ec18-4a1c-9ec7-1a7295155602", 0, "228c75c4-f8aa-4642-ae9b-261b4414ee22", "patient3@example.com", true, false, null, "PATIENT3@EXAMPLE.COM", "PATIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHm1HjL0cZ5w315DTLd/L7wmbAX1zCkvOEu+RgdFTGTsYWfcsFanyzK/0ZJmO0N3ag==", 5, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "73a61742-8dd6-4f5f-9dc1-546fc8a476bf", false, "patient3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "2cd7622a-6718-4cee-bbc2-cc91f7d2b868" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "32b8401c-3b68-41ba-b58c-211f79ceb7f0" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "42dfdd7e-8749-4ccc-8648-ff02321e3d45" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "57004464-20fb-42c0-96ff-cf24b42e2cd1" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "5dfa3417-ec18-4a1c-9ec7-1a7295155602" }
                });
        }
    }
}
