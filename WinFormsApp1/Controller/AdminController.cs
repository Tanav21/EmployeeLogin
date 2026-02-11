using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Text;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controller
{
    public class AdminController
    {
        AuthController _authController = new AuthController();
        TaskController _taskController = new TaskController();
        public List<UserInfo> GetAllUsers()
        {
            List<UserInfo> users = new List<UserInfo>();
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    string query = @"Select Id, email,createdOn from users where refRole = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(new UserInfo
                                {
                                    Id = reader.GetInt32(0),
                                    Email = reader.GetString(1),
                                    CreatedOn = reader.GetDateTime(2),
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return users;
        }
        public int CountAllusers()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    string query = @"Select count(*) from users where refRole = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }
        public BindingList<TaskItem> GetAllTasksbyId(int id)
        {
            if (id == null) return null;
            BindingList<TaskItem> list = _taskController.showTasks(id);
            if (list == null) return null;
            return list;
        }
        public BindingList<TaskItem> GetIncompleteTasks(int id)
        {
            if (id == null) return null;
            BindingList<TaskItem> list = new BindingList<TaskItem>();
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    string query = @"SELECT Description, IsCompleted,CreatedOn,UpdatedOn,TaskId FROM Tasks WHERE isCompleted = 0 and refUser = @userId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new TaskItem
                                {
                                    Description = reader.GetString(0),
                                    IsCompleted = reader.GetBoolean(1),
                                    CreatedOn = reader.GetDateTime(2),
                                    UpdatedOn = reader.GetDateTime(3),
                                    TaskId = reader.GetInt32(4)
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }
        public BindingList<TaskItem> GetCompletedTasks(int id)
        {
            if (id == null) return null;
            BindingList<TaskItem> list = new BindingList<TaskItem>();
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    string query = @"SELECT Description, IsCompleted,CreatedOn,UpdatedOn,TaskId FROM Tasks WHERE isCompleted = 1 and refUser = @userId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new TaskItem
                                {
                                    Description = reader.GetString(0),
                                    IsCompleted = reader.GetBoolean(1),
                                    CreatedOn = reader.GetDateTime(2),
                                    UpdatedOn = reader.GetDateTime(3),
                                    TaskId = reader.GetInt32(4)
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }
        public int FindAllTasks(int id)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    string query = @"SELECT count(*) FROM Tasks WHERE refUser = @userId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", id);
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int FindCompletedTasks(int id)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    string query = @"SELECT count(*) FROM Tasks WHERE refUser = @userId and isCompleted = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", id);
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}