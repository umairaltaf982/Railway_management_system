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

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class viewTaskEmployee : Form
    {
        string conStr = UserFunctions.connectionString;
        string _email = @"umair@employee.com";
        public viewTaskEmployee()
        {
            InitializeComponent();
        } 
        public viewTaskEmployee(string email)
        {
            _email = email;
            InitializeComponent();
        }

        private void btnCompletedTasks_Click(object sender, EventArgs e)
        {
            listBoxCompleteTasks.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                listBoxCompleteTasks.Items.Add(s);
        }


        private void btnTodoTasks_Click(object sender, EventArgs e)
        {
            listBoxTodoTasks.Items.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    listBoxTodoTasks.Items.Add(checkedListBox1.Items[i]);
                }
            }
        }

        private void viewTaskEmployee_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            string emailFromEmployee = _email;
            string sql = "SELECT e_task, e_task_status FROM employee_task WHERE e_email_id = :Email";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = emailFromEmployee;

                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string task = reader["e_task"].ToString();
                            string status = reader["e_task_status"].ToString();

                            // Add the task to checkedListBox1
                            checkedListBox1.Items.Add(task);

                            // Check the task if its status is 'Completed'
                            if (status == "Completed")
                            {
                                int index = checkedListBox1.Items.IndexOf(task);
                                if (index != -1)
                                    checkedListBox1.SetItemChecked(index, true);
                            }
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string emailFromEmployee = _email;
            using (OracleConnection connection = new OracleConnection(conStr))
            {
                connection.Open();
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    string task = checkedListBox1.Items[i].ToString();
                    string status = checkedListBox1.GetItemChecked(i) ? "Completed" : "Assigned";
                    string sql = "UPDATE employee_task SET e_task_status = :Status WHERE e_email_id = :Email AND e_task = :Task";
                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        cmd.Parameters.Add(":Status", OracleDbType.Varchar2).Value = status;
                        cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = emailFromEmployee;
                        cmd.Parameters.Add(":Task", OracleDbType.Varchar2).Value = task;
                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                //MessageBox.Show($"Task '{task}' status updated to '{status}'.");
                            }
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("An error occurred while updating task status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
