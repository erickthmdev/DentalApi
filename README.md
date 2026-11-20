# DentalApi

REST API for dental clinic management, developed with C# and ASP.NET Core 9.

The application provides features for managing patients, appointments, dental records, and financial operations. It uses PostgreSQL for data persistence and JWT-based authentication to protect API endpoints.

This project was developed as part of my back-end development portfolio, focusing on REST API design, layered architecture, database integration, and software engineering best practices.

## Technologies

- **C#**
- **ASP.NET Core 9**
- **Entity Framework Core**
- **PostgreSQL**
- **JWT Authentication**
- **AutoMapper**
- **Repository Pattern**
- **Dependency Injection**

## Features

### Patient Management
- Patient registration and management
- Patient history

### Appointment Management
- Appointment scheduling
- Appointment status management

### Dental Records
- Dental chart (odontogram)
- Treatment records by tooth

### Financial Management
- Treatment cost tracking
- Payment management

### Authentication and Authorization
- JWT-based authentication
- Protected API endpoints
- Access control based on implemented authorization rules

## Architecture

The project follows a layered architecture to separate responsibilities and improve maintainability.

```text
DentalApi/
├── Controllers/
├── Services/
├── Repositories/
├── DTOs/
├── Models/
└── Mappings/
```

### Layer Responsibilities

- **Controllers:** Handle HTTP requests and responses.
- **Services:** Implement business logic.
- **Repositories:** Abstract data access operations.
- **DTOs:** Define data structures for communication between clients and the API.
- **Models:** Represent application entities and data models.
- **Mappings:** Configure object mappings using AutoMapper.

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/)

### 1. Clone the Repository

```bash
git clone https://github.com/erickthmdev/DentalApi.git
cd DentalApi
```

### 2. Configure the Database

Create a PostgreSQL database and configure the connection string required by the application.

If the repository includes an `appsettings.example.json` file, copy it to `appsettings.json` and update the database credentials.

Do not commit passwords, JWT signing keys, or other sensitive configuration values to version control.

### 3. Restore Dependencies

```bash
dotnet restore
```

### 4. Apply Database Migrations

If Entity Framework Core migrations are configured, run:

```bash
dotnet ef database update
```

Make sure the Entity Framework Core CLI is installed and compatible with the project's package versions.

### 5. Run the Application

```bash
dotnet run
```

The API will start at the address displayed in the terminal.

If Swagger is enabled in the current environment, access `/swagger` on the application's base URL to explore and test the available endpoints.

## Engineering Practices

The project applies the following development concepts:

- RESTful API design
- Separation of concerns
- Layered architecture
- Object-relational mapping with Entity Framework Core
- Dependency injection
- Repository Pattern
- DTO-based data transfer
- JWT authentication and authorization

## Author

**Erick** — Back-end Developer

- GitHub: [@erickthmdev](https://github.com/erickthmdev)

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
