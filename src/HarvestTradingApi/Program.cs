using Sales;
using Shipping;
using Billing;
using Microsoft.OpenApi.Models;
using Product;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSales();
builder.Services.AddShipping();
builder.Services.AddBilling();
builder.AddProduct();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Harvest Trading Company", Version = "v1" });
});

var app = builder.Build();

app.MapSales();
app.MapShipping();
app.MapBilling();

app.UseSwagger();
app.UseSwaggerUI();
    

app.MapGet("/", () => "Hello World from the main app...");

app.UseRouting();
app.MapControllers();

app.Run();