using Microsoft.AspNetCore.Mvc;
using Catalog.Database;

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
    public String Get()
    {
        return "Products";
    }
}