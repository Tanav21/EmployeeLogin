using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.utils;

namespace WinFormsApp1.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool isLoggedIn { get; set; }
    }
}
