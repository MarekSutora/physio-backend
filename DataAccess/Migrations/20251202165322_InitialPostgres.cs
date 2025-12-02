using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialPostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Slug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DatePublished = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HTMLContent = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    KeywordsString = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    MainImageUrl = table.Column<string>(type: "text", nullable: false),
                    IsHidden = table.Column<bool>(type: "boolean", nullable: false),
                    ViewCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostsViewsStats",
                columns: table => new
                {
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Month = table.Column<int>(type: "integer", nullable: false),
                    ViewCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostsViewsStats", x => new { x.Year, x.Month });
                });

            migrationBuilder.CreateTable(
                name: "DurationCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    HexColor = table.Column<string>(type: "text", nullable: false, defaultValue: "#14746F"),
                    Description = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    IconName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Slug = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: false)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<string>(type: "text", nullable: false),
                    RefreshToken = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Note = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceTypeId = table.Column<int>(type: "integer", nullable: false),
                    DurationCostId = table.Column<int>(type: "integer", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateTo = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentDetailId = table.Column<int>(type: "integer", nullable: false),
                    ExerciseTypeId = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NumberOfRepetitions = table.Column<int>(type: "integer", nullable: true),
                    NumberOfSets = table.Column<int>(type: "integer", nullable: true),
                    DurationInMinutes = table.Column<int>(type: "integer", nullable: true),
                    RestAfterExerciseInMinutes = table.Column<int>(type: "integer", nullable: true),
                    RestBetweenSetsInMinutes = table.Column<int>(type: "integer", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: true),
                    SuccessfullyPerformed = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentExerciseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentExerciseDetails_AppointmentDetails_AppointmentDe~",
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceTypeDurationCostId = table.Column<int>(type: "integer", nullable: false),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentServiceTypeDurationCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentServiceTypeDurationCosts_Appointments_Appointmen~",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCost~",
                        column: x => x.ServiceTypeDurationCostId,
                        principalTable: "ServiceTypeDurationCosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentBookedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsFinished = table.Column<bool>(type: "boolean", nullable: false),
                    SevenDaysReminderSent = table.Column<bool>(type: "boolean", nullable: false),
                    OneDayReminderSent = table.Column<bool>(type: "boolean", nullable: false),
                    AppointmentServiceTypeDurationCostId = table.Column<int>(type: "integer", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedAppointments_AppointmentServiceTypeDurationCosts_Appo~",
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
                table: "ServiceTypeDurationCosts",
                columns: new[] { "Id", "DateFrom", "DateTo", "DurationCostId", "ServiceTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 2, 16, 53, 22, 620, DateTimeKind.Utc).AddTicks(5934), null, 1, 1 },
                    { 2, new DateTime(2025, 12, 2, 16, 53, 22, 620, DateTimeKind.Utc).AddTicks(5937), null, 2, 1 },
                    { 3, new DateTime(2025, 12, 2, 16, 53, 22, 620, DateTimeKind.Utc).AddTicks(5938), null, 3, 2 },
                    { 4, new DateTime(2025, 12, 2, 16, 53, 22, 620, DateTimeKind.Utc).AddTicks(5939), null, 5, 3 },
                    { 5, new DateTime(2025, 12, 2, 16, 53, 22, 620, DateTimeKind.Utc).AddTicks(5941), null, 6, 4 },
                    { 6, new DateTime(2025, 12, 2, 16, 53, 22, 620, DateTimeKind.Utc).AddTicks(5942), null, 7, 4 }
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
                name: "IX_AppointmentServiceTypeDurationCosts_ServiceTypeDurationCost~",
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
                unique: true);

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
                unique: true);

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
