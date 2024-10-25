using DataAccess.Configurations;
using DataAccess.Entities;
using DataAccess.Seeding;
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
        public DbSet<BlogPostsViewsStats> BlogPostsViewsStats { get; set; }

        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
            this.Database.Migrate();
            this.Database.EnsureCreated();
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

            builder.Entity<BlogPostsViewsStats>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.Month });
            });

            builder.SeedApplicationUsers();

            builder.SeedExerciseTypes();

            builder.Entity<DurationCost>().HasData(
               new DurationCost { Id = 1, DurationMinutes = 35, Cost = 45.00m },
               new DurationCost { Id = 2, DurationMinutes = 40, Cost = 60.00m },
               new DurationCost { Id = 3, DurationMinutes = 45, Cost = 60.00m },
               new DurationCost { Id = 5, DurationMinutes = 30, Cost = 25.00m },
               new DurationCost { Id = 6, DurationMinutes = 60, Cost = 55.00m },
               new DurationCost { Id = 7, DurationMinutes = 45, Cost = 50.00m }
            );

            builder.Entity<ServiceType>().HasData(
                new ServiceType
                {
                    Id = 1,
                    Name = "Manuálna terapia",
                    Description = "Manuálna terapia je špecializovaná forma fyzikálnej terapie poskytovaná zručnými terapeutmi, ktorí používajú svoje ruky na aplikáciu tlaku na svalové tkanivo a manipuláciu s kĺbmi. Tento prístup zameraný na dotyk má za cieľ znížiť bolesť, zvýšiť rozsah pohybu a zlepšiť celkovú funkciu. Medzi bežne používané techniky patria mobilizácia mäkkých tkanív, mobilizácia kĺbov a myofasciálne uvoľňovanie. Manuálna terapia je účinná pri liečbe rôznych stavov, ako je bolesť chrbta, bolesť krku a športové zranenia. Zameriava sa na obnovenie pohybu a funkcie pohybového systému. Terapia často zahŕňa personalizovaný liečebný plán prispôsobený špecifickým potrebám a fyzickému stavu jednotlivca.",
                    Slug = "manualna-terapia",
                    HexColor = "#92A758",
                    ImageUrl = "/manual-therapy.webp",
                    IconName = "FaDiagnoses"
                },
                new ServiceType
                {
                    Id = 2,
                    Name = "Vstupná diagnostika",
                    Description = "Vstupná diagnostika zahŕňa klinické vyšetrenie, pri ktorom fyzioterapeut hodnotí pacienta vykonávajúceho rôzne pohyby a strečingy. Miestnosť je vybavená diagnostickými nástrojmi, ako je goniometer, anatomické grafy a počítač na zaznamenávanie údajov. Terapeut si robí poznámky na klipbord a pozoruje pacientovu postúru a pohyby. Prostredie je profesionálne a dobre organizované, s plagátmi ľudského pohybového aparátu na stenách a blízko umiestneným liečebným stolom. Celková atmosféra je zameraná na klinické hodnotenie a presnú diagnostiku.",
                    Slug = "vstupna-diagnostika",
                    HexColor = "#4f519c",
                    ImageUrl = "/assesment.webp",
                    IconName = "FaClipboard"
                },
                new ServiceType
                {
                    Id = 3,
                    Name = "Bankovanie",
                    Description = "Bankovanie je terapeutická metóda, ktorá sa vykonáva v pokojnom prostredí terapii. Miestnosť je mäkko osvetlená prirodzeným svetlom a zdobená upokojujúcimi prvkami ako sú črepníkové rastliny a difúzory éterických olejov. Pacient leží tvárou nadol na masážnom stole a na chrbte má niekoľko sklenených pohárov. Terapeut používa plameň na vytvorenie vákua v jednom z pohárov pred jeho umiestnením na pokožku pacienta. V pozadí sú viditeľné police s úhľadne usporiadanými uterákmi a terapeutickými nástrojmi. Celková atmosféra je pokojná a prispieva k relaxácii a liečeniu.",
                    Slug = "bankovanie",
                    HexColor = "#666699",
                    ImageUrl = "/bank.webp",
                    IconName = "FaHeart"
                },
                new ServiceType
                {
                    Id = 4,
                    Name = "Cvičenie",
                    Description = "Cvičenie je kľúčovým prvkom fyzioterapie, zameraným na zlepšenie fyzickej kondície, sily, flexibility a celkového zdravia. Počas fyzioterapeutických relácií sa pacienti učia správne techniky vykonávania rôznych cvikov, ktoré sú špecificky navrhnuté na riešenie ich individuálnych potrieb a zdravotných problémov. Terapeut poskytuje podrobný návod a spätnú väzbu, aby zabezpečil, že cviky sú vykonávané správne a bezpečne. Pacienti sa naučia, ako správne držať telo, ako posilniť slabé svalové skupiny, ako zlepšiť rozsah pohybu a ako predchádzať zraneniam. Tieto zručnosti im pomáhajú nielen počas terapie, ale aj v každodennom živote, čím prispievajú k dlhodobému zdraviu a pohode.",
                    Slug = "cvicenie",
                    HexColor = "#993333",
                    ImageUrl = "/exercise.webp",
                    IconName = "FaDumbbell"
                }
            );

            builder.Entity<ServiceTypeDurationCost>().HasData(
                new ServiceTypeDurationCost { Id = 1, ServiceTypeId = 1, DurationCostId = 1, DateFrom = DateTime.UtcNow },
                new ServiceTypeDurationCost { Id = 2, ServiceTypeId = 1, DurationCostId = 2, DateFrom = DateTime.UtcNow },
                new ServiceTypeDurationCost { Id = 3, ServiceTypeId = 2, DurationCostId = 3, DateFrom = DateTime.UtcNow },
                new ServiceTypeDurationCost { Id = 4, ServiceTypeId = 3, DurationCostId = 5, DateFrom = DateTime.UtcNow },
                new ServiceTypeDurationCost { Id = 5, ServiceTypeId = 4, DurationCostId = 6, DateFrom = DateTime.UtcNow },
                new ServiceTypeDurationCost { Id = 6, ServiceTypeId = 4, DurationCostId = 7, DateFrom = DateTime.UtcNow }
            );
        }
    }
}
