CREATE TABLE [dbo].[Friends]
(
	[Friend_Username] VARCHAR(25) NOT NULL , 
    [Friended_Username] VARCHAR(25) NOT NULL, 
    [Category_Id] INT NOT NULL, 
    [Accepted_Date] DATETIME NULL, 
    CONSTRAINT [FK_Friends_Username] FOREIGN KEY ([Friend_Username]) REFERENCES [Users]([Username]),
	CONSTRAINT [FK_Friends_Friended] FOREIGN KEY ([Friended_Username]) REFERENCES [Users]([Username]),
	CONSTRAINT [FK_Friends_Category] FOREIGN KEY ([Category_Id]) REFERENCES [Category]([Category_Id])
)
