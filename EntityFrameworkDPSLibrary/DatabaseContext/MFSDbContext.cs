using EntityFrameworkDPSLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;


namespace EntityFrameworkDPSLibrary.DatabaseContext
{
    /// <summary>
    /// Class containe database context for MicorosoftDatabase
    /// </summary>
    public class MFSDbContext : DbContext
    {
        public MFSDbContext() : base()
        {
        }
        public MFSDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()

                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<DailyInvoiceCounter> DailyInvoiceCounter { get; set; }
        public DbSet<ProductsOnInvoice> ProductsOnInvoice { get; set; }

    }
}
