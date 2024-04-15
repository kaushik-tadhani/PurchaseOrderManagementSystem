CREATE TABLE [dbo].[Product] (
    [ProductId]     INT           IDENTITY (1, 1) NOT NULL,
    [ProductName]   VARCHAR (255) NOT NULL,
    [ProductDescription]   VARCHAR (255) NULL,
    [ProductUnitPrice]     FLOAT (53)    NULL,
    [ProductCategoryID]    INT           NOT NULL,
    [ProductSubCategoryID] INT           NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC), 
    CONSTRAINT [FK_Product_ToTable] FOREIGN KEY (ProductCategoryID) REFERENCES ProductCategory(ProductCategoryID)
);

