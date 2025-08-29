using Microsoft.EntityFrameworkCore;
using WinFormEF.CatPro;

namespace WinFormEF.Customers;

public class CustomerContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Orders> Orders { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OnlineDeliveryDB;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>();

        modelBuilder.Entity<Orders>().HasOne(o => o.Customer)
        .WithMany(c => c.Orders)
        .HasForeignKey(o => o.CustomerId);





    }
}