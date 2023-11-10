using Microsoft.EntityFrameworkCore;

namespace CDNsolution.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4LKIFVV;Database=CDNcompany;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
