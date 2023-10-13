using Microsoft.AspNetCore.Mvc;

namespace Product;

[ApiController]
[Route("/api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public String Get()
    {
        return "Products";
    }
}