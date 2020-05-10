using LocalmApi.Domaine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalmApi.Data
{
    public class LocalmContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<LocationCondition> LocationConditions { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductLocationType> ProductLocationTypes { get; set; }
        public DbSet<LocationType> LocationTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<TypeUser> TypeUsers { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Locam_Bd");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<LocationCondition>().ToTable("LocationCondition");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<ProductImage>().ToTable("ProductImage");
            modelBuilder.Entity<ProductLocationType>().ToTable("ProductLocationType");
            modelBuilder.Entity<LocationType>().ToTable("LocationType");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderProduct>().ToTable("OrderProduct");
            modelBuilder.Entity<Login>().ToTable("Login");
            modelBuilder.Entity<Mark>().ToTable("Mark");
            modelBuilder.Entity<Model>().ToTable("Model");
            modelBuilder.Entity<TypeUser>().ToTable("TypeUser");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
