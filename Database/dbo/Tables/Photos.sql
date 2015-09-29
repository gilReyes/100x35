CREATE TABLE [dbo].[Photos]
(
	[Photos_Id] INT NOT NULL PRIMARY KEY, 
    [Visit_Id] INT NOT NULL, 
    [Image_Url] VARCHAR(100) NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(255) NULL, 
    [Like] INT NOT NULL, 
    [Dislike] INT NOT NULL, 
    [Report] INT NOT NULL, 
    [Popularity] DECIMAL(4, 2) NOT NULL, 
    [Privacy_Type_Id] INT NULL, 
    [Deletion_Date] DATETIME NULL, 
    CONSTRAINT [FK_Photos_Visit] FOREIGN KEY ([Visit_Id]) REFERENCES [Visits]([Visit_Id]),
	CONSTRAINT [FK_Photos_Privacy_Type] FOREIGN KEY ([Privacy_Type_Id]) REFERENCES [Privacy_Type]([Privacy_Type_Id])
)
