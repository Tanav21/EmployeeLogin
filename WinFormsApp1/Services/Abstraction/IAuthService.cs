using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Models;
using WinFormsApp1.utils;

namespace TestAssignment.Services.Interfaces
{
    public interface IAuthService
    {
        public UserInfo Login(string email,string password);
        public bool SignUp(string email, string password, UserRole role);
        public bool ResetPassword(string email, string oldPassword, string newPassword);
    }
}
