CREATE TABLE [dbo].[Location]
(
	[Location_Id] INT NOT NULL PRIMARY KEY, 
    [Longitude] NUMERIC(8, 5) NOT NULL, 
    [Lattitude] NUMERIC(8, 5) NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(255) NULL, 
    [Type_Id] INT NOT NULL, 
    [Creation_Date] DATETIME NOT NULL, 
    [Likes] INT NOT NULL, 
    [Dislikes] INT NOT NULL, 
    [Popularity] DECIMAL(4, 2) NOT NULL, 
    [Approved] BIT NOT NULL, 
    [Zipcode] VARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Location_Type] FOREIGN KEY ([Type_Id]) REFERENCES [Type]([Type_Id]),
	CONSTRAINT [FK_Location_Zipcode] FOREIGN KEY ([Zipcode]) REFERENCES [Town]([Zipcode])
)
