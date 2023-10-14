# **Harvest Trading Company**

Harvest Trading Company is a .Net Core application that utilizes different modules to serve up a Blazor Web Assembly 
application with backing API services.

## **Deployment to Tanzu Application Platform**
```
tanzu services class-claims create products-db --class mysql-unmanaged --parameter workloadRef.name=HarvestTrading

tanzu apps workload create harvest-trading -f src/HarvestTradingApi/config/workload.yaml
```

## **Database Setup**
In the root directory, start the supporting MySql database.

```
docker-compose up -d
```

## **Building**
Navigate to the src directory, and issue the dotnet build command.

```
cd src
dotnet build
```

## **Running**
Navigate to the src/HarvestTradingApi directory, and issue the dotnet run command.

```
cd src/HarvestTradingApi
dotnet run
```
Then navigate to http://localhost:5139.

Install the dotnet-ef data migration tool.
```
dotnet tool install dotnet-ef
dotnet tool install --local dotnet-ef
dotnet ef migrations add InitialCreate --project Catalog/Catalog.csproj --startup-project HarvestTradingApi/HarvestTradingApi.csproj --context ProductDbContext
dotnet ef database update --project Catalog/Catalog.csproj --startup-project HarvestTradingApi/HarvestTradingApi.csproj --context ProductDbContext
dotnet ef database drop --startup-project HarvestTradingApi/HarvestTradingApi.csproj --context ProductDbContext
```


