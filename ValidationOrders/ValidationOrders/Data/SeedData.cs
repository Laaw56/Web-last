using Microsoft.AspNetCore.Identity;
using ValidationOrders.Data;

public class SeedData
{
    public async Task InitializeAsync(ApplicationDbContext context)
    {
        var genders = new List<Gender>
        {
            new Gender { Id=1, GenderName="Мужской" },
            new Gender { Id=2, GenderName = "Женский"}
        };
        context.Genders.AddRange(genders);
        await context.SaveChangesAsync();

        var role1 = new IdentityRole("Admin");

        var role2 = new IdentityRole("Employee");

        await context.Roles.AddAsync(role1);

        await context.Roles.AddAsync(role2);

        var user1 = new ApplicationUser
        {
            UserName = "rastorguev@yandex.ru",
            Email = "rastorguev@yandex.ru",
            LastName = "Расторгуев",
            FirstName = "Алексей",
            MiddleName = "Михайлович",
            GenderId = 1,
            DateBirth = DateTime.Parse("25.11.2003"),
            Phone = "79999999999",
            NormalizedEmail = "RASTORGUEV@YANDEX.RU",
            NormalizedUserName = "RASTORGUEV@YANDEX.RU",
            LockoutEnabled = true
        };

        var passwordHasher = new PasswordHasher<ApplicationUser>();

        user1.PasswordHash = passwordHasher.HashPassword(user1, "Admin1");

        var res = await context.Users.AddAsync(user1);

        var res2 = await context.UserRoles.AddAsync(
            new IdentityUserRole<string>
            {
                RoleId = role1.Id,
                UserId = user1.Id
            }
        );

        await context.SaveChangesAsync();
    }
}
