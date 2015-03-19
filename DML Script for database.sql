USE LightPoint
DECLARE @offset INT = 1,
@Shop NVARCHAR(100),
@Address NVARCHAR(200),
@StartTime Time = '9:00:00',
@EndTime Time = '20:00:00',
@GoodsName NVARCHAR(100),
@GoodsDescription NVARCHAR(100);


WHILE (@offset < 10)
BEGIN
	SET @Shop = 'AnyShop' + CONVERT(NVARCHAR, @offset);
	SET @Address = 'AnyAddress' + CONVERT(NVARCHAR, @offset);
	
	INSERT
	INTO dbo.Shop (Name, Address, WorkStartTime, WorkEndTime)
	VALUES (@Shop, @Address, @StartTime, @EndTime)
	SET @offset = @offset + 1;
END
GO

DECLARE @offset INT = 1,
@GoodsName NVARCHAR(100),
@GoodsDescription NVARCHAR(100),
@ShopId INT;

WHILE (@offset < 100)
BEGIN
	SET @GoodsName = 'Cookie' + CONVERT(NVARCHAR, @offset);
	SET @GoodsDescription =  'SomeDescription' + CONVERT(NVARCHAR, @offset);
	SET @ShopId = ROUND((RAND()* 9),0);

	INSERT
	INTO dbo.Goods (Name, ShopId, Description)
	VALUES (@GoodsName, @ShopId, @GoodsDescription)
	SET @offset = @offset + 1;
END
GO


--TRUNCATE TABLE dbo.Shop
--TRUNCATE TABLE dbo.Goods
--SELECT * FROM dbo.Shop
--SELECT * FROM dbo.Goods