CREATE PROCEDURE [sproc_tbStaff_FilterByStaffID]
	--parameter to store the staff id we are looking for
	@StaffID int
AS
	--select all fields from the table where the staff id matches the parameter data
	SELECT * FROM tbStaff WHERE StaffID = @StaffID

RETURN 0