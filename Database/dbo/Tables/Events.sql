CREATE TABLE [dbo].[Events]
(
	[Event_Id] INT NOT NULL PRIMARY KEY, 
    [Location_Id] INT NOT NULL, 
    [Category_Id] INT NOT NULL, 
    [Created_By] VARCHAR(25) NOT NULL, 
    [Privacy_Type_Id] INT NOT NULL, 
    [Creation_Date] DATETIME NOT NULL, 
    [Start_Date] DATETIME NOT NULL, 
    [End_Date] DATETIME NOT NULL, 
    [Image_Url] VARCHAR(100) NULL, 
    [Description] VARCHAR(255) NULL, 
    [Deletion_Date] DATETIME NULL, 
    [Name] VARCHAR(50) NULL, 
    CONSTRAINT [FK_Events_Location] FOREIGN KEY ([Location_Id]) REFERENCES [Location]([Location_Id]),
	CONSTRAINT [FK_Events_Category] FOREIGN KEY ([Category_Id]) REFERENCES [Category]([Category_Id]),
	CONSTRAINT [FK_Events_Created_By] FOREIGN KEY ([Created_By]) REFERENCES [Users]([Username]), 
    CONSTRAINT [FK_Events_Privacy_Type_Id] FOREIGN KEY ([Privacy_Type_Id]) REFERENCES [Privacy_Type]([Privacy_Type_Id])
)
