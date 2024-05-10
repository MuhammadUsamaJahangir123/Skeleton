USE [p2653673]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tbCustomer_FilterByCustomerID]
		@CustomerID = 1

SELECT	@return_value as 'Return Value'

GO
