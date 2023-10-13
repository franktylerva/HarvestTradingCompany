using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
 
namespace Product
{
    public static class ConfigureServices
    {
        public static void AddProduct(this IServiceCollection services)
        {
            services.AddControllers().AddApplicationPart(typeof(ProductController).Assembly);
        }
    }
}