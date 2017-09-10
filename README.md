# AspNetCore-Identity-Mongo-Sample
This sample shows how to use Mongo as backend database in ASP.NET Core Identity project.

## Code go thru
* DBInitializer.cs initializes RBAC sample data
  * Create Admin role
  * Create admin user and assign to Admin role
* [Authorize(Roles = "Admin")] code in controllers restricts access to users users in Admin role
* Identity database connection string is configured in appsettings.json

## Reference
* https://gist.github.com/mombrea/9a49716841254ab1d2dabd49144ec092