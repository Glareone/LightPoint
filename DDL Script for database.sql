
IF (NOT EXISTS (SELECT name 
					FROM master.dbo.sysdatabases 
					WHERE ('[' + name + ']' = 'LightPoint'
					OR name = 'LightPoint')))
BEGIN
	CREATE DATABASE LightPoint
	PRINT 'LightPoint Database Created';
END
GO

USE LightPoint
IF (NOT EXISTS (SELECT * 
					FROM INFORMATION_SCHEMA.TABLES
					WHERE TABLE_SCHEMA = 'dbo' 
					AND  TABLE_NAME = 'Shop'))
BEGIN
	CREATE TABLE dbo.Shop
	(
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Name NVARCHAR(100) NOT NULL,
		Address NVARCHAR(200) NOT NULL,
		WorkStartTime Time NOT NULL,
		WorkEndTime Time NOT NULL
	)	
	PRINT 'Table Shop Created'; 
END
ELSE
BEGIN
	TRUNCATE TABLE dbo.Shop
	PRINT 'Table Shop Truncated';
END
GO

IF (NOT EXISTS (SELECT * 
					FROM INFORMATION_SCHEMA.TABLES
					WHERE TABLE_SCHEMA = 'dbo' 
					AND  TABLE_NAME = 'Goods'))
BEGIN
	CREATE TABLE dbo.Goods
	(
		Id INT IDENTITY(1,1) PRIMARY KEY,
		ShopId INT FOREIGN KEY REFERENCES dbo.Shop(Id),
		Name NVARCHAR(100) NOT NULL,
		Description NVARCHAR(100)
	)
	PRINT 'Table Goods Created'; 
END
ELSE
BEGIN
	TRUNCATE TABLE dbo.Goods
	PRINT 'Table Goods Truncated';
END
GO

-- DROP TABLE dbo.Goods