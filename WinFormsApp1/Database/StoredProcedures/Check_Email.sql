CREATE PROCEDURE Check_Email
    @Email NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM Users 
    WHERE Email = @Email;
END
