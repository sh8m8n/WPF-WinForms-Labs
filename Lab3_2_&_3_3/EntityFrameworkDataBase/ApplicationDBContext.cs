using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDB
{
    internal class ApplicationDbContext : DbContext
    {
        internal DbSet<StudentDB> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=2064243;Database=DapperStudentDB;");
        }
    }
}
