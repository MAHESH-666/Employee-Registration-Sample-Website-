# Employee, Vehicle & Travel Information — ASP.NET MVC

A legacy ASP.NET MVC sample that manages employee/user records, vehicle associations, and travel information using Entity Framework's database-first model.

## Features found in the application

- User/employee data entry
- Vehicle record entry associated with users
- Travel information workflow
- View model combining user, vehicle, and travel records
- Entity Framework model/context generated from an existing database schema

## Technology

- C#
- ASP.NET MVC 5
- .NET Framework (see `VehicleData.csproj`)
- Entity Framework 6 / EDMX database-first model
- SQL Server
- Razor views

## Run locally

1. Open `VehicleData.sln` in Visual Studio on Windows.
2. Restore NuGet packages.
3. Inspect `Web.config` and configure the SQL Server connection string for a local development database.
4. Ensure the database schema expected by the EDMX/context exists.
5. Run with IIS Express.

## Notes

This is a legacy learning/sample project. Review the database model, validation, and error handling before reuse. Do not commit real credentials or private employee/travel data.
