# MyGarden

This app keeps track of where you planted what in your garden - and when.\
Enter the plants you want to track and your various spots in your garden.\
Log your actions and MyGarden gives you an overview to help you plan for crop rotation and to see where you might have space left.

## Technologies

Visual Studio 2019\
.Net Core/c#\
Entity Framework Core

## Setup
Clone the project to 'yourLocation' of your choice on your Windows computer.

If you want the MyGarden database on another server than localhost, or don't want to use a trusted connection: adjust 'yourLocation'\DBLab3\MyGarden\appsettings.json. I haven't (yet) added possibility to have different appsettings for different environments or to have User-Secrets though.

Open the solution and run update-database from the NuGet Package Manager Console.

Run the application, either within Visual Studio or from 'yourLocation'\DBLab3\MyGarden\bin\Debug\netcoreapp3.1\MyGarden.exe

