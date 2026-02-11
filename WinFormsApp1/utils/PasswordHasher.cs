using BCrypt.Net;

namespace WinFormsApp1.utils
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool VerifyPassword(string storedPassword, string inputPassword)
        {
            return BCrypt.Net.BCrypt.Verify(storedPassword, inputPassword);
        }
    }
}