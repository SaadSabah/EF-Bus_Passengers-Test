using Microsoft.EntityFrameworkCore;

namespace EF_Bus_Passengers_Test
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EF-Bus&Passengers-Test;Integrated Security=True";
        public DbSet<Buss> busses { get; set; }
        public DbSet<Passengers> passengers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Buss>().HasData(new Buss { Id = 1, BussName = "The Malmö Mover", NumberOfseats = 40 });
            ModelBuilder.Entity<Buss>().HasData(new Buss { Id = 2, BussName = "The Uppsala Uplift", NumberOfseats = 50 });

            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 1, FirstName = "Saad", LastName = "Sabah", BussId = 1 });
            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 2, FirstName = "Ali", LastName = "Rami", BussId = 1 });
            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 3, FirstName = "Arai", LastName = "Mani", BussId = 2 });
            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 4, FirstName = "Noor", LastName = "Lother", BussId = 2 });
            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 5, FirstName = "Sara", LastName = "Wriwei", BussId = 2 });
            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 6, FirstName = "Hamad", LastName = "Mohamd", BussId = 2 });
            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 7, FirstName = "Solo", LastName = "Hussain", BussId = 2 });
            ModelBuilder.Entity<Passengers>().HasData(new Passengers { Id = 8, FirstName = "Ziko", LastName = "Fadi", BussId = 1 });
        }

    }
}
