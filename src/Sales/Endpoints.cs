using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
 
namespace Sales
{
    public static class Endpoints
    {
        public static void MapSales(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/sales", () => "Hello from the Sales Module!");
        }
    }
}