CREATE TABLE [dbo].[Product] (
    [ProductId]   INT           IDENTITY (1, 1) NOT NULL,
    [ProductName] VARCHAR (255) NOT NULL,
    [Description] VARCHAR(255) NOT NULL, 
    [UnitPrice] FLOAT NOT NULL, 
    [CategoryID] INT NOT NULL, 
    [SubCategoryID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

