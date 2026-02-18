using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;
using WinFormsApp1.utils;

namespace WinFormsApp1.Controller
{
    public class AuthController
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        public UserInfo Login(string email, string password)
        {
            try
            {
                return _authService.Login(email, password);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool SignUp(string email, string password, UserRole role)
        {
            try
            {
                return _authService.SignUp(email, password, role);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ResetPassword(string email, string oldPassword, string newPassword)
        {
            try
            {
                return _authService.ResetPassword(email, oldPassword, newPassword);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
