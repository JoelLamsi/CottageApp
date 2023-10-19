using DataObjects;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    { 
        options.UseSqlite("Data Source=Data/cottage-app.db");
    }

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Cottage> Cottages { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cottage>().ToTable("Cottages")
            .HasData(new Cottage
            {
                Id = 1,
                Title = "Foo",
                Description = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                CostPerDay = 50.00m,
                PictureUrl = "img/cottage1.jpeg",
                DateAdded = DateTime.Now,
                Ratings = new int[] {1,2, 4, 1, 3}
            });
        modelBuilder.Entity<Cottage>()
            .HasData(new Cottage
            {
                Id = 2,
                Title = "Bar",
                CostPerDay = 250.00m,
                PictureUrl = "img/cottage2.jpeg",
                DateAdded = DateTime.Now,
                Ratings = new int[] {5}
            });
    }
}