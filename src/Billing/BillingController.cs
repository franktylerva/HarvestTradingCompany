using Microsoft.AspNetCore.Mvc;

namespace Billing;

[ApiController]
[Route("/api/billing")]
public class BillingController : ControllerBase
{
    [HttpGet]
    public String Get()
    {
        return "Books 1";
    }
}