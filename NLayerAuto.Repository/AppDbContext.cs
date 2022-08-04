using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayerAuto.Core.Model;

namespace NLayerAuto.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Cars> Products { get; set; }
    public DbSet<CarsFeature> ProductFeatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Entity<CarsFeature>().HasData(new CarsFeature
        {
            Id = 1,
            Color = "Black",
            Headlights = true,
            Wheels = 4,
            CarsId = 1
        },
            new CarsFeature
            {
                Id = 2,
                Color = "White",
                Headlights = true,
                Wheels = 0,
                CarsId = 2
            },
            new CarsFeature
            {
                Id = 3,
                Color = "Blue",
                Headlights = true,
                Wheels = 4,
                CarsId = 3
            }
            );
        base.OnModelCreating(modelBuilder);
    }
}