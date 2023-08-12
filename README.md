# **Pierre's Treats**

### By Michael Carroll

A webpage application using C# to create and use a database to store both Treats and Flavors in a database and link them by using many to many relationships. This webpage uses authentication to allow users with an account to Create, Edit, and Delete items in the database. If a user is not logged in, the user can only view the treats and flavors stored in the database.
Link to GH Page:
 
https://github.com/mcarroll138

## Technologies used 
- HTML
- CSS
- C#
- .NET 6.0
- MySQL Workbench
- SQL Database
- AspNetCore
- AspNetCore.Identity and Authorization
- Entity Framework
- Linq
- Mvc


## Complete setup/installation instructions 
- Clone this repository from GitHub
- Navigate to the PierresTreats directory in your terminal and create a new file called appsettings.json
- Within this file add the following lines of code:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YourDataBaseInfoHere];uid=[YourUserId];pwd=[YourPasswordHere];"
  }
}
- Run $dotnet ef database update to create the database scafhold
- Once this has been set up run $ dotnet watch run
- Once page loads, you will be at the Home Page where you can view both Treats and Flavors at Pierre's Treats. Using the Many to Many Relationships, you will be able to assign multiple treats to multiple flavors and vice versa. 

## Known Bugs

## License
MIT

Copyright (c) 2023 Michael Carroll

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.