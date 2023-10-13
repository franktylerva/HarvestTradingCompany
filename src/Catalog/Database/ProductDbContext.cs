using Catalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Database;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Entities.Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entities.Product>().HasData(GetProducts());
    }

    List<Entities.Product> GetProducts()
    {
        return Enumerable.Range(1, 100)
            .Select(index => new Entities.Product
            {   
                Id = Guid.NewGuid(),
                Name = $"Product-{index}"
            }).ToList();
    }
    
}