# Pierre's Bakery Database

#### By Hayley McVay

## Description

Web App for Pierre's Bakery to keep track of their business's Flavors and Treats. The app features a login option so that authenticated users have full CRUD capabilities, while non authenticated users can only view. 

The website allows the user to add treats and flavors to their database, independent from each other, as well as make connections between which treats are associated with which flavors, and visa-versa. 

<br>

This project creates and implements a backend database that users can access and interact with on the front-end.

<br>

## Technologies Used

* C#
* .NET 5.0
* Microsoft EntityFrameworkCore
* ASP.NET MVC
* MySQL Workbench
* Microsoft Identity
* Razor

<br>

## Setup/Installation Requirements
<br>

### NECESSARY INSTALLATIONS

* [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer)
* [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

### SETUP STEPS

1. Clone [this](https://github.com/hmcvay/SweetsNTreats.Solution) repository to your desktop
2. Navigate to the project's root directory and create `appsettings.json` file with the following code: 

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hayley_mcvay;uid=root;pwd={YOURPASSWORDHERE};"
  }
}
```

3. replace `{YOURPASSWORDHERE}` with the password you used when setting up MySQLWorkbench

### COMMANDS

1. Navigate to the production directory, `TreatsNSweets`: 
  * Run `dotnet restore` to restore all dependencies
  * Run `dotnet ef database update` to connect to the database
  * Run `dotnet build`
  * Run `dotnet run` to run the program
  * You can now copy and paste the localhost link to your browser to view application

<br>

## Known Bugs

* Currently you can have duplicate relationships; you can add croissant to "sweet" more than once, so when you click on "sweet" flavor it will list multiple "croissant"s.

<br>

## License

[ISC](https://opensource.org/licenses/ISC)

<br>

## Contact

_Copyright (c) 2022 Hayley McVay_

