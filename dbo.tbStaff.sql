CREATE TABLE [dbo].[tbStaff] (
    [StaffID]      INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NULL,
    [LastName]     VARCHAR (50) NULL,
    [JoinedDate]   DATE         NULL,
    [Availability] BIT          NULL,
    [Email]        VARCHAR (50) NULL,
    [PhoneNo]      VARCHAR (50) NULL,
    CONSTRAINT [PK_tbStaff] PRIMARY KEY CLUSTERED ([StaffID] ASC)
);

