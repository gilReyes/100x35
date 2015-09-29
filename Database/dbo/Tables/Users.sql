CREATE TABLE [dbo].[Users](
	[Username] [varchar](25) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[Total_Places] [int] NOT NULL,
	[Ranking] [decimal](2, 2) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [varchar](14) NULL,
	[Description] [varchar](255) NULL,
	[Birth_Date] [datetime] NOT NULL,
	[Create_Date] [datetime] NOT NULL,
	[Deletion_Date] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)