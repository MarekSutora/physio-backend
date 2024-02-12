﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240209180454_csharpPropertiesAdjustments")]
    partial class csharpPropertiesAdjustments
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Model.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TempAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3d0d9f32-5926-4286-8312-a3b0920ccacf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "051228e7-529c-45d0-92db-4768e83f1d7a",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELImT4NbNrxchfKL6gbO7y3Cv0BAMcdhk5XvoTdEJ5qWaCrjBcrc6/G5HqNUkXfOWQ==",
                            PersonId = 1,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "8bf9b7c1-2fe5-4381-a4ef-15003ae9f27a",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "6bbec599-63e9-495c-abf9-c72845c8ec71",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f8879d9f-659a-4452-aa08-b5f634ef017e",
                            Email = "physiotherapist@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            NormalizedUserName = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHG7w7evJP7bPeX5pdIu2ZqYFknsurUXX8Wypg8w8LAjnhAVGuLEX0GRjDMTtkttKg==",
                            PersonId = 2,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "a6992436-0de2-4a8e-bf1e-aea73737763c",
                            TwoFactorEnabled = false,
                            UserName = "physiotherapist@example.com"
                        },
                        new
                        {
                            Id = "9d92412f-c325-4620-a4d0-1bd547ed88e1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "901af2ef-3dbe-4e74-b8b6-cfec1cc367dd",
                            Email = "patient@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@EXAMPLE.COM",
                            NormalizedUserName = "PATIENT@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBQahFlZZoxTY7k6bp5ziyrrcq5x+Ohh7R4FHf3xwvwjGzcCwuZPugFc39a9aoyubA==",
                            PersonId = 3,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "2aed5303-79ee-4df3-a6c3-edb87bc34bf6",
                            TwoFactorEnabled = false,
                            UserName = "patient@example.com"
                        });
                });

            modelBuilder.Entity("DataAccess.Model.Entities.AvailableReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservedAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AvailableReservations");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.AvailableReservationServiceTypeDc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableReservationId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceTypeDurationCostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AvailableReservationId");

                    b.HasIndex("ServiceTypeDurationCostId");

                    b.ToTable("AvailableReservationServiceTypeDcs");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogPostKeyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogPostId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.ToTable("BlogPostKeywords");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BookedReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AvailableReservationId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableReservationServiceTypeDCId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationBookedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationFinishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ServiceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AvailableReservationId");

                    b.HasIndex("AvailableReservationServiceTypeDCId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("BookedReservations");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Diagnosis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Diagnosiss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.DurationCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DurationCosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Patient", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.PatientDiagnosis", b =>
                {
                    b.Property<int?>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId", "PatientId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientDiagnosiss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Admin",
                            LastName = "User"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Jane",
                            LastName = "Doe"
                        });
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HexColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceTypeDurationCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("DurationCostId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DurationCostId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("ServiceTypeDurationCosts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8036F52A-701F-4AA4-8639-D9C8123FD8C6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "545BBA82-840A-4446-BFF6-64834A8DA52F",
                            Name = "Physiotherapist",
                            NormalizedName = "PHYSIOTHERAPIST"
                        },
                        new
                        {
                            Id = "C7D20194-9C7E-40DB-9C63-F71D20116529",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3d0d9f32-5926-4286-8312-a3b0920ccacf",
                            RoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6"
                        },
                        new
                        {
                            UserId = "3d0d9f32-5926-4286-8312-a3b0920ccacf",
                            RoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F"
                        },
                        new
                        {
                            UserId = "6bbec599-63e9-495c-abf9-c72845c8ec71",
                            RoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F"
                        },
                        new
                        {
                            UserId = "9d92412f-c325-4620-a4d0-1bd547ed88e1",
                            RoleId = "C7D20194-9C7E-40DB-9C63-F71D20116529"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ApplicationUser", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Person", "Person")
                        .WithOne("ApplicationUser")
                        .HasForeignKey("DataAccess.Model.Entities.ApplicationUser", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.AvailableReservationServiceTypeDc", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.AvailableReservation", "AvailableReservation")
                        .WithMany("AvailableReservationServiceTypeDcs")
                        .HasForeignKey("AvailableReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.ServiceTypeDurationCost", "ServiceTypeDurationCost")
                        .WithMany("AvailableReservationServiceTypeDcs")
                        .HasForeignKey("ServiceTypeDurationCostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AvailableReservation");

                    b.Navigation("ServiceTypeDurationCost");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogPost", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Blog", "Blog")
                        .WithMany("BlogPosts")
                        .HasForeignKey("BlogId");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogPostKeyword", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.BlogPost", "BlogPost")
                        .WithMany("BlogPostKeywords")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogPost");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BookedReservation", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.AvailableReservation", null)
                        .WithMany("BookedReservations")
                        .HasForeignKey("AvailableReservationId");

                    b.HasOne("DataAccess.Model.Entities.AvailableReservationServiceTypeDc", "AvailableReservationServiceTypeDc")
                        .WithMany()
                        .HasForeignKey("AvailableReservationServiceTypeDCId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("DataAccess.Model.Entities.ServiceType", null)
                        .WithMany("BookedReservations")
                        .HasForeignKey("ServiceTypeId");

                    b.Navigation("AvailableReservationServiceTypeDc");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Patient", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Person", "Person")
                        .WithOne("Patient")
                        .HasForeignKey("DataAccess.Model.Entities.Patient", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.PatientDiagnosis", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Diagnosis", "Diagnosis")
                        .WithMany("PatientDiagnosiss")
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.Patient", "Patient")
                        .WithMany("PatientDiagnosiss")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnosis");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Person", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Address", "Address")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceTypeDurationCost", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.DurationCost", "DurationCost")
                        .WithMany("ServiceTypeDurationCosts")
                        .HasForeignKey("DurationCostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.ServiceType", "ServiceType")
                        .WithMany("ServiceTypeDurationCosts")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DurationCost");

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Address", b =>
                {
                    b.Navigation("ApplicationUsers");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.AvailableReservation", b =>
                {
                    b.Navigation("AvailableReservationServiceTypeDcs");

                    b.Navigation("BookedReservations");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Blog", b =>
                {
                    b.Navigation("BlogPosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogPost", b =>
                {
                    b.Navigation("BlogPostKeywords");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Diagnosis", b =>
                {
                    b.Navigation("PatientDiagnosiss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.DurationCost", b =>
                {
                    b.Navigation("ServiceTypeDurationCosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Patient", b =>
                {
                    b.Navigation("PatientDiagnosiss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Person", b =>
                {
                    b.Navigation("ApplicationUser");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceType", b =>
                {
                    b.Navigation("BookedReservations");

                    b.Navigation("ServiceTypeDurationCosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceTypeDurationCost", b =>
                {
                    b.Navigation("AvailableReservationServiceTypeDcs");
                });
#pragma warning restore 612, 618
        }
    }
}