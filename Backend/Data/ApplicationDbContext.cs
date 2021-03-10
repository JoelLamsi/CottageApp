using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{ 
        //    options.UseSqlite("Data Source=cottage-app.db");
        //}

        //public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Cottage> Cottages { get; set; }
        //public DbSet<Person> People { get; set; }
        //public DbSet<Address> Addresses { get; set; }
    }
}
