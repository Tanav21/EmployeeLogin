using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using WinFormsApp1.utils;

namespace WinFormsApp1
{
    public partial class ResetForm : Form
    {
        public ResetForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = inputEmail.TextValue;
            string oldPassword = inputOldPassword.TextValue;
            string newPassword = inputNewPass.TextValue;

            if (newPassword.Length < 6)
            {
                MessageBox.Show("New password length must be greater than 5");
                return;
            }

            using (SqlConnection conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                string selectQuery = "SELECT password FROM users WHERE email = @email";
                string hashedPassword;

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("No email exists");
                        return;
                    }

                    hashedPassword = result.ToString();
                }

                if (!PasswordHasher.VerifyPassword(oldPassword, hashedPassword))
                {
                    MessageBox.Show("Old password is incorrect");
                    return;
                }

                string newHashedPassword = PasswordHasher.HashPassword(newPassword);

                string updateQuery = "UPDATE users SET password = @newHashed WHERE email = @email";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@newHashed", newHashedPassword);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Password updated successfully");
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picOpen1_Click(object sender, EventArgs e)
        {
            inputOldPassword.showPass();
            picOpen1.Visible = false;
            picHide1.Visible = true;
        }
        private void picOpen2_Click(object sender, EventArgs e)
        {
            inputNewPass.showPass();
            picOpen2.Visible = false;
            picHide2.Visible = true;
        }
        private void picHide1_Click(object sender, EventArgs e)
        {
            inputOldPassword.hidePass();
            picHide1.Visible = false;
            picOpen1.Visible = true;
        }
        private void picHide2_Click(object sender, EventArgs e)
        {
            inputNewPass.hidePass();
            picHide2.Visible = false;
            picOpen2.Visible = true;
        }

        private void ResetForm_Load(object sender, EventArgs e)
        {
            picHide1.Visible = false;
            picHide2.Visible = false;
        }
    }
}