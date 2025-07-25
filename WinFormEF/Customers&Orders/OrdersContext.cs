using Microsoft.EntityFrameworkCore;
using WinFormEF.CatPro;

namespace WinFormEF.Customers;

public class OrdersContext : DbContext
{
    public DbSet<Orders> Orders { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OnlineDeliveryDB;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Orders>().HasData(
           //new Orders { OrderId = 1, Address = "Lazou Eaxrchi 4", orderDate = "25-07-2025", CustomerId = 1, "" },
           //new Orders { OrderId = 2, Address = "Kalis Elpidos 16", orderDate = "23-07-2025", CustomerId = 2 },
           //new Orders { OrderId = 3, Address = "Centreville 25", orderDate = "21-07-2025", CustomerId = 3 },
           //new Orders { OrderId = 4, Address = "Summerville 12", orderDate = "20-07-2025", CustomerId = 4 });






    }
}
