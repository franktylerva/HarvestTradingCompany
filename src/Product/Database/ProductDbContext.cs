using Microsoft.EntityFrameworkCore;
using Product.Entities;

namespace Product.Database;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Entities.Product>? Products { get; set; }
    
    public DbSet<Author>? Authors { get; set; }
}