USE master
GO

DROP DATABASE IF EXISTS CarFleetDB
GO

CREATE DATABASE CarFleetDB
GO

USE CarFleetDB
GO

CREATE TABLE Persons (
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	FirstName varchar(255) NOT NULL,
	LastName varchar(255) NOT NULL,
	PhoneNumber varchar(15) NOT NULL,
	Email nvarchar(255) NOT NULL,
	Disabled bit NOT NULL,
)

CREATE TABLE Users(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	UserName nvarchar(max) NOT NULL,
	PasswordHash nvarchar(max) NOT NULL,
	PersonID int NOT NULL,
	RoleID int NOT NULL,

	CONSTRAINT FK_User_Person FOREIGN KEY (PersonID) REFERENCES Persons(ID),
)

CREATE TABLE Vehicle(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	Manufacturer varchar(255),
	Model varchar(255),
	ProductionYear int,
	LicensePlate varchar(7)  NOT NULL,
	VinNumber varchar(17),
	CreatedOn datetime NOT NULL,
	CreatedByID int NOT NULL,
	UpdatedOn datetime NOT NULL,
	UpdatedByID int NOT NULL,

	CONSTRAINT FK_Vehicle_Person_Created FOREIGN KEY (CreatedByID) REFERENCES Persons(ID),
	CONSTRAINT FK_Vehicle_Person_Updated FOREIGN KEY (UpdatedByID) REFERENCES Persons(ID),
)

CREATE TABLE VehicleInsurer(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	VehicleID int,
	Insurer varchar(255),
	StartDateOfInsurence datetime,
	EndDateOfInsurence datetime,
	CreatedOn datetime NOT NULL,
	CreatedByID int NOT NULL,
	UpdatedOn datetime NOT NULL,
	UpdatedByID int NOT NULL,

	CONSTRAINT FK_VehicleInsurer_Vehicle FOREIGN KEY (VehicleID) REFERENCES Vehicle(ID),
	CONSTRAINT FK_VehicleInsurer_Person_Created FOREIGN KEY (CreatedByID) REFERENCES Persons(ID),
	CONSTRAINT FK_VehicleInsurer_Person_Updated FOREIGN KEY (UpdatedByID) REFERENCES Persons(ID),
)

CREATE TABLE VehiclePersonHistory(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	VehicleID int,
	PersonID int,
	CreatedOn datetime NOT NULL,
	CreatedByID int NOT NULL,
	UpdatedOn datetime NOT NULL,
	UpdatedByID int NOT NULL,

	CONSTRAINT FK_VehiclePersonHistory_Vehicle FOREIGN KEY (VehicleID) REFERENCES Vehicle(ID),
	CONSTRAINT FK_VehiclePersonHistory_Person_Created FOREIGN KEY (CreatedByID) REFERENCES Persons(ID),
	CONSTRAINT FK_VehiclePersonHistory_Person_Updated FOREIGN KEY (UpdatedByID) REFERENCES Persons(ID),
)
CREATE TABLE VehicleInspection(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	VehicleID int,
	DateOfInspection datetime,
	DateOfNextInspection datetime,
	CreatedOn datetime NOT NULL,
	CreatedByID int NOT NULL,
	UpdatedOn datetime NOT NULL,
	UpdatedByID int NOT NULL,

	CONSTRAINT FK_VehicleInspection_Vehicle FOREIGN KEY (VehicleID) REFERENCES Vehicle(ID),
	CONSTRAINT FK_VehicleInspection_Person_Created FOREIGN KEY (CreatedByID) REFERENCES Persons(ID),
	CONSTRAINT FK_VehicleInspection_Person_Updated FOREIGN KEY (UpdatedByID) REFERENCES Persons(ID),
)

CREATE TABLE VehicleDescription(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	VehicleID int,
	Description varchar(max),
	CreatedOn datetime NOT NULL,
	CreatedByID int NOT NULL,
	UpdatedOn datetime NOT NULL,
	UpdatedByID int NOT NULL,

	CONSTRAINT FK_VehicleDescription_Vehicle FOREIGN KEY (VehicleID) REFERENCES Vehicle(ID),
	CONSTRAINT FK_VehicleDescription_Person_Created FOREIGN KEY (CreatedByID) REFERENCES Persons(ID),
	CONSTRAINT FK_VehicleDescription_Person_Updated FOREIGN KEY (UpdatedByID) REFERENCES Persons(ID),
)

CREATE TABLE VehicleStatus(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	VehicleID int,
	Status int,
	CreatedOn datetime NOT NULL,
	CreatedByID int NOT NULL,

	CONSTRAINT FK_VehcileStatus_Vehicle FOREIGN KEY (VehicleID) REFERENCES Vehicle(ID),
	CONSTRAINT FK_VehcileStatus_Person_Created FOREIGN KEY (CreatedByID) REFERENCES Persons(ID),
)

CREATE TABLE VehicleMileage(
	ID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	VehicleID int,
	Mileage int,
	CreatedOn datetime NOT NULL,
	CreatedByID int NOT NULL,
	UpdatedOn datetime NOT NULL,
	UpdatedByID int NOT NULL,

	CONSTRAINT FK_VehicleMileage_Vehicle FOREIGN KEY (VehicleID) REFERENCES Vehicle(ID),
	CONSTRAINT FK_VehicleMileage_Person_Created FOREIGN KEY (CreatedByID) REFERENCES Persons(ID),
	CONSTRAINT FK_VehicleMileage_Person_Updated FOREIGN KEY (UpdatedByID) REFERENCES Persons(ID),
)

ALTER DATABASE SCOPED CONFIGURATION 
  SET VERBOSE_TRUNCATION_WARNINGS = ON;