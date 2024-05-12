USE [p2653673]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tbStaff_FilterByStaffID]
		@StaffID = 1

SELECT	@return_value as 'Return Value'

GO
