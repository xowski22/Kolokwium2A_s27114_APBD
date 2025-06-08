namespace Kolokwium.Data;

using Microsoft.EntityFrameworkCore;
using Kolokwium.Models;

public class DatabaseContext : DbContext
{
    public DbSet<Available_Program> Available_Programs { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Program_Entity> ProgramEntities { get; set; }
    public DbSet<Purchase_History> PurchaseHistories { get; set; }
    public DbSet<Washing_Machine> WashingMachines { get; set; }
    
    protected DatabaseContext() {}

    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Available_Program>().HasData(new List<Available_Program>()
        {
            new Available_Program() { AvailableProgramId = 1, WashingMachineId = 1, ProgramId = 1, Price = 20.2},
            new Available_Program() { AvailableProgramId = 2, WashingMachineId = 2, ProgramId = 2, Price = 10.2},
            new Available_Program() { AvailableProgramId = 3, WashingMachineId = 3, ProgramId = 3, Price = 30.2},
        });
        
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { CustomerId = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "660321578"},
            new Customer() { CustomerId = 2, FirstName = "Jane", LastName = "Doe" },
            new Customer() { CustomerId = 3, FirstName = "John", LastName = "Doe", PhoneNumber = "660321578" },
        });
        
        modelBuilder.Entity<Program_Entity>().HasData(new List<Program_Entity>()
        {
            new Program_Entity() { ProgramId = 1, Name = "kjdbqwkjd", DurationMinutes = 40, TemperatureCelsius = 20},
            new Program_Entity() { ProgramId = 2, Name = "jkdnqwl", DurationMinutes = 20, TemperatureCelsius = 10},
            new Program_Entity() { ProgramId = 3, Name = "fnkwjef", DurationMinutes = 10, TemperatureCelsius = 30},
        });
        
        modelBuilder.Entity<Purchase_History>().HasData(new List<Purchase_History>()
        {
            new Purchase_History() { AvailableProgramId = 1, CustomerId = 1, PurchaseDate = DateTime.Parse("2025-05-01"), Rating = 3},
            new Purchase_History() { AvailableProgramId = 3, CustomerId = 3, PurchaseDate = DateTime.Parse("2026-05-01"), Rating = 1},
            new Purchase_History() { AvailableProgramId = 2, CustomerId = 2, PurchaseDate = DateTime.Parse("2027-05-01"), Rating = 2},
            new Purchase_History() { AvailableProgramId = 4, CustomerId = 4, PurchaseDate = DateTime.Parse("2028-05-01"), Rating = 5},
        });
        
        modelBuilder.Entity<Washing_Machine>().HasData(new List<Washing_Machine>()
        {
            new Washing_Machine() { WashingMachineId = 1, MaxWeight = 40.6, SerialNumber = "bdjqwebkwbfkw"},
            new Washing_Machine() { WashingMachineId = 2, MaxWeight = 40.7, SerialNumber = "wflkjwelkfw"},
            new Washing_Machine() { WashingMachineId = 3, MaxWeight = 40.8, SerialNumber = "fbwefbwk"},
        });
    }
}