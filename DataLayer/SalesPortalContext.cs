using Microsoft.EntityFrameworkCore;
using SalesPortalDL.Entities;

namespace SalesPortalDL.DataConnection
{
    public class SalesPortalContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _serverVersion;
        public SalesPortalContext(string connectionString, string serverVersion)
        {
            this._connectionString = connectionString;
            this._serverVersion = serverVersion;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql(this._connectionString,
                    new MySqlServerVersion(new Version(this._serverVersion)),
                    null);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<PurchaseDetail>().ToTable("PurchaseDetail");
        }

        //Entities 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
    }
}