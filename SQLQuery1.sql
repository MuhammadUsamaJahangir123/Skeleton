USE [p2653673]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblUsers_FindUserNamePW]
		@UserName = N'Kushal',
		@Password = N'GoodbyeWorld'

SELECT	@return_value as 'Return Value'

GO
