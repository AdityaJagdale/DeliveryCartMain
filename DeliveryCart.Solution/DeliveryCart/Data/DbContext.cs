using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;
using System.Configuration;

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

        public async virtual Task AddDeliveryPersonAsync(DeliveryCart.Models.DeliveryPerson deliveryPerson)
        {
            DeliveryPersons.Add(deliveryPerson);
            await SaveChangesAsync();
        }

        // public void ConfigureServices(IServiceCollection services)
        // {
        //     services.AddDbContext<DbContext>(options =>
        //     {
        //         options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        //         options.EnableSensitiveDataLogging();
        //     });
        // }

        

        public async virtual Task DeleteAllDeliveryPersonAsync()
        {
            foreach (DeliveryPerson DeliveryPerson in DeliveryPersons)
            {
                DeliveryPersons.Remove(DeliveryPerson);
            }
            
            await SaveChangesAsync();
        }

        public void Initialize()
        {
            DeliveryPersons.AddRange(GetSeedingDeliveryPerson());
            SaveChanges();
        }

        public static List<DeliveryPerson> GetSeedingDeliveryPerson()
        {
            return new List<DeliveryPerson>()
            {
                new DeliveryPerson(){DeliveryPersonFirstName = "Rex", DeliveryPersonLastName = "Herndon", DeliveryPersonUsername = "rherndon", DeliveryPersonPassword = "password1" },
                new DeliveryPerson(){DeliveryPersonFirstName = "Aditya", DeliveryPersonLastName = "Jagdale", DeliveryPersonUsername = "ajagdale", DeliveryPersonPassword = "password2" },
                new DeliveryPerson(){DeliveryPersonFirstName = "Chris", DeliveryPersonLastName = "Bland", DeliveryPersonUsername = "cbald", DeliveryPersonPassword = "password3" }
            };
        }

        

        

        
    }
