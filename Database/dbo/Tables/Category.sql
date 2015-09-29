CREATE TABLE [dbo].[Category]
(
	[Category_Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(25) NOT NULL, 
    [Category_Type_Id] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Category_Category_Type] FOREIGN KEY ([Category_Type_Id]) REFERENCES [Category_Type]([Category_Type_Id])
)
