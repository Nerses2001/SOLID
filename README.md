# SOLID
## Single Responsibility Principle (SRP) Example

This repository contains code examples demonstrating the Single Responsibility Principle (SRP) from the SOLID principles in object-oriented design. The code showcases a violation of SRP and a solution adhering to SRP.

## SRP Violation

In the `SOLID.ModelSRPViolation` namespace, there is a `Phone` class that implements the `IPhone` interface. However, this violates SRP as the `Phone` class has responsibilities related to both handling the phone connection (`Dial`, `Disconnect`) and data management (`Send`, `Receive`).

## SRP Solution

To address the SRP violation, the code presents a solution in the `SOLID.ModelSrpSolution` namespace. It introduces separate classes for connection management (`ConnectionManagerImplementation`) and data management (`DataManagerImplementation`), adhering to the SRP.

Additionally, the `PhoneSRP` class acts as a cohesive integration of the connection and data management components, adhering to SRP by separating concerns effectively.

## Employee Architecture

In the `SOLID.EmployeeArchitecture` namespace, an example of clean architecture and usage of various design patterns is provided. The code showcases a simplified employee management system.

### Report Formatting

- `ReportFormatter` and `EmployeeReportFormatter` demonstrate formatting an employee's information into XML or CSV formats, allowing for flexibility and maintainability.

### Employee Data Access Object (DAO)

- `EmployeeDAO` handles saving and deleting employee information, adhering to separation of concerns.

### Employee Class

- `Employee` class represents an employee entity with relevant attributes.

### Database Connection Management

- `DatabaseConnectionManager` demonstrates managing a database connection using Entity Framework Core, following best practices and encapsulating database-related functionalities.

### Client Module

- `ClientModule` provides methods for hiring and terminating employees, printing employee reports, and acting as an entry point for client interactions with the employee management system.

## Usage

To run the code and see the examples in action, use appropriate development tools and execute the relevant entry points.

