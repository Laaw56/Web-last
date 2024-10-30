using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ValidationOrders.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Document> Documents { get; set; } = default!;

        public DbSet<Employee> Employees { get; set; } = default!;

        public DbSet<Vacation> Vacations { get; set; } = default!;

        public DbSet<Gender> Genders { get; set; } = default!;

    }
}
