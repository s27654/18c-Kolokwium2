using Microsoft.EntityFrameworkCore;
using Kolokwium2.Models;
namespace Kolokwium2.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sale>()
            .HasKey(sr => new { sr.IdSale});

        modelBuilder.Entity<Sale>()
            .HasOne(sr => sr.IdClient)
            .WithMany()
            .HasForeignKey(sr => sr.IdClient);

        modelBuilder.Entity<Sale>()
            .HasOne(sr => sr.IdSubscription)
            .WithMany()
            .HasForeignKey(sr => sr.IdSubscription);
        
        modelBuilder.Entity<Payment>()
            .HasKey(sr => new { sr.IdPayment});

        modelBuilder.Entity<Payment>()
            .HasOne(sr => sr.IdClient)
            .WithMany()
            .HasForeignKey(sr => sr.IdClient);

        modelBuilder.Entity<Payment>()
            .HasOne(sr => sr.IdSubscription)
            .WithMany()
            .HasForeignKey(sr => sr.IdSubscription);
        
        modelBuilder.Entity<Discount>()
            .HasKey(sr => new { sr.IdDiscount});

        modelBuilder.Entity<Discount>()
            .HasOne(sr => sr.IdSubscription)
            .WithMany()
            .HasForeignKey(sr => sr.IdSubscription);
        
    }
}