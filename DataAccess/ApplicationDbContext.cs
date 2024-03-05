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
        public DbSet<Address> Addresss { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentServiceTypeDurationCost> AppointmentServiceTypeDurationCosts { get; set; }
        public DbSet<AppointmentExerciseDetail> AppointmentExerciseDetails { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BookedAppointment> BookedAppointments { get; set; }
        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public DbSet<Diagnosis> Diagnosiss { get; set; }
        public DbSet<DurationCost> DurationCosts { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnosiss { get; set; }
        public DbSet<PatientNote> PatientNotes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServiceTypeDurationCost> ServiceTypeDurationCosts { get; set; }


        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
            //this.Database.Migrate();
            //this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // patient -> diagnosis many to many
            builder.Entity<Patient>()
            .HasMany(e => e.Diagnosiss)
            .WithMany(e => e.Patients)
            .UsingEntity<PatientDiagnosis>(
                l => l.HasOne<Diagnosis>(e => e.Diagnosis).WithMany(e => e.PatientDiagnosiss),
                r => r.HasOne<Patient>(e => e.Patient).WithMany(e => e.PatientDiagnosiss));

            //serviceType -> durationCost m:n
            builder.Entity<ServiceType>()
                .HasMany(e => e.DurationCosts)
                .WithMany(e => e.ServiceTypes)
                .UsingEntity<ServiceTypeDurationCost>(
                                   l => l.HasOne<DurationCost>(e => e.DurationCost).WithMany(e => e.ServiceTypeDurationCosts),
                                   r => r.HasOne<ServiceType>(e => e.ServiceType).WithMany(e => e.ServiceTypeDurationCosts));


            builder.Entity<Appointment>()
                .HasMany(e => e.ServiceTypeDurationCosts)
                .WithMany(e => e.Appointments)
                .UsingEntity<AppointmentServiceTypeDurationCost>(
                                                  l => l.HasOne<ServiceTypeDurationCost>(e => e.ServiceTypeDurationCost).WithMany(e => e.AppointmentServiceTypeDurationCosts),
                                                  r => r.HasOne<Appointment>(e => e.Appointment).WithMany(e => e.AppointmentServiceTypeDurationCosts));

            // patient -> person 1:1
            builder.Entity<Patient>()
           .HasKey(s => s.PersonId);

            builder.Entity<Patient>()
                       .HasOne<Person>(p => p.Person)
                       .WithOne(s => s.Patient)
                       .HasForeignKey<Patient>(pa => pa.PersonId);

            // Appointment -> AppointmentDetail 1:1
            builder.Entity<AppointmentDetail>().HasKey(ad => ad.AppointmentId);

            builder.Entity<AppointmentDetail>()
                .HasOne<Appointment>(ad => ad.Appointment)
                .WithOne(a => a.AppointmentDetail)
                .HasForeignKey<AppointmentDetail>(ad => ad.AppointmentId);


            // ApplicationUser -> person 1:1
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.HasIndex(e => e.PersonId).IsUnique();
            });

            builder.SeedApplicationUsers();

            builder.SeedAppointments();

            builder.SeedExerciseTypes();
        }

        public override int SaveChanges()
        {
            SetServiceTypeDurationCostDateFrom();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            SetServiceTypeDurationCostDateFrom();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetServiceTypeDurationCostDateFrom()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is ServiceTypeDurationCost && e.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((ServiceTypeDurationCost)entry.Entity).DateFrom = DateTime.Now;
            }
        }
    }
}
