
using SunCardBackend2.Models;
using Microsoft.EntityFrameworkCore;

namespace SunCardBackend2.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<CustomerList> Customer { get; set; } = null!;

        public DbSet<CardList> Card { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=tcp:03072022server.database.windows.net,1433;Initial Catalog=03072022-P2;Persist Security Info=False;User ID=klee5760;Password=Bo1Go21010!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}