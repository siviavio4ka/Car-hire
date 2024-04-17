# Car-hire

Car-hire is a web API that can be used as the basis for a car rental system. The project was developed using a three-layer architecture and REST API principles on ASP.NET Core Web API 8. It also implements authentication and authorization using JWT tokens based on ASP.NET Core Identity. It is possible to deploy the project in Docker.

## Technologies:
| **Category** |       **Name**        | **Version** |
|--------------|-----------------------|-------------|
| Platform     | .NET                  | 8           | 
| Language     | C#                    | 12          |
| IDE          | VS Code               | 1.88.1      |
| DBMS         | PostgreSQL            | 16.2        |
| ORM          | Entity Framework Core | 8.0.2       |
| API docs     | Swagger               | 6.5.0       |
| Logger       | Serilog               | 8.0.1       |
| Mapper       | AutoMapper            | 13.0.1      |

## Installation

Steps to deploy the project in Docker:

1. Clone this repository.

        git clone https://github.com/siviavio4ka/Car-hire.git

2. Move to the project folder.

        cd Car-hire

3. Run docker-compose.

        docker-compose up -d --build

4. Application is available on port 8080 on your machine.

        http://localhost:8080/swagger/index.html