using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Admin
{
    public partial class assignTasksAdmin : Form

    {
        string conStr = UserFunctions.connectionString;
        public assignTasksAdmin()
        {
            InitializeComponent();
        }

        private void assignTasks_click(object sender, EventArgs e)
        {
            string query = "SELECT E_EMAIL_ID, E_TASK FROM EMPLOYEE_TASK WHERE E_TASK_STATUS = 'Assigned'";

            try
            {
                OracleConnection connection = new OracleConnection(conStr);
                OracleCommand cmd = new OracleCommand(query, connection);

                connection.Open();
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    StringBuilder assignedTasks = new StringBuilder();

                    while (reader.Read())
                    {
                        string eId = reader["E_EMAIL_ID"].ToString();
                        string task = reader["E_TASK"].ToString();
                        assignedTasks.AppendLine($"Employee ID: {eId}, Task: {task}");
                    }

                    textBox3.Text = assignedTasks.ToString();
                }
                else
                {
                    textBox3.Text = "No tasks are currently assigned.";
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving assigned tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void completeTasks_click(object sender, EventArgs e)
        {
            textBox3.Text = "";

            string query = "SELECT E_EMAIL_ID, E_TASK FROM EMPLOYEE_TASK WHERE E_TASK_STATUS = 'Completed'";

            try
            {
                OracleConnection connection = new OracleConnection(UserFunctions.connectionString);
                OracleCommand cmd = new OracleCommand(query, connection);

                connection.Open();
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    StringBuilder completedTasks = new StringBuilder();

                    while (reader.Read())
                    {
                        string eId = reader["E_EMAIL_ID"].ToString();
                        string task = reader["E_TASK"].ToString();
                        completedTasks.AppendLine($"Employee ID: {eId}, Task: {task}");
                    }

                    textBox3.Text = completedTasks.ToString();
                }
                else
                {
                    textBox3.Text = "No tasks are currently completed.";
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving completed tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void searchID_click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            string eId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(eId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"SELECT E_TASK FROM employee_TASK WHERE E_EMAIL_ID = :eId";

            try
            {
                using (OracleConnection connection = new OracleConnection(UserFunctions.connectionString))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(new OracleParameter("eId", eId));

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Invalid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string task = result.ToString();
                            if (!string.IsNullOrEmpty(task))
                            {
                                textBox2.Text = "Task is already assigned for this Employee ID.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking Employee ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void assignButton_click(object sender, EventArgs e)
        {
            string eId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(eId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a task to assign.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string task = GetTaskForEmployee(eId);
            string updateQuery = $"UPDATE EMPLOYEE_TASK SET E_TASK = '{textBox2.Text}', E_TASK_STATUS = 'Assigned' WHERE E_EMAIL_ID = '{eId}'";

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(updateQuery, connection))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Task assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Task could not be assigned. Make sure the Employee ID is valid and the task is not already assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetTaskForEmployee(string eId)
        {


            string query = $"SELECT E_TASK FROM Employee WHERE E_EMAIL_ID = '{eId}'";

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving task for Employee ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }


    }
}
