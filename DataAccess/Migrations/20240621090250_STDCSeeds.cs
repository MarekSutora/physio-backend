using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class STDCSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HTMLContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KeywordsString = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostsViewsStats",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostsViewsStats", x => new { x.Year, x.Month });
                });

            migrationBuilder.CreateTable(
                name: "DurationCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurationCosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HexColor = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "#14746F"),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IconName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientNotes_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypeDurationCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false),
                    DurationCostId = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypeDurationCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTypeDurationCosts_DurationCosts_DurationCostId",
                        column: x => x.DurationCostId,
                        principalTable: "DurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceTypeDurationCosts_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    SuccessfullyPerformed = table.Column<bool>(type: "bit", nullable: true)
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
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
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

            migrationBuilder.CreateTable(
                name: "AppointmentServiceTypeDurationCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeDurationCostId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentServiceTypeDurationCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentServiceTypeDurationCosts_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCosts_ServiceTypeDurationCostId",
                        column: x => x.ServiceTypeDurationCostId,
                        principalTable: "ServiceTypeDurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentBookedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    SevenDaysReminderSent = table.Column<bool>(type: "bit", nullable: false),
                    OneDayReminderSent = table.Column<bool>(type: "bit", nullable: false),
                    AppointmentServiceTypeDurationCostId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedAppointments_AppointmentServiceTypeDurationCosts_AppointmentServiceTypeDurationCostId",
                        column: x => x.AppointmentServiceTypeDurationCostId,
                        principalTable: "AppointmentServiceTypeDurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedAppointments_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", null, "Admin", "ADMIN" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "DurationCosts",
                columns: new[] { "Id", "Cost", "DurationMinutes" },
                values: new object[,]
                {
                    { 1, 45.00m, 35 },
                    { 2, 60.00m, 40 },
                    { 3, 60.00m, 45 },
                    { 5, 25.00m, 30 },
                    { 6, 55.00m, 60 },
                    { 7, 50.00m, 45 }
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
                table: "Persons",
                columns: new[] { "Id", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Admin", "One", "1234567890" },
                    { 2, "Admin", "Two", "1234567890" },
                    { 3, "Client", "One", "1234567890" },
                    { 4, "Client", "Two", "1234567890" },
                    { 5, "Client", "Three", "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Active", "Description", "HexColor", "IconName", "ImageUrl", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, true, "Manuálna terapia je špecializovaná forma fyzikálnej terapie poskytovaná zručnými terapeutmi, ktorí používajú svoje ruky na aplikáciu tlaku na svalové tkanivo a manipuláciu s kĺbmi. Tento prístup zameraný na dotyk má za cieľ znížiť bolesť, zvýšiť rozsah pohybu a zlepšiť celkovú funkciu. Medzi bežne používané techniky patria mobilizácia mäkkých tkanív, mobilizácia kĺbov a myofasciálne uvoľňovanie. Manuálna terapia je účinná pri liečbe rôznych stavov, ako je bolesť chrbta, bolesť krku a športové zranenia. Zameriava sa na obnovenie pohybu a funkcie pohybového systému. Terapia často zahŕňa personalizovaný liečebný plán prispôsobený špecifickým potrebám a fyzickému stavu jednotlivca.", "#92A758", "FaDiagnoses", "/manual-therapy.webp", "Manuálna terapia", "manualna-terapia" },
                    { 2, true, "Vstupná diagnostika zahŕňa klinické vyšetrenie, pri ktorom fyzioterapeut hodnotí pacienta vykonávajúceho rôzne pohyby a strečingy. Miestnosť je vybavená diagnostickými nástrojmi, ako je goniometer, anatomické grafy a počítač na zaznamenávanie údajov. Terapeut si robí poznámky na klipbord a pozoruje pacientovu postúru a pohyby. Prostredie je profesionálne a dobre organizované, s plagátmi ľudského pohybového aparátu na stenách a blízko umiestneným liečebným stolom. Celková atmosféra je zameraná na klinické hodnotenie a presnú diagnostiku.", "#4f519c", "FaClipboard", "/assesment.webp", "Vstupná diagnostika", "vstupna-diagnostika" },
                    { 3, true, "Bankovanie je terapeutická metóda, ktorá sa vykonáva v pokojnom prostredí terapii. Miestnosť je mäkko osvetlená prirodzeným svetlom a zdobená upokojujúcimi prvkami ako sú črepníkové rastliny a difúzory éterických olejov. Pacient leží tvárou nadol na masážnom stole a na chrbte má niekoľko sklenených pohárov. Terapeut používa plameň na vytvorenie vákua v jednom z pohárov pred jeho umiestnením na pokožku pacienta. V pozadí sú viditeľné police s úhľadne usporiadanými uterákmi a terapeutickými nástrojmi. Celková atmosféra je pokojná a prispieva k relaxácii a liečeniu.", "#666699", "FaHeart", "/bank.webp", "Bankovanie", "bankovanie" },
                    { 4, true, "Cvičenie je kľúčovým prvkom fyzioterapie, zameraným na zlepšenie fyzickej kondície, sily, flexibility a celkového zdravia. Počas fyzioterapeutických relácií sa pacienti učia správne techniky vykonávania rôznych cvikov, ktoré sú špecificky navrhnuté na riešenie ich individuálnych potrieb a zdravotných problémov. Terapeut poskytuje podrobný návod a spätnú väzbu, aby zabezpečil, že cviky sú vykonávané správne a bezpečne. Pacienti sa naučia, ako správne držať telo, ako posilniť slabé svalové skupiny, ako zlepšiť rozsah pohybu a ako predchádzať zraneniam. Tieto zručnosti im pomáhajú nielen počas terapie, ale aj v každodennom živote, čím prispievajú k dlhodobému zdraviu a pohode.", "#993333", "FaDumbbell", "/exercise.webp", "Cvičenie", "cvicenie" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "RefreshToken", "RefreshTokenExpiryTime", "RegisteredDate", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "064b6a0b-8c25-4710-8fc3-95e2d59be04e", 0, "c0992fb5-8039-4db5-8344-7bdf10ee001d", "client3@example.com", true, false, null, "CLIENT3@EXAMPLE.COM", "CLIENT3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGjIyA6rGkQeDLk2z6D/qSqr1sbLtTkwS64Ohte9z9+jzQdmplpClq3IwZ34ppVsTA==", 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 9, 2, 50, 553, DateTimeKind.Utc).AddTicks(7595), "fa211463-5656-41b3-a12e-de4758a650b4", "client3@example.com" },
                    { "4ab97c50-052f-44af-8516-3a27e4ec3d72", 0, "6594d389-282c-4380-860c-3c4a5276dc74", "admin1@example.com", true, false, null, "ADMIN1@EXAMPLE.COM", "ADMIN1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGBIyCrfMjOWLuel4jh36ydXp1eGK0AZFwg0My261he5TrY2Kg3u5Qgx2uszYM7HTA==", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 9, 2, 50, 398, DateTimeKind.Utc).AddTicks(2979), "a178169f-e58e-4cf1-a9f5-71cc5b9c4b12", "admin1@example.com" },
                    { "55f7cc01-0e49-4cb0-bff8-aced0c399819", 0, "8bc3497a-eaee-4be2-8148-8c1e8b7aa310", "client2@example.com", true, false, null, "CLIENT12@EXAMPLE.COM", "CLIENT12@EXAMPLE.COM", "AQAAAAIAAYagAAAAENRtu+NE1bHERJDVbiOSizx32Pp7FCPj5s6G4tYsGSJFwMiERmeqLHF0PprDCkHRVA==", 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 9, 2, 50, 514, DateTimeKind.Utc).AddTicks(4172), "494721af-9143-46c1-87ae-98e77d65c039", "client2@example.com" },
                    { "ea4cbaeb-0869-493c-b80c-372a32b05539", 0, "f6a73f4d-28f4-41d0-8979-8aa8919ebce1", "client1@example.com", true, false, null, "CLIENT1@EXAMPLE.COM", "client1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEANKNralK4L/X40wmhx4N9FfnNJvvYkPnYyUiCWrnmxRNYHTAQ4TXnBm48fXccxfng==", 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 9, 2, 50, 475, DateTimeKind.Utc).AddTicks(8487), "b7f82517-6967-4d65-af44-f731745f0010", "client1@example.com" },
                    { "faa2cd95-a59c-4127-8f54-916deb38b612", 0, "6e195802-f8ac-4082-b00f-2c58ca60513f", "admin2@example.com", true, false, null, "ADMIN2@EXAMPLE.COM", "ADMIN2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGnxHOEsRwzZoDH/3+kbqKihWLmrRhiIJQdsUfHLaaaFftjQDY4EmjfqDofvzw18Fg==", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 9, 2, 50, 436, DateTimeKind.Utc).AddTicks(8476), "51baaafe-7a51-4e22-bed0-22a65855a9b2", "admin2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypeDurationCosts",
                columns: new[] { "Id", "DateFrom", "DateTo", "DurationCostId", "ServiceTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 21, 9, 2, 50, 592, DateTimeKind.Utc).AddTicks(9511), null, 1, 1 },
                    { 2, new DateTime(2024, 6, 21, 9, 2, 50, 592, DateTimeKind.Utc).AddTicks(9513), null, 2, 1 },
                    { 3, new DateTime(2024, 6, 21, 9, 2, 50, 592, DateTimeKind.Utc).AddTicks(9514), null, 3, 2 },
                    { 4, new DateTime(2024, 6, 21, 9, 2, 50, 592, DateTimeKind.Utc).AddTicks(9515), null, 5, 3 },
                    { 5, new DateTime(2024, 6, 21, 9, 2, 50, 592, DateTimeKind.Utc).AddTicks(9516), null, 6, 4 },
                    { 6, new DateTime(2024, 6, 21, 9, 2, 50, 592, DateTimeKind.Utc).AddTicks(9517), null, 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "064b6a0b-8c25-4710-8fc3-95e2d59be04e" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "4ab97c50-052f-44af-8516-3a27e4ec3d72" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "55f7cc01-0e49-4cb0-bff8-aced0c399819" },
                    { "C7D20194-9C7E-40DB-9C63-F71D20116529", "ea4cbaeb-0869-493c-b80c-372a32b05539" },
                    { "8036F52A-701F-4AA4-8639-D9C8123FD8C6", "faa2cd95-a59c-4127-8f54-916deb38b612" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_AppointmentId",
                table: "AppointmentDetails",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentExerciseDetails_AppointmentDetailId",
                table: "AppointmentExerciseDetails",
                column: "AppointmentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentExerciseDetails_ExerciseTypeId",
                table: "AppointmentExerciseDetails",
                column: "ExerciseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServiceTypeDurationCosts_AppointmentId",
                table: "AppointmentServiceTypeDurationCosts",
                column: "AppointmentId");

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
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_Slug",
                table: "BlogPosts",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_Title",
                table: "BlogPosts",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_AppointmentServiceTypeDurationCostId",
                table: "BookedAppointments",
                column: "AppointmentServiceTypeDurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointments_PersonId",
                table: "BookedAppointments",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_PersonId",
                table: "ClientNotes",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDurationCosts_DurationCostId",
                table: "ServiceTypeDurationCosts",
                column: "DurationCostId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypeDurationCosts_ServiceTypeId",
                table: "ServiceTypeDurationCosts",
                column: "ServiceTypeId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentExerciseDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "BlogPostsViewsStats");

            migrationBuilder.DropTable(
                name: "BookedAppointments");

            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropTable(
                name: "AppointmentDetails");

            migrationBuilder.DropTable(
                name: "ExerciseTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AppointmentServiceTypeDurationCosts");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "ServiceTypeDurationCosts");

            migrationBuilder.DropTable(
                name: "DurationCosts");

            migrationBuilder.DropTable(
                name: "ServiceTypes");
        }
    }
}
