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
    [Migration("20240211134612_seedPatients")]
    partial class seedPatients
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
                            Id = "a76cac46-31e1-44d0-92fa-eb6046152e24",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d39d2e9c-0d13-4cdd-bb90-def8779e7eae",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAYH3xY0TJiPciR94qBvvRiAUxaSWSzdvDPR1uUyIQKQRMSaJOkKJWaCQV9ZKdkQ3w==",
                            PersonId = 1,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "9d387226-c2ea-4aed-b15f-c9cc29fc36fe",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "2a80d426-5c89-46e3-9a84-394a2965ba59",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0fe98064-9a07-4ed5-9347-c200667f9464",
                            Email = "admin2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN2@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAED50b4xXSeCld6E9ERRZ5Xz5UXwjPotVTsWZf5t92mPXBKsyg+wl7wUIiEsoezuuYw==",
                            PersonId = 2,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "bcf39e1f-bfff-48e9-8692-5ef6f1a925bb",
                            TwoFactorEnabled = false,
                            UserName = "admin2@example.com"
                        },
                        new
                        {
                            Id = "d052fc49-4a1d-4257-b19a-de10a4110669",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb54bca3-5c4e-46a3-9f45-1d470b65ee99",
                            Email = "patient1@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT1@EXAMPLE.COM",
                            NormalizedUserName = "PATIENT1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECTROU1e+zjK0cN7mPsL76rDhKQd/1teOvqSXWZB0n6vZcq5mmZsAuS3ADvXqrduNw==",
                            PersonId = 3,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "700f1a5a-66cc-4b2c-b5f0-9075baf6c06e",
                            TwoFactorEnabled = false,
                            UserName = "patient1@example.com"
                        },
                        new
                        {
                            Id = "6f313bcc-bda4-499c-b92f-8c6422b9fdd5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3784c9dc-264e-48dc-b7d1-fca56e1c963d",
                            Email = "patient2@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT2@EXAMPLE.COM",
                            NormalizedUserName = "PATIENT2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOgd3clbjlpgEukLuLsz2alHkfWuvli/I/g8cBygdo+WG9Npg+dfy2sboNYEKpBPpA==",
                            PersonId = 4,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "a4d50ab4-0f5b-401f-92c0-cac9023b15b0",
                            TwoFactorEnabled = false,
                            UserName = "patient2@example.com"
                        },
                        new
                        {
                            Id = "07f0541e-3cdd-40da-a7d4-b33d69dd7918",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8750e789-98fb-4a58-9e9e-916fc0e180c7",
                            Email = "patient3@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT3@EXAMPLE.COM",
                            NormalizedUserName = "PATIENT3@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPEuL7333mLBXDoeH1W1xwJl+1a01dflNK3J0eTbfOkq+0NRvjcnMSVLytj8nhqSlA==",
                            PersonId = 5,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "de013a78-f5e4-49e5-9460-422469423976",
                            TwoFactorEnabled = false,
                            UserName = "patient3@example.com"
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

                    b.Property<int>("ReservedAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

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

                    b.HasData(
                        new
                        {
                            PersonId = 3
                        },
                        new
                        {
                            PersonId = 4
                        },
                        new
                        {
                            PersonId = 5
                        });
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
                            LastName = "One"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Admin",
                            LastName = "Two"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Patient",
                            LastName = "One"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Patient",
                            LastName = "Two"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Patient",
                            LastName = "Three"
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
                            UserId = "a76cac46-31e1-44d0-92fa-eb6046152e24",
                            RoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6"
                        },
                        new
                        {
                            UserId = "2a80d426-5c89-46e3-9a84-394a2965ba59",
                            RoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6"
                        },
                        new
                        {
                            UserId = "d052fc49-4a1d-4257-b19a-de10a4110669",
                            RoleId = "C7D20194-9C7E-40DB-9C63-F71D20116529"
                        },
                        new
                        {
                            UserId = "6f313bcc-bda4-499c-b92f-8c6422b9fdd5",
                            RoleId = "C7D20194-9C7E-40DB-9C63-F71D20116529"
                        },
                        new
                        {
                            UserId = "07f0541e-3cdd-40da-a7d4-b33d69dd7918",
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
                        .WithMany("BookedReservations")
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

            modelBuilder.Entity("DataAccess.Model.Entities.AvailableReservationServiceTypeDc", b =>
                {
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