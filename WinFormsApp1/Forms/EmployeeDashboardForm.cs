using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class EmployeeDashboardForm : Form
    {
        private readonly TaskController _taskController;
        private readonly UserInfo _currentUser;
        private TaskItem _currentlyEditingTask = null;
        private BindingList<TaskItem> _taskBindingList;
        TaskService _taskService;

        public EmployeeDashboardForm(UserInfo user, TaskController taskController,TaskService taskService)
        {
            InitializeComponent();
            _currentUser = user;
            _taskController = taskController;
            SetupDataGrid();
            _taskService = taskService;
        }
        private void SetupDataGrid()
        {
            dataGrid.Columns.Clear();
            dataGrid.AutoGenerateColumns = false; // we define columns manually

            // 2️⃣ Task Description column
            var descCol = new DataGridViewTextBoxColumn();
            descCol.HeaderText = "Task";
            descCol.DataPropertyName = "Description";
            descCol.Width = 300;
            descCol.ReadOnly = true;
            dataGrid.Columns.Add(descCol);

            var createdCol = new DataGridViewTextBoxColumn();
            createdCol.HeaderText = "CreatedOn";
            createdCol.DataPropertyName = "CreatedOn";
            createdCol.Width = 300;
            createdCol.ReadOnly = true;
            dataGrid.Columns.Add(createdCol);

            var updatedCol = new DataGridViewTextBoxColumn();
            updatedCol.HeaderText = "UpdatedOn";
            updatedCol.DataPropertyName = "UpdatedOn";
            updatedCol.Width = 300;
            updatedCol.ReadOnly = true;
            dataGrid.Columns.Add(updatedCol);

            // 3️⃣ Completed column (checkbox)
            var completedCol = new DataGridViewCheckBoxColumn();
            completedCol.HeaderText = "Completed";
            completedCol.DataPropertyName = "IsCompleted";
            completedCol.Width = 100;         // default width
            dataGrid.Columns.Add(completedCol);

            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToResizeColumns = true;
        }

        private void dataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Draw row number in the row header
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString();
            using (var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                e.Graphics.DrawString(rowNumber, grid.Font, SystemBrushes.ControlText,
                    grid.GetRowDisplayRectangle(e.RowIndex, true).Location.X + 20,
                    grid.GetRowDisplayRectangle(e.RowIndex, true).Location.Y + grid.Rows[e.RowIndex].Height / 2,
                    centerFormat);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = loginTextBox1.TextValue.Trim();
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Task field cannot be empty");
                return;
            }

            if (btnAdd.Text == "Add")
            {
                TaskItem newTask = _taskController.AddTask(_currentUser.Id, description);
                _taskBindingList.Add(newTask);
                dataGrid.Refresh();
                loginTextBox1.Clear();
            }
            else if (btnAdd.Text == "Save")
            {
                if (_currentlyEditingTask != null)
                {
                    _currentlyEditingTask.Description = description;
                    dataGrid.Refresh();
                    MessageBox.Show("Task updated successfully!");
                    btnAdd.Text = "Add";
                    loginTextBox1.Clear();
                    _currentlyEditingTask = null;
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            _taskBindingList = _taskController.ShowTasks(_currentUser.Id);
            dataGrid.DataSource = _taskBindingList;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dataGrid.CellClick += DataGrid_CellClick;
            dataGrid.RowPostPaint += dataGrid_RowPostPaint;

            if(btnEdit.Enabled == false)
            {
                btnEdit.ForeColor = Color.White;
            }
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                _currentlyEditingTask = null;
                return;
            }
            TaskItem selectedTask =
                dataGrid.Rows[e.RowIndex].DataBoundItem as TaskItem;

            if (selectedTask == null)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                _currentlyEditingTask = null;
                return;
            }
            _currentlyEditingTask = selectedTask;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTaskForm form = new EditTaskForm(_currentlyEditingTask,_taskService);
            form.ShowDialog();
            dataGrid.Refresh();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                 $"Are you sure you want to delete '{_currentlyEditingTask.Description}'?",
                 "Confirm Delete",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                _taskBindingList.Remove(_currentlyEditingTask);
                if (_taskController.DeleteTask(_currentlyEditingTask.TaskId))
                {
                    MessageBox.Show("Task deleted successfully!");
                }
            }
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            return;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            loginTextBox1.TextValue = "";
            btnAdd.Text = "Add";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
