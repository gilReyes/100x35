CREATE TABLE [dbo].[User]
	(
	Username varchar(25) NOT NULL,
	Password varchar(25) NOT NULL,
	Total_Places int NOT NULL,
	Ranking decimal(2, 2) NOT NULL,
	Email varchar(50) NOT NULL,
	Phone varchar(14) NULL,
	Description varchar(255) NULL,
	Birth_Date datetime NOT NULL,
	Create_Date datetime NOT NULL,
	Deletion_Date datetime NULL
	)  ON [PRIMARY]
GO
