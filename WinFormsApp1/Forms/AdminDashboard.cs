using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class AdminDashboard : Form
    {
        AdminController _adminController;
        AuthController _authController;
        public AdminDashboard(AdminController adminController)
        {
            InitializeComponent();
            _adminController = adminController;
            SetupDataGrid();
            dataGrid.DefaultCellStyle.ForeColor = Color.Black;
            dataGrid.CellClick += DataGrid_CellClick;
        }

        private void SetupDataGrid()
        {
            dataGrid.Columns.Clear();
            dataGrid.AutoGenerateColumns = false;
            var snoCol = new DataGridViewTextBoxColumn();
            snoCol.HeaderText = "Id";
            snoCol.DataPropertyName = "Id";
            snoCol.Width = 50;
            snoCol.ReadOnly = true;
            dataGrid.Columns.Add(snoCol);

            var emailCol = new DataGridViewTextBoxColumn();
            emailCol.HeaderText = "Email";
            emailCol.DataPropertyName = "Email";
            emailCol.Width = 300;
            emailCol.ReadOnly = true;
            dataGrid.Columns.Add(emailCol);

            var createdCol = new DataGridViewTextBoxColumn();
            createdCol.HeaderText = "Created On";
            createdCol.DataPropertyName = "CreatedOn";
            createdCol.Width = 300;
            createdCol.ReadOnly = true;
            dataGrid.Columns.Add(createdCol);

            var showCol = new DataGridViewButtonColumn();
            showCol.HeaderText = "Action";
            showCol.Text = "Show Tasks";
            showCol.UseColumnTextForButtonValue = true;
            showCol.Width = 75;
            dataGrid.Columns.Add(showCol);


            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToResizeColumns = true;
        }
        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    int totalUsers = _adminController.CountAllusers();
        //    lblUsers.Text = totalUsers.ToString();
        //    List<UserInfo> userList = _adminController.GetAllUsers();
        //    dataGrid.DataSource = userList;
        //}
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex < 0) return;
                if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Action")
                {
                    var selectedTask = dataGrid.Rows[e.RowIndex].DataBoundItem as UserInfo;
                    if (selectedTask != null)
                    {
                        BindingList<TaskItem> allTasks = _adminController.GetAllTasksbyId(selectedTask.Id);
                        TasksDashboard form = new TasksDashboard(allTasks, _adminController, selectedTask.Id);
                        form.Show();
                        return;
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AdminDashboard_Load(object sender, EventArgs e)
        {
            int totalUsers = _adminController.CountAllusers();
            lblUsers.Text = totalUsers.ToString();
            List<UserInfo> userList = await _adminController.GetAllUsers();
            dataGrid.DataSource = userList;
        }
    }
}
