USE ems_db;
GO

CREATE PROCEDURE Auth_Login
    @Email NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Email, refRole, Password
    FROM Users
    WHERE Email = @Email;
END
GO