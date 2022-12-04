using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Car>().HasNoKey();
        //}
        //    modelBuilder.Entity<Car>(car =>
        //    {
        //        car.ToTable("Cars");
        //        car.HasIndex(c => c.CarsId).IsUnique();
        //        car.HasIndex(c => new { c.CarsId }).HasFillFactor(90);
        //    });

        //    //---------------ÇALIŞMIYORRR---------------
        //    modelBuilder.Entity<Brand>().HasNoKey();
        //    modelBuilder.Entity<Brand>(brand =>
        //    {
        //        brand.ToTable("Brands");
        //        brand.HasIndex(b => b.BrandsId).IsUnique();
        //        brand.HasIndex(b => new { b.BrandsId }).HasFillFactor(90);
        //    });
        //    //---------------------------------------------------

        //    modelBuilder.Entity<Color>().HasNoKey();
        //    modelBuilder.Entity<Color>(color =>
        //    {
        //        color.ToTable("Colors");
        //        color.HasIndex(c => c.ColorId).IsUnique();
        //        color.HasIndex(c => new { c.ColorId }).HasFillFactor(90);
        //    });

        //    modelBuilder.Entity<User>().HasNoKey();
        //    modelBuilder.Entity<User>(user =>
        //    {
        //        user.ToTable("Users");
        //        user.HasIndex(u => u.UserId).IsUnique();
        //        user.HasIndex(u => new { u.UserId }).HasFillFactor(90);
        //    });

        //    modelBuilder.Entity<Customer>().HasNoKey();
        //    modelBuilder.Entity<Customer>(customer =>
        //    {
        //        customer.ToTable("Customers");
        //        customer.HasIndex(c => c.CustomersId).IsUnique();
        //        customer.HasIndex(c => new { c.CustomersId }).HasFillFactor(90);
        //    });

        //    modelBuilder.Entity<Rental>().HasNoKey();
        //    modelBuilder.Entity<Rental>(rental =>
        //    {
        //        rental.ToTable("Rentals");
        //        rental.HasIndex(r => r.Id).IsUnique();
        //        rental.HasIndex(r => new { r.Id }).HasFillFactor(90);
        //    });
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>().HasNoKey();
            //modelBuilder.Entity<Brand>().HasNoKey();
            //modelBuilder.Entity<CarImage>().HasNoKey();
            //modelBuilder.Entity<Color>().HasNoKey();
            //modelBuilder.Entity<Customer>().HasNoKey();
            //modelBuilder.Entity<Rental>().HasNoKey();
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
    }
}
