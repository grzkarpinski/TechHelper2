# TechHelper2

## Design:
Architecture: simplified layered architecture:
Layer 1: TechHelper.Client - Role: Frontend (Blazor WebAssembly)
Layer 2: TechHelper.ServerAPI - Role: Controllers (API)
Layer 3: TechHelper.Application - Role: Application (Business Logic)
Layer 4: TechHelper.Infrastructure - Role: database integration – EF Core, repositories
Layer 5: TechHelper.Shared - Role: Common Models, DTOs, Interfaces
TechHelper.Test - Role: tests
