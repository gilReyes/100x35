CREATE TABLE [dbo].[Event_User]
(
	[Event_Id] INT NOT NULL, 
    [Username] VARCHAR(25) NOT NULL, 
    [Attending] BIT NOT NULL, 
    CONSTRAINT [FK_Event_User_Username] FOREIGN KEY ([Username]) REFERENCES [Users]([Username]),
	CONSTRAINT [FK_Event_User_Event] FOREIGN KEY ([Event_Id]) REFERENCES [Events]([Event_Id]) 
)
