CREATE TABLE [dbo].[Message](
	[Message_Id] [int] NOT NULL,
	[Subject] [varchar](50) NOT NULL,
	[Message] [varchar](1000) NOT NULL,
	[Sent_Date] [datetime] NOT NULL,
	[Read_Date] [datetime] NULL,
	[Deletion_Date] [datetime] NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[Message_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)