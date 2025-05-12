# EmployeeAPI

A RESTful API built with **ASP.NET Core Web API** for managing employee data. This backend service allows CRUD operations on employee records and is designed to be easily extensible and maintainable.

## Features

- ✅ Create, Read, Update, and Delete employees
- 🌐 CORS support *(if configured)*
- 🔄 Entity Framework Core for database operations

## Tech Stack

- **.NET Core SDK** (version X.X)
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version X.X)
- SQL Server (local or remote)
- IDE (e.g., Visual Studio, VS Code)

### Clone the Repository

```bash
git clone https://github.com/your-username/EmployeeAPI.git
cd EmployeeAPI

Open Package Manager Console in Visual Studio:

1.Go to Tools > NuGet Package Manager > Package Manager Console
Add-Migration InitialCreate
Update-Database

2.Update your connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=EmployeeDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
3.run https
4.Access the API via:
   -https://localhost:7033/api/EmployeeAPI
Swagger UI
-Interactive API docs are available at:
 https://localhost:5001/swagger
API Endpoints:

| Method | Endpoint            | Description         |
| ------ | ------------------- | ------------------- |
| GET    | /api/employees      | Get all employees   |
| GET    | /api/employees/{id} | Get employee by ID  |
| POST   | /api/employees      | Create new employee |
| PUT    | /api/employees/{id} | Update employee     |
| DELETE | /api/employees/{id} | Delete employee     |


