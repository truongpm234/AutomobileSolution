# 🚗 Automobile Store Management Application

### 📝 Introduction

###### This project is a WPF application for managing automobiles, developed using .NET Core and C#. The application supports basic CRUD operations (Create, Read, Update, Delete) on car data including CarID, CarName, Manufacturer, Price, and ReleasedYear. Data persistence is handled via a SQL Server database using Entity Framework Core.
---

### ✨ Features

-  Add new automobile entries.
-  View list of existing automobiles.
-  Modify automobile details.
-  Remove automobiles from the database.
---

### 🛠️ Technologies Used

- WPF (.NET Core)
- C#
- Entity Framework Core (EF Core)
- SQL Server
- Visual Studio.NET
- Design Patterns: Repository Pattern, Singleton Pattern
- Dependency Injection
---

### 📋 Prerequisites

##### - Visual Studio 2019 or later with .NET Core support
##### - SQL Server (Express or full version)
##### - .NET Core SDK
##### - Entity Framework Core tools

### ▶️ Running the Application

##### 1. Clone the repository: https://github.com/truongpm234/AutomobileSolution.git  
##### 2. Open the solution file (`AutomobileStore.sln`) in Visual Studio.  
##### 3. Update the database connection string in `appsettings.json` or in your DataProvider class to match your SQL Server setup.  
##### 4. Build and run the WPF application.  
---

### 📁 Project Structure

##### - AutomobileStore.WPF**: WPF UI project.  
##### - AutomobileStore.DataAccess**: Class library containing DbContext, Car model class and services interacting with database.  
##### - AutomobileStore.Repositories**: Contains Repository classes implementing CRUD logic.  
---

### 📬 Contact

##### For questions or feedback, please contact truongpm234 or [Email](ghoul1645@gmail.com).
