CREATE PROCEDURE Insert_User
    @Email NVARCHAR(255),
    @Password NVARCHAR(255),
    @Role NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Users (Email, Password, Role)
    VALUES (@Email, @Password, @Role);
END