using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
 
namespace Shipping
{
    public static class Endpoints
    {
        public static void MapShipping(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/shipping", () => "Hello from the Shipping Module!");
        }
    }
}