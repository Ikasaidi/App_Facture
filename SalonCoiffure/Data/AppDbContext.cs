using Microsoft.EntityFrameworkCore;
using SalonCoiffure.Model;

namespace SalonCoiffure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Facture> Factures { get; set; }
       


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=salonCoiffure.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Factures)
                .WithOne(f => f.Customer)
                .HasForeignKey(f => f.CustomerId);

            modelBuilder.Entity<Facture>()
                .HasMany(f => f.Services)
                .WithOne(s => s.Facture)
                .HasForeignKey(s => s.FactureId);
        }

    }
}
