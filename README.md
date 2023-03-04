# CarFleet

# Database
Person:
•	ID
•   FirstName
•	LastName
•	PhoneNumber
Users:
•	ID
•	UserName
•	PasswordHash
•	PersonID
•	RoleID
Vehicle:
•	ID
•	Manufacturer
•	Model
•	ProductionYear
•	LicensePlate
•	VinNumber
•	CreatedOn
•	CreatedByID
•	UpdatedOn
•	UpdatedByID
VehiclePersonHistory:
•	ID
•	VehicleID
•	PersonID
•	CreatedOn
•	CreatedByID
•	UpdatedOn
•	UpdatedByID
VehicleInspection:
•	ID
•	VehicleID
•	DateOfInspection
•	DateOfNextInspection
•	CreatedOn
•	CreatedByID
•	UpdatedOn
•	UpdatedByID
VehicleDescription
•	ID
•	VehicleID
•	Description
•	CreatedOn
•	CreatedByID
•	UpdatedOn
•	UpdatedByID
VehcileStatus:
•	ID
•	VehicleID
•	Status
•	CreatedOn
•	CreatedByID
