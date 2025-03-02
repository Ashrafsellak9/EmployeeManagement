Employee Management System
Overview
This is a web-based Employee Management System built with ASP.NET Core, Entity Framework, and Bootstrap. The application allows users to manage employee data, including the ability to Create, Read, Update, and Delete employee records.

Features
CRUD Operations: Create, Read, Update, and Delete employee records.
Bootstrap Integration: Responsive design for better user experience.
Database Integration: The application connects to a local SQL Server database for data persistence.
Data Validation: Validation for employee fields like name, position, and age.
Tech Stack
Frontend:
ASP.NET Core Razor Pages
Bootstrap 5 for responsive design
Backend:
C#
ASP.NET Core MVC
Entity Framework Core for ORM (Object-Relational Mapping)
Database:
SQL Server (LocalDB or any other SQL Server)
Prerequisites
Before you begin, ensure you have the following installed on your machine:

.NET Core SDK (version 3.1 or higher) Download here
SQL Server (LocalDB works fine for local development)
Visual Studio or Visual Studio Code
Getting Started
Clone the repository

git clone https://github.com/Ashrafsellak9/EmployeeManagementSystem.git
cd EmployeeManagementSystem
Install Dependencies
Run the following command to restore the necessary dependencies:


dotnet restore
Set up the Database
Configure the Connection String:
Open appsettings.json and update the connection string to match your database setup:


"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeBD;Integrated Security=True;"
}
Apply Migrations:
Run the following commands to create the database schema based on the models:


dotnet ef migrations add InitialCreate
dotnet ef database update
Run the Application
Once the dependencies are installed and the database is set up, you can run the application:


dotnet run
Visit http://localhost:5000 in your browser to interact with the application.

Application Structure
Pages/Employees: Contains pages for listing, creating, editing, and deleting employees.

Index.cshtml: Displays a list of all employees.
Create.cshtml: A form to create a new employee.
Edit.cshtml: A form to edit an existing employee.
Delete.cshtml: A confirmation page for deleting an employee.
Models: Contains the Employee model used to represent the employee entity.

Data: Contains the ApplicationDbContext class for database interactions.

wwwroot/css: Contains custom styles if needed.

Known Issues
None so far!

Future Enhancements
Authentication: Add user authentication to restrict access to certain functionalities.
API Integration: Expose the data via an API to allow external applications to interact with the employee records.
Advanced Search & Pagination: Implement search and pagination features for better data navigation.
Contributing
If you'd like to contribute to this project, feel free to fork the repository, create a new branch, and submit a pull request. All contributions are welcome!
License
This project is open-source and available under the MIT License.
