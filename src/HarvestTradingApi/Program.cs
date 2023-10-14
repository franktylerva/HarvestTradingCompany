using Sales;
using Shipping;
using Billing;
using Microsoft.OpenApi.Models;
using Catalog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSales();
builder.Services.AddShipping();
builder.Services.AddBilling();
builder.AddCatalog();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Harvest Trading Company", Version = "v1" });
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();

app.MapSales();
app.MapShipping();
app.MapBilling();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

// app.MapGet("/", () => "Hello World from the main app...");

app.UseRouting();
app.MapControllers();

app.Run();