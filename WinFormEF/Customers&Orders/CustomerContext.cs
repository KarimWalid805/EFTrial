using Microsoft.EntityFrameworkCore;
using WinFormEF.CatPro;

namespace WinFormEF.Customers;

public class CustomerContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OnlineDeliveryDB;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            new Customer { CustomerId = 1, firstName = "Max", lastName = "Cheddar", Address = "Lazou Exarchi 6", age = 23 },
            new Customer { CustomerId = 2, firstName = "Kobe", lastName = "Bryant", Address = "Atinska 12", age = 26 },
            new Customer { CustomerId = 3, firstName = "Chuck E", lastName = "Cheese", Address = "Moubarak 6", age = 29 },
            new Customer { CustomerId = 4, firstName = "Mike", lastName = "Hawk", Address = "Kalis Elpidos 16", age = 31 },
            new Customer { CustomerId = 5, firstName = "Francis", lastName = "Swiss", Address = "Ullmanstrasse 54", age = 54 },
            new Customer { CustomerId = 6, firstName = "Henry", lastName = "Gruyere", Address = "Chantilly 25", age = 34 },
            new Customer { CustomerId = 7, firstName = "Teddy", lastName = "Colby", Address = "Townsville 15", age = 45 });






    }
}