CREATE TABLE Cars
(
	CarId INT PRIMARY KEY IDENTITY(1,1),
	BrandId INT,
	ColorId INT,
	ModelYear INT,
	DailyPrice DECIMAL,
	Descriptions NVARCHAR(25),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
)

CREATE TABLE Colors
(
	ColorId INT PRIMARY KEY IDENTITY(1,1),
	ColorName NVARCHAR(25),
)

CREATE TABLE Brands
(
	BrandId INT PRIMARY KEY IDENTITY(1,1),
	BrandName NVARCHAR(25),
)

INSERT INTO Colors (ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Yeşil');

INSERT INTO Brands (BrandName)
VALUES
	('BMW'),
	('Toyota'),
	('Renault');

INSERT INTO Cars (BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2015','100','Otomatik Dizel'),
	('1','3','2012','200','Manuel Dizel'),
	('2','3','2017','225','Manuel Dizel'),
	('2','1','2018','150','Manel Benzin'),
	('3','2','2013','250','Otomatik Dizel');

	
	
	

	