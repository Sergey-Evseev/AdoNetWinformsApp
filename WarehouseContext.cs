using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdoNetWinformsApp
{
    public class WarehouseContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodType> GoodTypes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder
                .UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(GoodEntityMap).Assembly);
        }
    }
}
