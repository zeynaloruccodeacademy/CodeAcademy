CREATE DATABASE Market

USE Market

CREATE TABLE Products
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(30) NOT NULL,
	Price INT
)

CREATE TABLE Brand
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(30)
)

ALTER TABLE Products
ADD BrandId INT CONSTRAINT FK_PRODUCT_BRAND FOREIGN KEY (BrandId) REFERENCES Brand(Id)

INSERT Brand
VALUES 
('Apple'),
('Samsung'),
('Sony')

INSERT Products
VALUES
('Iphone SE', 499, 1 ),
('Iphone 13', 1299, 1 ),
('Iwatch', 799, 1 ),
('Macbook AIR', 1499, 1 ),
('Macbook Pro', 2229, 1 ),
('Ipad', 899, 1 ),
('TV', 3999, 2 ),
('Notebook', 999, 2 ),
('SSD', 399, 2 ),
('Galaxy', 1899, 2 ),
('Playstation 5', 999, 3 ),
('PSP Vita', 299, 3 ),
('Bravia', 5499, 3 )

SELECT AVG(Price) FROM Products
SELECT * FROM Products WHERE Price < (SELECT AVG(Price) FROM Products)
SELECT * FROM Brand WHERE LEN(Name) > 5
