using Microsoft.EntityFrameworkCore;
using WebApplication.Services.Models;

namespace WebApplication.Services.Data
{
    public class DefaultContext : DbContext
    {

        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(b => b.Models)
                .WithOne(e => e.Manufacturer);

            modelBuilder.Entity<VehicleModel>()
                .HasOne(b => b.Manufacturer)
                .WithMany(x => x.Models)
                .HasForeignKey(x => x.ManufacturerId);

            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleModelConfiguration());
        }
    }
}
