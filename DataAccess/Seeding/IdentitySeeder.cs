using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Seeding
{
    public static class IdentitySeeder
    {
        public static async Task SeedUsersAndRolesAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();

            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            // -----------------------------------------------
            // 1) Ensure roles
            // -----------------------------------------------
            var roles = new[] { "ADMIN", "CLIENT" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // -----------------------------------------------
            // 2) Admin users to seed
            // -----------------------------------------------
            var adminUsers = new List<(string Email, string Password, string First, string Last)>
            {
                ("admin@physio.sk", "placeholderhesloskutocnetrebazmenitpredseedovanim", "Admin", "Physio")
            };

            foreach (var (email, password, first, last) in adminUsers)
            {
                await CreateUserIfNotExists(email, password, first, last, "ADMIN", db, userManager);
            }

            // -----------------------------------------------
            // 3) Client users to seed
            // -----------------------------------------------
            var clientUsers = new List<(string Email, string Password, string First, string Last)>
            {
                ("client1@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Jana",    "Nováková"),
                ("client2@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Peter",   "Kováč"),
                ("client3@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Mária",   "Horváthová"),
                ("client4@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Tomáš",   "Varga"),
                ("client5@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Zuzana",  "Baláž"),
                ("client6@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Martin",  "Szabó"),
                ("client7@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Eva",     "Molnár"),
                ("client8@physio.sk",  "placeholderhesloskutocnetrebazmenitpredseedovanim", "Lukáš",   "Tóth")
            };

            foreach (var (email, password, first, last) in clientUsers)
            {
                await CreateUserIfNotExists(email, password, first, last, "CLIENT", db, userManager);
            }
        }

        // -----------------------------------------------
        // Helper method for creating users + Persons
        // -----------------------------------------------
        private static async Task CreateUserIfNotExists(
            string email,
            string password,
            string firstName,
            string lastName,
            string role,
            ApplicationDbContext db,
            UserManager<ApplicationUser> userManager)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user != null)
                return; // Already exists

            // Create Person first
            var person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = "0000000000"
            };

            db.Persons.Add(person);
            await db.SaveChangesAsync();

            // Create ApplicationUser
            user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true,
                RegisteredDate = DateTime.UtcNow,
                RefreshToken = "",
                RefreshTokenExpiryTime = DateTime.UtcNow,
                PersonId = person.Id
            };

            var result = await userManager.CreateAsync(user, password);

            if (!result.Succeeded)
            {
                throw new Exception("Failed creating user " + email
                    + ": " + string.Join(", ", result.Errors.Select(e => e.Description)));
            }

            // Assign role
            await userManager.AddToRoleAsync(user, role);
        }
    }
}
