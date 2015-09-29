CREATE TABLE [dbo].[Group_User]
(
	[Username] VARCHAR(25) NOT NULL, 
    [Group_Id] INT NOT NULL, 
    [Join_Date] DATETIME NOT NULL, 
    [Deletion_Date] DATETIME NULL, 
    CONSTRAINT [FK_Group_User_Username] FOREIGN KEY ([Username]) REFERENCES [Users]([Username]),
	CONSTRAINT [FK_Group_User_Group] FOREIGN KEY ([Group_Id]) REFERENCES [Groups]([Groups_Id]) 
)
