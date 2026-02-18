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
        private readonly TaskService _taskService;

        public EditTaskForm(TaskItem item, TaskService taskService)
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
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            task.Description = inputTask.TextValue.Trim();
            task.IsCompleted = checkIsCompleted.Checked;
            task.UpdatedOn = DateTime.Now;
           _taskService.UpdateTask(task);
            this.Close();
        }
    }
}
