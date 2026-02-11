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
    public partial class TasksDashboard : Form
    {
        BindingList<TaskItem> tasks;
        AdminController _adminController;
        int _Id;
        public TasksDashboard(BindingList<TaskItem> Tasks, AdminController adminController, int id)
        {
            InitializeComponent();
            tasks = Tasks;
            _adminController = adminController;
            _Id = id;
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


        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tasks;
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["TaskId"].Visible = false;
            dataGridView1.RowPostPaint += dataGrid_RowPostPaint;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            int totalTasks = _adminController.FindAllTasks(_Id);
            lblTotal.Text = totalTasks.ToString();
            int completedTasks = _adminController.FindCompletedTasks(_Id);
            lblComplete.Text = completedTasks.ToString();
            lblIncomplete.Text = (totalTasks - completedTasks).ToString();
            var filters = new List<string> { "All Tasks", "Completed Tasks", "Incomplete Tasks" };
            comboBoxFilter.DataSource = filters;

            comboBoxFilter.SelectedIndex = 0;

            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tasks;
        }

        private void btnIncomplete_Click(object sender, EventArgs e)
        {
            BindingList<TaskItem> list = _adminController.GetIncompleteTasks(_Id);
            dataGridView1.DataSource = list;
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            BindingList<TaskItem> list = _adminController.GetCompletedTasks(_Id);
            dataGridView1.DataSource = list;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFilter.SelectedItem.ToString())
            {
                case "All Tasks":
                    dataGridView1.DataSource = tasks;
                    break;

                case "Completed Tasks":
                    dataGridView1.DataSource = _adminController.GetCompletedTasks(_Id);
                    break;

                case "Incomplete Tasks":
                    dataGridView1.DataSource = _adminController.GetIncompleteTasks(_Id);
                    break;
            }
        }
    }
}
