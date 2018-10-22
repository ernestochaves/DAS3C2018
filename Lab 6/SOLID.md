# SOLID #

Refferences
- https://www.codeproject.com/Articles/822791/Developing-MVC-applications-using-SOLID-principles 
- https://www.dotnetcurry.com/software-gardening/1365/solid-principles 

1. Single responsibility

*A method should only have a reason to change.*  
- Other concepts: Command Query Responsibility Separation (CQRS). 
2. Open Closed principle

*Open for extension, closed for modification*
- Refactor, BugFixing, Changes that don´t have side effects
3. Liskov Substitution Principle 

*given a specific base class, any class that inherits from it, can be a substitute for the base class*


- Barbara Liskov
- maintaining "Is A"
- Good abstractions

4. Interface Segregation Principle 

* interfaces should be small and should contain only those methods or properties that are effectively required*
- This related to Sing. Resp. 
- List<Example>
- Bob Martin: “Clients should not be forced to depend on methods that they do not use.”
- Fat interfaces

5. Dependency Inversion Principle 

**“A. High-level modules should not depend on low-level modules. Both should depend on abstractions.** 

**"B. Abstractions should not depend upon details. Details should not depend upon abstractions.”**

- Constructor, Property
- Poor man's DI, DI COntainers
- Importance for Unit testing





# EXAMPLE #
- EF Core aspnet core refference https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/new-db?tabs=visual-studio 
Add-Migration InitialCreate
Update-Database

- EF Core console app refference https://docs.microsoft.com/en-us/ef/core/get-started/full-dotnet/new-db
- Install-Package Microsoft.EntityFrameworkCore.Tools
- Install-Package Microsoft.EntityFrameworkCore.SqlServer

