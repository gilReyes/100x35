﻿-- =============================================
-- Author:		<Stephan Elias>
-- Create date: <Create Date,,>
-- Description:	<Test Procedure>
-- =============================================
CREATE PROCEDURE [dbo].[Test_SP] 
	@ID int
AS
BEGIN
	SELECT *
	FROM Test T
	WHERE @ID = T.ID
END