using EntityFrameworkDataBase.DataBaseEntities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDataBase
{
    internal class ApplicationDbContext : DbContext
    {
        internal DbSet<StudentDB> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=2064243;Database=DapperStudentDB;");
        }
    }
}
