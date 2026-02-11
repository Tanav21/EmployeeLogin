using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp1.Controller
{
    public class TaskController
    {
        public BindingList<TaskItem> showTasks(int userId)
        {
            var taskList = new BindingList<TaskItem>();
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    string query = @"SELECT Description, IsCompleted,createdOn,updatedOn,TaskId FROM Tasks WHERE refUser = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                taskList.Add(new TaskItem
                                {
                                    Description = reader.GetString(0),
                                    IsCompleted = reader.GetBoolean(1),
                                    CreatedOn = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                                    UpdatedOn = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                                    TaskId = reader.GetInt32(reader.GetOrdinal("TaskId")),
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

            return taskList;
        }

        public TaskItem AddTask(int userId, string description)
        {
            var taskList = showTasks(userId);
            int taskId = 0;
            TaskItem task = null;
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    // Insert and get the generated TaskId
                    string insertQuery = @"
                    INSERT INTO tasks (refUser, description) 
                    VALUES (@userId, @description);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Description", description);

                        taskId = (int)cmd.ExecuteScalar(); // ✅ Now we get the new TaskId
                        task = new TaskItem
                        {
                            TaskId = taskId,
                            Description = description,
                            IsCompleted = false,
                            CreatedOn = DateTime.Now,
                            UpdatedOn = DateTime.Now
                        };
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
            taskList.Add(task);
            return task;
        }

        public bool DeleteTask(int taskId)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();
                    string deleteQuery = @"Delete from tasks where taskId = @taskId";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@taskId", taskId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? true : false;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
