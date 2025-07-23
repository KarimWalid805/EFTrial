using Microsoft.EntityFrameworkCore;

namespace WinFormEF.Orders;

public class OrdersContext : DbContext
{
    public DbSet<Orders> Orders { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OnlineDeliveryDB;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {







    }
}
