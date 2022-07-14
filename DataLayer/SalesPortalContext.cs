using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SalesPortalDL.Entities;

namespace SalesPortalDL.DataConnection
{
    public class SalesPortalContext : DbContext
    {

        protected readonly IConfiguration _configuration;

        public SalesPortalContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql(this._configuration.GetConnectionString("mySalesConnectionString"),
                    new MySqlServerVersion(new Version(_configuration["DatabaseVersion"])),
                    null);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers").HasKey(x => x.customerId);
            modelBuilder.Entity<Product>().ToTable("Products").HasKey(x => x.productId);
            modelBuilder.Entity<PurchaseDetail>().ToTable("PurchaseDetails").HasKey(x => x.purchaseId);
        }

        //Entities 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
    }
}