using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Core.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Data.Entities.Car> Cars { get; set; }
        public DbSet<Data.Entities.Category> Categories { get; set; }
        public DbSet<Data.Entities.Customer> Customers { get; set; }
        public DbSet<Data.Entities.Person> Persons { get; set; }
        public DbSet<Data.Entities.Rental> Rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //check again from a.kamberi project
            optionsBuilder.UseSqlServer
                ("Data Source=ILIRDASHI\\SQLEXPRESS;Integrated Security=True;Initial Catalog = CarRental; Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Data.Entities.Car.ConfigureForDb(modelBuilder.Entity<Data.Entities.Car>());
            Data.Entities.Category.ConfigureForDb(modelBuilder.Entity<Data.Entities.Category>());
            Data.Entities.Customer.ConfigureForDb(modelBuilder.Entity<Data.Entities.Customer>());
            Data.Entities.Person.ConfigureForDb(modelBuilder.Entity<Data.Entities.Person>());
            Data.Entities.Rental.ConfigureForDb(modelBuilder.Entity<Data.Entities.Rental>());
        }
    }

}
