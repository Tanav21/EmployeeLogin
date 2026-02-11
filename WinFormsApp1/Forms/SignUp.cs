using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.utils;

namespace WinFormsApp1
{
    public partial class SignUp : Form
    {
        private AuthController _authController;
        public SignUp(AuthController authcontroller)
        {
            InitializeComponent();
            _authController = authcontroller;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string email = inputEmail.TextValue.Trim();
            string password = inputPassword.TextValue;
            UserRole role = 0;

            if (radioAdmin.Checked)
            {
                role = UserRole.Admin;
            }
            else if (radioEmployee.Checked)
            {
                role = UserRole.Employee;
            }
            else
            {
                MessageBox.Show("Please select a Role");
                return;
            }
            bool validate = _authController.SignUp(email, password, role);
            if (validate)
            {
                MessageBox.Show("User Created Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sign Up Failed");
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picOpen_Click(object sender, EventArgs e)
        {
            inputPassword.showPass();
            picOpen.Visible = false;
            picHide.Visible = true;
        }
        private void picHide_Click(object sender, EventArgs e)
        {
            inputPassword.hidePass();
            picHide.Visible = false;
            picOpen.Visible = true;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            picHide.Visible = false;
        }
    }
}
