using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shopper> Shoppers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shopper>().ToTable("Shopper");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<DeliveryPerson>().ToTable("DeliveryPerson");
        }
        // public DbSet<DeliveryCart.Models.DeliveryPerson> DeliveryPerson { get; set; }
    }
