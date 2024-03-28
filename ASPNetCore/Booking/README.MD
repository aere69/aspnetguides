# SAMPLE APPLICATION USING ONION ARCHITECTURAL PATTERN

The onion architecture pattern is a variation on traditional layered architecture that promotes a more flexible and sustainable way of designing and structuring applications. It is particularly suitable and recommended for building robust, maintainable and testable applications.

The main idea of onion architecture is to organize the application into circles or concentric layers, with each layer depending only on the inner layers.

From the inside out:
1. Domain
2. Infrastructure
3. Application
4. UI (Presentation)

# CREATE THE SOLUTION.

Start by creating a an ASP.Net Core solution project.

```sh
dotnet new sln -n BookingFast
```

## 1. DOMAIN LAYER

- The most internal layer. 
- Contains the most critical part of the business logic, representing the core of the application.
- Must be completely independent of any external structures. 
- The Core layer, defines your domain models, business rules and application-specific logic. 
- The Core layer should have no dependencies on the other layers and is often called the “Domain” or “Entities” layer.

To create the domain layer in the project and add it to the solution class, use the following commands:

```sh
dotnet new classlib -n BookingFast.Domain
dotnet sln BookingFast.sln add BookingFast.Domain\BookingFast.Domain.csproj
```

Inside the “BookingFast.Domain” folder, create a new folder called “Entities”.
Inside the Entities folder create a class **Reservation.cs** which is the main entity of the application.

## 2. INFRASTRUCTURE LAYER

- Responsible for interacting with external systems, structures and services.
- Includes code related to data access, communication with external services and other infrastructure issues. 
- Can have dependencies on external libraries, frameworks and ASP.NET Core itself.

To create the Infrastructure layer and add it to the solution, at the root of the project execute the following commands:

```sh
dotnet new classlib -n BookingFast.Infrastructure
dotnet sln BookingFast.sln add BookingFast.Infrastructure\BookingFast.Infrastructure.csproj
```

First, we need to download the dependencies to the infrastructure layer, so open a terminal in the infrastructure project and execute the following commands:

```sh
dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions --version 8.0.0
dotnet add package MongoDB.Driver --version 2.22.0
```

Now, let’s create the class that will contain the variables responsible for storing the values of the database connection string.

Then, inside the “BookingFast.Infrastructure” folder, create a new folder called “Repositories.” Inside it, create a new class called “StudentDatabaseSettings”.

