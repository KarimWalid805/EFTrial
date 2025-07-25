using Microsoft.EntityFrameworkCore;

namespace WinFormEF.Customers;

public class CustomerContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OnlineDeliveryDB;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       






    }
}