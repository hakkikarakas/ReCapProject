CREATE TABLE Users(
	UserId int NOT NULL IDENTITY,
    FirstName varchar(255) NOT NULL,
    LastName varchar(255) NOT NULL,
    Email varchar(255) NOT NULL,
    Password varchar(255) NOT NULL,
    CONSTRAINT PK_Users PRIMARY KEY (UserId)
);
CREATE TABLE Customer(
    CustomerId int NOT NULL IDENTITY,
    UserId int NOT NULL,
    CompanyName varchar(255) NOT NULL,
    CONSTRAINT PK_Customers PRIMARY KEY (CustomerId),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
CREATE TABLE Rental(
    RentalId int NOT NULL IDENTITY,
    CarId int NOT NULL,
    CustomerId int NOT NULL,
    RentDate datetime NOT NULL,
    ReturnDate datetime DEFAULT NULL,
    CONSTRAINT Pk_Rental PRIMARY KEY (RentalId),
    FOREIGN KEY (CarId) REFERENCES Car(CarId),
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId)

);