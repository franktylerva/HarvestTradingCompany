using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
 
namespace Billing
{
    public static class Endpoints
    {
        public static void MapBilling(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/billing", () => "Hello from the Billing Module!");
        }
    }
}