# Sikho Backend

Web App to show progress of automation across different industries.


Demo: https://youtu.be/P_h8hO0skTk?si=-9DiJFBQ3O1U51_M


## Frontend Code:
https://github.com/sarbjot-14/Sikho/blob/main/README.md

## Tech Stack

- **ASP.NET 7**
- **Docker**
  - Containerize sql server for local devlopement
- **Database** :
  - SQL Server
- **ORM** :
  - Entity Framework

## Deployment

- **Azure Web App**
  - used azure web app to deploy the .net api
- **Azure Database**
  - use Azure database service to deploy sql database
- **CI/CD**
  - used Github Actions to deploy app to Azure on push      
  
## Run
```
dotnet run --launch-profile https
```
## Building a sample

Build any .NET Core sample using the .NET Core CLI, which is installed with [the .NET Core SDK](https://www.microsoft.com/net/download). Then run
these commands from the CLI in the directory of any sample:

```console
dotnet build
dotnet run
```
