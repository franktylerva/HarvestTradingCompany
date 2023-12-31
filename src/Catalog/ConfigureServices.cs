using System.Configuration;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Catalog.Controllers;
using Catalog.Database;
using Steeltoe.Connector.EFCore;
using Steeltoe.Connector.MySql;
using Steeltoe.Connector.MySql.EFCore;
using Steeltoe.Management.TaskCore;

namespace Catalog
{
    public static class ConfigureServices
    {
        public static void AddCatalog(this WebApplicationBuilder builder)
        {
            ConfigureControllers(builder);
            // ConfigureSettings(builder);
            ConfigureDatabase(builder);
        }
        
        private static void ConfigureControllers(WebApplicationBuilder builder)
        {
            var assembly = typeof(ConfigureServices).Assembly;
            builder.Services.AddControllers().AddApplicationPart(assembly);
        }
        
        private static void ConfigureSettings(WebApplicationBuilder builder)
        {
            var assemblyPath = typeof(ConfigureServices).Assembly.Location;
            var directory = Path.GetDirectoryName(assemblyPath);
            
            Console.WriteLine($"Catalog: ${directory}");
            
            var fileProvider = new PhysicalFileProvider(directory);
            builder.Services.AddSingleton<IFileProvider>(fileProvider);
            builder.Configuration.AddJsonFile(fileProvider, "productSettings.json", false, true);
        }

        private static void ConfigureDatabase(WebApplicationBuilder builder)
        {
            builder.Services.AddMySqlConnection(builder.Configuration);
            builder.Services.AddDbContext<ProductDbContext>(options => options.UseMySql(builder.Configuration));
            builder.Services.AddTask<MigrateDbContextTask<ProductDbContext>>(ServiceLifetime.Transient);
        }
    }
}