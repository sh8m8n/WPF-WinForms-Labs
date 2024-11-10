

namespace EntityFrameworkDataBase
{ 

    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=YourDatabase;Username=YourUsername;Password=YourPassword");
        }
    }
}
