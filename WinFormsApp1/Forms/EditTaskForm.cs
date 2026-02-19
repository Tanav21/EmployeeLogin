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
using TestAssignment.Services.Interfaces;

namespace WinFormsApp1
{
    public partial class EditTaskForm : Form
    {
        TaskItem task;
        private readonly ITaskService _taskService;
        public EditTaskForm(TaskItem item, ITaskService taskService)
        {
            InitializeComponent();
            task = item;
            _taskService = taskService;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            inputTask.TextValue = "";
            inputTask.TextValue = task.Description;
            checkIsCompleted.Checked = task.IsCompleted;
            label1.Text = $"Old Description : {task.Description}";

        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (inputTask.TextValue.Trim() == "")
            {
                MessageBox.Show("Task description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (inputTask.TextValue.Trim().Length > 60)
            {
                MessageBox.Show("Task description cannot exceed 60 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            task.Description = inputTask.TextValue.Trim();
            task.IsCompleted = checkIsCompleted.Checked;
            task.UpdatedOn = DateTime.Now;
            _taskService.UpdateTask(task);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
