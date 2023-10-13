# **Harvest Trading Company**



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