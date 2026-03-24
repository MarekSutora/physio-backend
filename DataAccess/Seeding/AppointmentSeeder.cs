using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Seeding
{
    public static class AppointmentSeeder
    {
        public static async Task SeedAppointmentsAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (await db.Appointments.AnyAsync())
                return;

            var serviceTypeDurationCosts = await db.Set<ServiceTypeDurationCost>().ToListAsync();
            if (serviceTypeDurationCosts.Count == 0)
                return;

            var personIds = await db.Persons.Select(p => p.Id).ToListAsync();
            if (personIds.Count == 0)
                return;

            var rng = new Random(42);
            var today = DateTime.UtcNow.Date;

            // Time slots (hours) for appointments each day
            var timeSlots = new[] { 8, 10, 12, 14, 16 };

            // Generate appointments from 30 days ago to 365 days ahead
            var startDate = today.AddDays(-30);
            var endDate = today.AddDays(365);

            var appointments = new List<Appointment>();
            var astdcList = new List<AppointmentServiceTypeDurationCost>();
            var bookedList = new List<BookedAppointment>();

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Skip some days randomly to make it look natural (weekends less busy)
                var isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
                var slotsForDay = isWeekend
                    ? timeSlots.Where(_ => rng.NextDouble() > 0.5).ToArray()
                    : timeSlots.Where(_ => rng.NextDouble() > 0.2).ToArray();

                foreach (var hour in slotsForDay)
                {
                    var startTime = date.AddHours(hour);
                    var capacity = rng.Next(1, 4); // 1-3 capacity

                    var appointment = new Appointment
                    {
                        StartTime = DateTime.SpecifyKind(startTime, DateTimeKind.Utc),
                        Capacity = capacity
                    };
                    appointments.Add(appointment);
                }
            }

            db.Appointments.AddRange(appointments);
            await db.SaveChangesAsync();

            // Link each appointment to 1-2 ServiceTypeDurationCosts
            foreach (var appointment in appointments)
            {
                var count = rng.Next(1, 3); // 1 or 2 service types
                var selected = serviceTypeDurationCosts
                    .OrderBy(_ => rng.Next())
                    .Take(count)
                    .ToList();

                foreach (var stdc in selected)
                {
                    astdcList.Add(new AppointmentServiceTypeDurationCost
                    {
                        AppointmentId = appointment.Id,
                        ServiceTypeDurationCostId = stdc.Id
                    });
                }
            }

            db.AppointmentServiceTypeDurationCosts.AddRange(astdcList);
            await db.SaveChangesAsync();

            // Book some appointments with clients
            // Past appointments: ~70% booked, Future appointments: ~30% booked
            foreach (var astdc in astdcList)
            {
                var appointment = appointments.First(a => a.Id == astdc.AppointmentId);
                var isPast = appointment.StartTime < DateTime.UtcNow;
                var bookingChance = isPast ? 0.7 : 0.3;

                if (rng.NextDouble() > bookingChance)
                    continue;

                var howMany = Math.Min(rng.Next(1, appointment.Capacity + 1), appointment.Capacity);
                var shuffledPersons = personIds.OrderBy(_ => rng.Next()).Take(howMany).ToList();

                foreach (var personId in shuffledPersons)
                {
                    // Avoid double-booking the same person on the same AppointmentServiceTypeDurationCost
                    if (bookedList.Any(b => b.AppointmentServiceTypeDurationCostId == astdc.Id && b.PersonId == personId))
                        continue;

                    bookedList.Add(new BookedAppointment
                    {
                        AppointmentServiceTypeDurationCostId = astdc.Id,
                        PersonId = personId,
                        AppointmentBookedDate = DateTime.SpecifyKind(
                            appointment.StartTime.AddDays(-rng.Next(1, 14)),
                            DateTimeKind.Utc),
                        IsFinished = isPast
                    });
                }
            }

            db.BookedAppointments.AddRange(bookedList);
            await db.SaveChangesAsync();
        }
    }
}
