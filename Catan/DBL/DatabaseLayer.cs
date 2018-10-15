using System;
using Microsoft.EntityFrameworkCore;
namespace Catan.DBL
{
    public class DatabaseLayer : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Land> Lands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=data;Username=postgres;Password=postgres");
        }
    }
}
