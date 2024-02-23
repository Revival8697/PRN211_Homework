CREATE DATABASE MyStock;

USE MyStock;

CREATE TABLE Cars (
    CarID int PRIMARY KEY NOT NULL,
    CarName varchar(50) NOT NULL,
    Manufacturer varchar(50) NOT NULL,
    Price money NOT NULL,
    ReleasedYear int NOT NULL
);

INSERT INTO Cars (CarID, CarName, Manufacturer, Price, ReleasedYear) VALUES
(1, 'Accord', 'Honda Motor Company', 24970.0000, 2021),
(3, 'Clarity', 'Honda Motor Company', 33400.000, 2021),
(4, 'BMW 8 Series', 'BMW', 85000.0000, 2021),
(5, 'Audi A6', 'Audi', 14000.0000, 2020);