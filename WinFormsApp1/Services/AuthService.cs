using Dapper;
using System.Data;
using System.Text.RegularExpressions;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using WinFormsApp1.utils;

public class AuthService
{
    private readonly IDbConnectionFactory _dbFactory;

    public AuthService(IDbConnectionFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public UserInfo Login(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            return null;

        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = "Auth_Login";

        var user = conn.QueryFirstOrDefault<dynamic>(
            query,
            new { Email = email },
            commandType: CommandType.StoredProcedure
        );

        if (user == null) return null;

        string hashedPassword = user.Password;

        if (!PasswordHasher.VerifyPassword(password, hashedPassword))
            return null;

        return new UserInfo
        {
            Id = user.Id,
            Email = user.Email,
            Role = (UserRole)user.refRole
        };
    }

    public bool SignUp(string email, string password, UserRole role)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            return false;

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (!Regex.IsMatch(email, emailPattern))
            throw new Exception("Invalid email format");

        if (password.Length < 6)
            throw new Exception("Password length must be greater than 5");

        string hashPassword = PasswordHasher.HashPassword(password);

        using IDbConnection conn = _dbFactory.CreateConnection();

        // check email exists
        int count = conn.ExecuteScalar<int>(
            "Check_Email",
            new { email = email },
            commandType: CommandType.StoredProcedure
        );

        if (count > 0)
            throw new Exception("Email already exists!");

        string query = @"INSERT INTO Users (Email, Password, RefRole)
                         VALUES (@Email, @Password, @Role)";

        int rows = conn.Execute(query, new
        {
            Email = email,
            Password = hashPassword,
            Role = (int)role
        });

        return rows > 0;
    }

    public bool ResetPassword(string email, string oldPassword, string newPassword)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string selectQuery = @"SELECT Password FROM Users WHERE Email = @Email";

        string hashedPassword = conn.ExecuteScalar<string>(selectQuery, new { Email = email });

        if (hashedPassword == null)
            throw new Exception("No email exists");

        if (!PasswordHasher.VerifyPassword(oldPassword, hashedPassword))
            throw new Exception("Old password is incorrect");

        string newHashedPassword = PasswordHasher.HashPassword(newPassword);

        string updateQuery = @"UPDATE Users 
                               SET Password = @NewPassword 
                               WHERE Email = @Email";

        conn.Execute(updateQuery, new
        {
            NewPassword = newHashedPassword,
            Email = email
        });

        return true;
    }
}
