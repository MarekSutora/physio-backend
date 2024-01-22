﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace diploma_thesis_backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240122212757_mainlySeedingRedone")]
    partial class mainlySeedingRedone
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Model.Entities.ActivityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NormalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ActivityType");
                });

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

                    b.Property<int?>("AddressId")
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

                    b.Property<int?>("PersonId")
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

                    b.HasIndex("AddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PersonId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e669b558-518b-409a-ac03-d7421d5a9779",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEAJjmIZM7m+rC8ahd7auW4QZ+J6pZtH3AMzxPzs9CguHHSE+14AzcB2qaJktXNduA==",
                            PersonId = 1,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "1e567342-29b1-4408-82ba-2f64011a7efc",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "63eaca5d-e284-45f7-8738-c3160ca53b93",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "464c747f-d7c7-48ff-af61-54ba61f7234a",
                            Email = "physiotherapist@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            NormalizedUserName = "PHYSIOTHERAPIST@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMBxvdExGhG02K+aflF20xl/POcWrZaSYZzM4Qsj4mhxqxMQ6i0DLw0NqxfQRLUMaQ==",
                            PersonId = 2,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "f5c665ee-1f3d-47f0-877a-8a56cf7f130c",
                            TwoFactorEnabled = false,
                            UserName = "physiotherapist@example.com"
                        },
                        new
                        {
                            Id = "c3235cea-19a5-4a0d-8f21-72f8d225eceb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cbb9882e-91a2-4b74-a2e2-596005bdbd37",
                            Email = "patient@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATIENT@EXAMPLE.COM",
                            NormalizedUserName = "PATIENT@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIemm7UqN/vvA1/z2PFZtg7eXR9ssXYvoOVQdF5+i3Q/BlwPm8JbzqJr5/tRRvz82w==",
                            PersonId = 3,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "061a5b80-6bdd-42aa-90cd-5e17c2cab099",
                            TwoFactorEnabled = false,
                            UserName = "patient@example.com"
                        });
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActivityTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Appointment");
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

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationUserId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId1");

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

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationUserId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndedWorkingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartedWorkingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId1");

                    b.HasIndex("EmployeeTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.EmployeeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeType");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Patient");
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
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

            modelBuilder.Entity("DiagnosisPatient", b =>
                {
                    b.Property<int>("DiagnosissId")
                        .HasColumnType("int");

                    b.Property<int>("PatientsId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosissId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("DiagnosisPatient");
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
                            Name = "Employee",
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
                            UserId = "7cff1bdc-0dec-4dd1-a595-8ecc2bda12cf",
                            RoleId = "8036F52A-701F-4AA4-8639-D9C8123FD8C6"
                        },
                        new
                        {
                            UserId = "63eaca5d-e284-45f7-8738-c3160ca53b93",
                            RoleId = "545BBA82-840A-4446-BFF6-64834A8DA52F"
                        },
                        new
                        {
                            UserId = "c3235cea-19a5-4a0d-8f21-72f8d225eceb",
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
                    b.HasOne("DataAccess.Model.Entities.Address", null)
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("AddressId");

                    b.HasOne("DataAccess.Model.Entities.Person", "Person")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Appointment", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.ActivityType", null)
                        .WithMany("Appointments")
                        .HasForeignKey("ActivityTypeId");

                    b.HasOne("DataAccess.Model.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("DataAccess.Model.Entities.Payment", "Payment")
                        .WithMany("Appointments")
                        .HasForeignKey("PaymentId");

                    b.Navigation("Patient");

                    b.Navigation("Payment");
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
                        .HasForeignKey("ApplicationUserId1")
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
                        .HasForeignKey("ApplicationUserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.EmployeeType", "EmployeeType")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeTypeId");

                    b.HasOne("DataAccess.Model.Entities.Person", null)
                        .WithMany("Employees")
                        .HasForeignKey("PersonId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("EmployeeType");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Patient", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Person", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DiagnosisPatient", b =>
                {
                    b.HasOne("DataAccess.Model.Entities.Diagnosis", null)
                        .WithMany()
                        .HasForeignKey("DiagnosissId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Model.Entities.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("DataAccess.Model.Entities.ActivityType", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Address", b =>
                {
                    b.Navigation("ApplicationUsers");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.ApplicationUser", b =>
                {
                    b.Navigation("BlogPosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Blog", b =>
                {
                    b.Navigation("BlogPosts");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.BlogPost", b =>
                {
                    b.Navigation("BlogKeywordss");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.EmployeeType", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Payment", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("DataAccess.Model.Entities.Person", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
