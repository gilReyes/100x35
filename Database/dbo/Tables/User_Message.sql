CREATE TABLE [dbo].[User_Message]
(
	[Sender] VARCHAR(25) NOT NULL , 
    [Reciever] VARCHAR(25) NOT NULL, 
    [Message_Id] INT NOT NULL, 
    CONSTRAINT [FK_Sender_Message] FOREIGN KEY ([Sender]) REFERENCES [Users]([Username]), 
    CONSTRAINT [FK_Reciever_Message] FOREIGN KEY ([Reciever]) REFERENCES [Users]([Username]), 
    CONSTRAINT [FK_Message_Message] FOREIGN KEY ([Message_Id]) REFERENCES [Message]([Message_Id]) 
)
