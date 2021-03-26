using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=RentACar;Trusted_Connection=true");

        }
        public DbSet<Car> Car { get; set; } //sql tablo adı"Car 2."
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Car> CarDetails{ get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rental> Rental { get; set; }

    }
}
