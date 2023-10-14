using Microsoft.AspNetCore.Mvc;
using Catalog.Database;
using Catalog.Entities;

namespace Catalog.Controllers;

[ApiController]
[Route("/api/products")]
public class ProductController : ControllerBase
{
    private readonly ProductDbContext _productDbContext;
    public ProductController(ProductDbContext productDbContext)
    {
        _productDbContext = productDbContext;
    }

    [HttpGet]
    public IEnumerable<Entities.Product> Get()
    {
        return Enumerable.Range(1, 100)
            .Select(index => new Entities.Product
            {   
                Id = Guid.NewGuid(),
                Name = $"Product-{index}"
            }).ToList();
    }
}