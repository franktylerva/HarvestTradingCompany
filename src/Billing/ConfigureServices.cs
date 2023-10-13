using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
 
namespace Billing
{
    public static class ConfigureServices
    {
        public static void AddBilling(this IServiceCollection services)
        {
            services.AddControllers().AddApplicationPart(typeof(BillingController).Assembly);
        }
    }
}