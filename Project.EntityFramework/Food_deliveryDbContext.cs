using Food_delivery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.EntityFramework
{
    public class Food_deliveryDbContext : DbContext
    {
        

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public Food_deliveryDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().OwnsOne(a => a.delivery);
            modelBuilder.Entity<Order>().OwnsOne(a => a.product);
            //modelBuilder.Entity<Product>().OwnsOne(a => a.delivery);
            base.OnModelCreating(modelBuilder);
        }
    }
}
