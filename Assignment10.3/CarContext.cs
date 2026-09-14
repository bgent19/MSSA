using Microsoft.EntityFrameworkCore;

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public string DbPath { get; }

    public CarContext()
    {
        DbPath = Path.Combine(AppContext.BaseDirectory, "cars.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // VIN should be unique for every car.
        modelBuilder.Entity<Car>()
            .HasIndex(c => c.VIN)
            .IsUnique();

        // Seed data - these rows are inserted when the migration runs.
        // Ids must be set by hand for seed data.
        modelBuilder.Entity<Car>().HasData(
            new Car { Id = 1, VIN = "1HGCM82633A004352", Make = "Honda", Model = "Accord", Year = 2019, Price = 18500m, Mileage = 42000, Color = "Silver" },
            new Car { Id = 2, VIN = "1FTFW1ET5EKF51234", Make = "Ford", Model = "F-150", Year = 2021, Price = 34900m, Mileage = 27500, Color = "Blue" },
            new Car { Id = 3, VIN = "5YJ3E1EA7KF317890", Make = "Tesla", Model = "Model 3", Year = 2022, Price = 38750m, Mileage = 15200, Color = "White" },
            new Car { Id = 4, VIN = "JTDKN3DU0A0123456", Make = "Toyota", Model = "Prius", Year = 2017, Price = 14200m, Mileage = 68000, Color = "Red" },
            new Car { Id = 5, VIN = "WBA3A5C51CF256789", Make = "BMW", Model = "328i", Year = 2018, Price = 21300m, Mileage = 51000, Color = "Black" }
        );
    }
}
