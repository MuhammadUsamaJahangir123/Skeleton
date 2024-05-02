USE [p2653673]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tbStaff_SelectAll]

SELECT	@return_value as 'Return Value'

GO
