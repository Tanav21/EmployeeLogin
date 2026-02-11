using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class EditTaskForm : Form
    {
        TaskItem task;
        public EditTaskForm(TaskItem item)
        {
            InitializeComponent();
            task = item;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            inputTask.TextValue = "";
            inputTask.TextValue = task.Description;
            checkIsCompleted.Checked = task.IsCompleted;
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            task.Description = inputTask.TextValue.Trim();
            task.IsCompleted = checkIsCompleted.Checked;
            task.UpdatedOn = DateTime.Now;
            using (SqlConnection conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                string query = @"Update tasks set description = @Desc,isCompleted = @isCompleted, updatedOn = @updatedOn where taskId = @taskId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Desc", task.Description);
                    cmd.Parameters.AddWithValue("@taskId", task.TaskId);
                    cmd.Parameters.AddWithValue("@isCompleted", task.IsCompleted);
                    cmd.Parameters.AddWithValue("@updatedOn", DateTime.Now);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        MessageBox.Show("No rows were updated. Check TaskId value.");
                    }
                    else
                    {
                        MessageBox.Show("Task updated successfully!");
                    }
                }
            }
            this.Close();
        }
    }
}
