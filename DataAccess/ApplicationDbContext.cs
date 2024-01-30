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
        public DbSet<ActivityType> ActivityType { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogKeyword> BlogKeyword { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnosis { get; set; }
        public DbSet<AvailableReservation> AvailableReservation { get; set; }
        public DbSet<AvailableReservationActivityType> AvailableReservationActivityType { get; set; }

        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AvailableReservation>()
            .HasMany(e => e.ActivityTypes)
            .WithMany(e => e.AvailableReservations)
            .UsingEntity<AvailableReservationActivityType>(
                l => l.HasOne<ActivityType>(e => e.ActivityType).WithMany(e => e.AvailableReservationActivityTypes),
                r => r.HasOne<AvailableReservation>(e => e.AvailableReservation).WithMany(e => e.AvailableReservationActivityTypes));

            builder.Entity<Patient>()
            .HasMany(e => e.Diagnosiss)
            .WithMany(e => e.Patients)
            .UsingEntity<PatientDiagnosis>(
                l => l.HasOne<Diagnosis>(e => e.Diagnosis).WithMany(e => e.PatientDiagnosiss),
                r => r.HasOne<Patient>(e => e.Patient).WithMany(e => e.PatientDiagnosiss));

            builder.SeedApplicationUsers();

            builder.SeedActivityTypes();

            builder.SeedAvailableReservations();

            builder.SeedAvailableReservationActivityTypes();
        }
    }
}
