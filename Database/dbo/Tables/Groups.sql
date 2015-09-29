CREATE TABLE [dbo].[Groups]
(
	[Groups_Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(25) NOT NULL, 
    [Category_Id] INT NOT NULL, 
    [Created_Date] DATETIME NOT NULL, 
    [Created_By] VARCHAR(25) NOT NULL, 
    [Deletion_Date] DATETIME NULL, 
    CONSTRAINT [FK_Groups_Category] FOREIGN KEY ([Category_Id]) REFERENCES [Category]([Category_Id]),
	CONSTRAINT [FK_Groups_Created_By] FOREIGN KEY ([Created_By]) REFERENCES [Users]([Username])
)
