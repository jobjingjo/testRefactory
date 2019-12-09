using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Services.Models;

namespace WebApplication.Services.Data
{
    public class DefaultContext:DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        { }

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(b => b.Models);

            modelBuilder.Entity<VehicleModel>()
                .HasOne(b => b.Manufacturer)
                .WithMany(x=>x.Models)
                .HasForeignKey(x=>x.ManufacturerId);

            //modelBuilder.Seed();
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleModelConfiguration());
        }
        //https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
        //https://code-maze.com/migrations-and-seed-data-efcore/
        //https://www.learnentityframeworkcore.com/migrations/seeding

    }
}
