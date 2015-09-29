CREATE TABLE [dbo].[Visits]
(
	[Username] VARCHAR(25) NOT NULL, 
    [Location_Id] INT NOT NULL, 
    [Visit_Date] DATETIME NOT NULL, 
    [Favorite] BIT NOT NULL, 
    [Deletion_Date] DATETIME NULL, 
    [Visit_Id] INT NOT NULL, 
    CONSTRAINT [FK_Visits_Username] FOREIGN KEY ([Username]) REFERENCES [Users]([Username]),
	CONSTRAINT [FK_Visits_Location] FOREIGN KEY ([Location_Id]) REFERENCES [Location]([Location_Id]), 
    CONSTRAINT [PK_Visits] PRIMARY KEY ([Visit_Id])
)
