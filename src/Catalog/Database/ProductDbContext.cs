using Catalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Database;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Entities.Product>? Products { get; set; }
    
    public DbSet<Author>? Authors { get; set; }
}