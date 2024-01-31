﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Address");
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
                            Id = "e2a33bb0-c13f-4cd0-a2e8-cee43284da17",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ccebb077-8b6c-431c-92eb-98822c81d22b",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMRHQTzfys6nk7kfsjyJXchLnpyiN3ri2uZzk059PHFndFBQOM+dzU7zBDE32/Bg6g==",
                            PersonId = 1,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "5f264002-82d5-42a2-a9d5-2b96de0a89e6",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "d4e6ae1f-61e0-4fc6-ad0c-36a4dace2998",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "306daf4b-8636-49aa-a4c7-25073ba3f91a",
                            Email = "physiotherapist@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            NormalizedUserName = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEERdkOiI/n7aOP+b06asufE/U9FgoInP1A31DppV58rm6XmsTIhXdU+zIXC0J/Ef5w==",
                            PersonId = 2,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "c3d5cde4-4a21-46c4-9f32-5679ff2c83ed",
                            TwoFactorEnabled = false,
                            UserName = "physiotherapist@example.com"
                        },
                        new
                        {
                            Id = "cd3728f3-80be-41ae-a2dc-87b6458269ef",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "62d85e8c-b32e-49c2-a8ef-5bc43dbaf181",
                            Email = "patient@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@EXAMPLE.COM",
                            NormalizedUserName = "PATIENT@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELuZEQxkZRMdzXjysGx+slPvL/xbjyKSQgwCk0tMOnKWZ4fhYMBhqPVmLNK8aK85Lw==",
                            PersonId = 3,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "c369445d-fcd6-404e-bfda-011b7e924011",
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

                    b.ToTable("AvailableReservation");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.AvailableReservationServiceType", b =>
                {
                    b.Property<int>("AvailableReservationId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.HasKey("AvailableReservationId", "ServiceTypeId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("AvailableReservationServiceType");
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

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogKeyword", b =>
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

                    b.ToTable("BlogKeyword");
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

                    b.ToTable("BlogPost");
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

                    b.ToTable("Diagnosis");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("EndedWorkingDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartedWorkingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Patient", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.PatientDiagnosis", b =>
                {
                    b.Property<int?>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId", "PatientId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientDiagnosis");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payment");
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

                    b.ToTable("Person");

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

            modelBuilder.Entity("DataAccess.Model.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AvailableReservationId")
                        .HasColumnType("int");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationFinishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ServiceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AvailableReservationId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

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

                    b.ToTable("ServiceType");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceTypeDurationCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("ServiceTypeDurationCost");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceTypeToDisplay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("ServiceTypeToDisplay");
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
                            UserId = "e2a33bb0-c13f-4cd0-a2e8-cee43284da17",
                            RoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6"
                        },
                        new
                        {
                            UserId = "e2a33bb0-c13f-4cd0-a2e8-cee43284da17",
                            RoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F"
                        },
                        new
                        {
                            UserId = "d4e6ae1f-61e0-4fc6-ad0c-36a4dace2998",
                            RoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F"
                        },
                        new
                        {
                            UserId = "cd3728f3-80be-41ae-a2dc-87b6458269ef",
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

            modelBuilder.Entity("DataAccess.Model.Entities.AvailableReservationServiceType", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.AvailableReservation", "AvailableReservation")
                        .WithMany("AvailableReservationServiceTypes")
                        .HasForeignKey("AvailableReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.ServiceType", "ServiceType")
                        .WithMany("AvailableReservationServiceTypes")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AvailableReservation");

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogKeyword", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.BlogPost", "BlogPost")
                        .WithMany("BlogKeywordss")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogPost");
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

            modelBuilder.Entity("DataAccess.Model.Entities.Employee", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
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

            modelBuilder.Entity("DataAccess.Model.Entities.Reservation", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.AvailableReservation", "AvailableReservation")
                        .WithMany("Reservations")
                        .HasForeignKey("AvailableReservationId");

                    b.HasOne("DataAccess.Model.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("DataAccess.Model.Entities.Payment", "Payment")
                        .WithMany("Reservations")
                        .HasForeignKey("PaymentId");

                    b.HasOne("DataAccess.Model.Entities.ServiceType", null)
                        .WithMany("Reservations")
                        .HasForeignKey("ServiceTypeId");

                    b.Navigation("AvailableReservation");

                    b.Navigation("Patient");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceTypeDurationCost", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.ServiceType", "ServiceType")
                        .WithMany("ServiceTypeDurationCosts")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                    b.Navigation("AvailableReservationServiceTypes");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Blog", b =>
                {
                    b.Navigation("BlogPosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogPost", b =>
                {
                    b.Navigation("BlogKeywordss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Diagnosis", b =>
                {
                    b.Navigation("PatientDiagnosiss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Patient", b =>
                {
                    b.Navigation("PatientDiagnosiss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Payment", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Person", b =>
                {
                    b.Navigation("ApplicationUser");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ServiceType", b =>
                {
                    b.Navigation("AvailableReservationServiceTypes");

                    b.Navigation("Reservations");

                    b.Navigation("ServiceTypeDurationCosts");
                });
#pragma warning restore 612, 618
        }
    }
}
