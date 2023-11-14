# cdn-solution-client

## Description

Welcome to my MVC (Model-View-Controller) Web Application project! This application is built on the ASP.NET framework, following the MVC architectural pattern. It features a Web API for seamless data interaction and utilizes Object-Relational Mapping (ORM) to connect with a local database.

## Table of Contents

- [Prerequisites](#Prerequisites)
- [Getting Started](#Getting-Started)
- [Project Structure](#Project-Structure)
- [Technologies Used](#Technologies-Used)
- [ORM and Local Database](#ORM-and-Local-Database)

## Prerequisites

### Before you begin, ensure you have the following installed on your machine:

- Visual Studio 
- .NET SDK 
- MSSQL

## Getting Started

1. Clone the repository to your local machine.

2. Open the solution file (CDNsolution.sln) in Visual Studio.

3. Build the solution to restore the NuGet packages

4. Set up the local database:
   - Ensure your local database server is running.
   - Update the connection string in the appsettings.json file to point to your database.

5. Run the database migrations:

```bash
    dotnet ef database update
```

6. Run the application:

 - Enable Multiple Startup Project and add Web APi Project from https://github.com/NSMohd/cdn-solution 
 - Press F5 or use the "Start Debugging" button in Visual Studio to launch the web application.

7. Access the Web API:

Utilize these endpoints for data operations, please read README.md in https://github.com/NSMohd/cdn-solution.

## Project Structure

- **Controllers**: Contains controllers for the web application, responsible for handling user requests and returning appropriate responses.

- **Models**: Holds the data models and business logic for the application.

- **Views**: Consists of UI components responsible for rendering the user interface.

- **wwwroot**: Stores static files such as stylesheets, scripts, and images.

- **Views/Shared**: Contains shared views and layout files.

- **AppSettings.json**: Configuration file for application settings.

## Technologies Used

- ASP.NET Core MVC
- ASP.NET Web API
- C#
- HTML
- Entity Framework Core (ORM)
- MSSQL (Local Database)

## ORM and Local Database

The application uses Entity Framework Core as the Object-Relational Mapping (ORM) tool to interact with a local database. The database schema and migrations are managed through EF Core.
