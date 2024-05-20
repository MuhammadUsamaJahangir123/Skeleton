CREATE PROCEDURE sproc_tbStaff_Insert
	
	--create the parameters for the stored procedure
	@FirstName varchar(50),
	@LastName varchar (50),
	@JoinedDate date,
	@Availability bit,
	@Email varchar(50),
	@PhoneNo varchar(50)



AS
	--insert the new record
	INSERT INTO tbStaff (FirstName, LastName, JoinedDate, Availability, Email, PhoneNo)
	values (@FirstName, @LastName, @JoinedDate, @Availability, @Email, @PhoneNo)

	--return the new record
RETURN @@Identity
