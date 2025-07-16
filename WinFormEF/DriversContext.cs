using Microsoft.EntityFrameworkCore;
using WinFormEF;

namespace WinFormEF;

public class DriversContext : DbContext
{
    public DbSet<Driver> Drivers { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=drivers;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>().HasData(
            new Driver { DriverId = 1, firstName = "Robert", lastName = "Jacobs", age = 34, vehicleType = "Truck" },
            new Driver { DriverId = 2, firstName = "Jack", lastName = "William", age = 55, vehicleType = "Train" },
            new Driver { DriverId = 3, firstName = "Bob", lastName = "Adams", age = 23, vehicleType = "Truck" },
            new Driver { DriverId = 4, firstName = "Will", lastName = "Smith", age = 45, vehicleType = "Truck" },
            new Driver { DriverId = 5, firstName = "Doom", lastName = "Slayer", age = 56, vehicleType = "Car" },
            new Driver { DriverId = 6, firstName = "Space", lastName = "Marine", age = 33, vehicleType = "Train" });







    }
}