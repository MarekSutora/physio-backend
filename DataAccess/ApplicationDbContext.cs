using DataAccess.Configurations;
using DataAccess.Entities;
using DataAccess.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentServiceTypeDurationCost> AppointmentServiceTypeDurationCosts { get; set; }
        public DbSet<AppointmentExerciseDetail> AppointmentExerciseDetails { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BookedAppointment> BookedAppointments { get; set; }
        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public DbSet<DurationCost> DurationCosts { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<ClientNote> ClientNotes { get; set; }
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

            builder.ApplyConfigurationsFromAssembly(typeof(BlogPostConfiguration).Assembly);

            builder.Entity<AppointmentServiceTypeDurationCost>()
                .HasIndex(p => new { p.ServiceTypeDurationCostId, p.AppointmentId })
                .IsUnique(true);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.Ignore(e => e.TwoFactorEnabled);
                entity.Ignore(e => e.PhoneNumberConfirmed);
                entity.Ignore(e => e.PhoneNumber);
            });

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
