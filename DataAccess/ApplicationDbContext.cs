using Azure;
using DataAccess.DataSeeding;
using DataAccess.Model.Entities;
using DataAccess.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogKeyword> BlogKeywords { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Diagnosis> Diagnosiss { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnosiss { get; set; }
        public DbSet<AvailableReservation> AvailableReservations { get; set; }
        public DbSet<AvailableReservationServiceType> AvailableReservationServiceTypes { get; set; }
        public DbSet<ServiceTypeToDisplay> ServiceTypeToDisplays { get; set; }

        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
            //this.Database.Migrate();
            //this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            // AvailableReservation -> ServiceType many to many
            builder.Entity<AvailableReservation>()
            .HasMany(e => e.ServiceTypes)
            .WithMany(e => e.AvailableReservations)
            .UsingEntity<AvailableReservationServiceType>(
                l => l.HasOne<ServiceType>(e => e.ServiceType).WithMany(e => e.AvailableReservationServiceTypes),
                r => r.HasOne<AvailableReservation>(e => e.AvailableReservation).WithMany(e => e.AvailableReservationServiceTypes));


            // patient -> diagnosis many to many
            builder.Entity<Patient>()
            .HasMany(e => e.Diagnosiss)
            .WithMany(e => e.Patients)
            .UsingEntity<PatientDiagnosis>(
                l => l.HasOne<Diagnosis>(e => e.Diagnosis).WithMany(e => e.PatientDiagnosiss),
                r => r.HasOne<Patient>(e => e.Patient).WithMany(e => e.PatientDiagnosiss));


            // patient -> person 1:1
            builder.Entity<Patient>()
           .HasKey(s => s.PersonId);

            builder.Entity<Patient>()
                       .HasOne<Person>(p => p.Person)
                       .WithOne(s => s.Patient);


            // ApplicationUser -> person 1:1
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.HasIndex(e => e.PersonId).IsUnique();
            });

            builder.SeedApplicationUsers();

            builder.SeedServiceTypes();

            builder.SeedAvailableReservations();

            builder.SeedAvailableReservationServiceTypes();
        }
    }
}
