using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using WinFormsApp1.utils;
namespace WinFormsApp1.Controller
{
    public class AuthController
    {

        public UserInfo Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) return null;
            try
            { 
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Auth_Login", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader.GetString(reader.GetOrdinal("Password"));
                                if (!PasswordHasher.VerifyPassword(password, hashedPassword))
                                    return null;

                                return new UserInfo
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Role = (UserRole)reader.GetInt32(reader.GetOrdinal("refRole"))
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public bool SignUp(string email, string password, UserRole role)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) return false;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password length must be greater than 5");
                return false;
            }
            string hashPassword = PasswordHasher.HashPassword(password);
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();
                    using (SqlCommand cd = new SqlCommand("Check_Email", conn))
                    {
                        cd.CommandType = CommandType.StoredProcedure;
                        cd.Parameters.AddWithValue("@email", email);
                        int count = (int)cd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Email already exists!");
                            return false;
                        }
                    }
                    string query = @"Insert into users (Email, Password,refRole) values (@email,@password,@role)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", hashPassword);
                        cmd.Parameters.AddWithValue("@role", (int)role);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
