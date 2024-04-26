# Fleet Management for Companies
# Introduction
   This program aims to facilitate easier management of a corporate vehicle fleet.

   The program allows you to:
       - Add and store information about company users
       - Add and store information about company vehicles
       - Add and store the history of employees who have used a given vehicle
       - Add and store the mileage history of the vehicle
       - Add and store the insurance history for the vehicle
       - Add and store the inspection history for the vehicle
       - Add and manage additional information about the vehicle
       - Add vehicle status and store its history

# Initial Information on Starting and Running the Program

   Framework used: .NET Framework 4.7.2

   Starting the program:
       - The application requires setting up an MS SQL database to function:
           In the `DataBaseScripts` folder, there are two scripts:
               1. The `CreateCarFleetDBScript` script creates the CarFleet database.
                  If the database isn't created correctly, you can use the `CarFleetDBScript` found in the `Scripts` folder.
               2. The `CreateAdminUser` script inserts data into the `Persons` and `Users` tables, creating an administrator account with the login `admin` and password `admin`.
       - Launch the program's project from the `CarFleet.sln` file.
       - If you need to modify the connection string, you can do this in `CarFleetDomain` -> `Context`.
       - You can launch the program either from the development environment by pressing F5 (debugging mode) or Ctrl + F5 (release mode), or by going to `CarFleet` -> `bin` -> `Debug` and running the `CarFleet.exe` file.
       - After starting the application, a login panel appears, where you enter `admin` as the login and `admin` as the password.

   Folders:
       - `Documentation`: This folder contains the program's documentation.
       - `CreateCarFleetDBScript`: Scripts required for the correct functioning of the application.
       - `Scripts`: Developer scripts used to generate dummy data; use only for testing purposes.
       - `CarFleet`: The folder mainly contains the application's front end.
       - `CarFleetDomain`: The folder mainly contains the application's back end.

# Authors
Mateusz Jaruga
Mateusz Kalenik
