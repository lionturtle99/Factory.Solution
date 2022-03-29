<h1 align="center">Dr. Sillystringz's Factory</h1>

#### By Liam Eller | [LinkedIn](https://www.linkedin.com/in/liamellerportland/) | [email](mailto:<liamthelastson@gmail.com>) | [website](https://lionturtle99.github.io/My_Portfolio/)

#### _A website for Sillystringz's Factory to keep track of engineers and machines_

## Technologies Used

* C#
* html
* Markdown
* CSS
* Razor
* LINQ
* Entity
* Entity Framework Core
* ASP .NET Core
* ASP .NET Core MVC
* ASP .Net 5.0 CLI

## Description

_A MVC application demonstrating understanding of many-to-many relationships, Entity, LINQ, and ef Core_

## Setup/Installation Requirements
  
1. Follow the instruction on this [website](https://www.simplilearn.com/tutorials/mysql-tutorial/mysql-workbench-installation) for installing MySQL server, MySQL Workbench, and MySQL shell.  
2. Clone the repository to your desktop and open the project in your desired text editor. I recommend [visual studio code.](https://code.visualstudio.com/download)
3. open a new integrated terminal ny pressing the cmd + shift + p keys and searching for "create new integrated terminal", and then navigate to the production folder in the terminal by typing ```cd [PROJECT NAME]```
4. in the production folder, create a new file called appsettings.json in the project's production folder and add the following  
        ```
        {  
            "ConnectionStrings": {  
                "DefaultConnection": "Server=localhost;Port=3306;database=[NAME-OF-YOUR-DATABASE];uid=root;pwd=[YOUR-PASSWORD-HERE];"  
            }  
        }
        ```  
6. To actually build the database from the migrations: type ```dotnet ef database update``` in the terminal and then ```dotnet watch run```  
7. Finally, open your web browser and type http://localhost:5000/ in your url bar to see the application.
  
## Known Bugs

* No known bugs at this time.

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copyright (c) 2022 Liam Eller
