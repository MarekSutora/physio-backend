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
    [Migration("20240209163141_newServiceTypeChanges")]
    partial class newServiceTypeChanges
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
                            Id = "f1b49085-01d5-4462-9760-2e1e2370479e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3bcf5524-59bb-4069-87a8-9c711c8172f4",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAmdTRhLU1rOU0lwWQnNdBrwDdWwnv9THIwHXO38em7bnhtFYMGcGo6Cdw/5HELRhA==",
                            PersonId = 1,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "547f3647-0d3f-4e46-96d9-7f58ed37314d",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "bad71e53-0f89-4f98-84d0-b1c54450abb1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "53a79c5e-516e-4ccd-b09d-73750ea33005",
                            Email = "physiotherapist@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            NormalizedUserName = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGjuWP8GGsx34F1WoYPnctrUUZVTRHU32itbJ76yE8T+Ov9MnwCiP3HjWQojgPGK2A==",
                            PersonId = 2,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "a826ec23-e667-4ac3-bb0e-21097c098db4",
                            TwoFactorEnabled = false,
                            UserName = "physiotherapist@example.com"
                        },
                        new
                        {
                            Id = "16947b0f-5673-494f-80da-21c9c591af8e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3556d77c-19ce-4141-871c-d790e1f01201",
                            Email = "patient@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@EXAMPLE.COM",
                            NormalizedUserName = "PATIENT@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOg4oTPN65ALuQT4E2JRSldCnl+OfAQmjF+gtgINlhb6YiJKszYQJoPnkVZR+pSUsQ==",
                            PersonId = 3,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "75cdc2ba-9212-4dfd-a609-92b575c0f607",
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

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

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
                        .IsRequired()
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

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HexColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
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

                    b.Property<DateTime>("DateTo")
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
                            UserId = "f1b49085-01d5-4462-9760-2e1e2370479e",
                            RoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6"
                        },
                        new
                        {
                            UserId = "f1b49085-01d5-4462-9760-2e1e2370479e",
                            RoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F"
                        },
                        new
                        {
                            UserId = "bad71e53-0f89-4f98-84d0-b1c54450abb1",
                            RoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F"
                        },
                        new
                        {
                            UserId = "16947b0f-5673-494f-80da-21c9c591af8e",
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
                    b.HasOne("DataAccess.Model.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("BlogPosts")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.Blog", "Blog")
                        .WithMany("BlogPosts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

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

            modelBuilder.Entity("DataAccess.Model.Entities.ApplicationUser", b =>
                {
                    b.Navigation("BlogPosts");
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