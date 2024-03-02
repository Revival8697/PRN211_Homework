CREATE DATABASE PRN211_ASM_02
DROP DATABASE PRN211_ASM_02
USE PRN211_ASM_02

CREATE TABLE Member (
    MemberId INT PRIMARY KEY NOT NULL,
    Email VARCHAR(100) NOT NULL,
    CompanyName VARCHAR(40) NOT NULL,
    City VARCHAR(15) NOT NULL,
    Country VARCHAR(15) NOT NULL,
    Password VARCHAR(30) NOT NULL
);

CREATE TABLE [Order] (
    OrderId INT PRIMARY KEY NOT NULL,
    MemberId INT NOT NULL,
    OrderDate DATETIME NOT NULL,
    RequiredDate DATETIME,
    ShippedDate DATETIME,
    Freight MONEY,
    FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
);

CREATE TABLE Product (
    ProductId INT PRIMARY KEY NOT NULL,
    CategoryId INT NOT NULL,
    ProductName VARCHAR(40) NOT NULL,
    Weight VARCHAR(20) NOT NULL,
    UnitPrice MONEY NOT NULL,
    UnitsInStock INT NOT NULL
);

CREATE TABLE OrderDetail (
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    UnitPrice MONEY NOT NULL,
    Quantity INT NOT NULL,
    Discount FLOAT NOT NULL,
    PRIMARY KEY (OrderId, ProductId),
    FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);
