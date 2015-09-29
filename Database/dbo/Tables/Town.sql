CREATE TABLE [dbo].[Town]
(
	[Zipcode] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [Region_Id] INT NOT NULL, 
    [Name] VARCHAR(25) NOT NULL, 
    [Image_Url] VARCHAR(100) NULL, 
    CONSTRAINT [FK_Town_Region] FOREIGN KEY ([Region_Id]) REFERENCES [Region]([Region_Id])
)
