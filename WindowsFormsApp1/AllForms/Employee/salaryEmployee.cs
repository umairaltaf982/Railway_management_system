using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class salaryEmployee : Form
    {
        string conStr = UserFunctions.connectionString;
        string _email = "umair@employee.com";
        decimal _bonus = 100;
        public salaryEmployee()
        {
            InitializeComponent();
        }
        public salaryEmployee(string email)
        {
            InitializeComponent();
            _email = email;
            CalculateAndUpdateBonus(conStr, _email);
        }
        public void CalculateAndUpdateBonus(string connectionString, string email)
        {
            try
            {
                string completedTasksQuery = "SELECT COUNT(*) FROM EMPLOYEE_TASK WHERE E_EMAIL_ID = :Email AND E_TASK_STATUS = 'Completed'";
                int completedTasksCount;

                using (OracleConnection connection = new OracleConnection(connectionString))
                using (OracleCommand command = new OracleCommand(completedTasksQuery, connection))
                {
                    connection.Open();
                    command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;
                    completedTasksCount = Convert.ToInt32(command.ExecuteScalar());
                }

                decimal bonus = completedTasksCount * 100;
                decimal newSalary = GetEmployeeSalary(connectionString, email) + bonus;

                string updateBonusQuery = "UPDATE SALARY SET E_BONUS = :Bonus WHERE E_EMAIL_ID = :Email";
                string updateSalaryQuery = "UPDATE EMPLOYEE SET E_SALARY = :Salary WHERE E_EMAIL_ID = :Email";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(updateBonusQuery, connection))
                    {
                        command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add(":Bonus", OracleDbType.Decimal).Value = bonus;
                        command.ExecuteNonQuery();
                    }

                    using (OracleCommand command = new OracleCommand(updateSalaryQuery, connection))
                    {
                        command.Parameters.Add(":Salary", OracleDbType.Decimal).Value = newSalary;
                        command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Bonus and salary updated successfully for employee with email: {email}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException ex)
            {
                MessageBox.Show("An Oracle error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetEmployeeSalary(string connectionString, string email)
        {
            string salaryQuery = "SELECT E_SALARY FROM EMPLOYEE WHERE E_EMAIL_ID = :Email";
            using (OracleConnection connection = new OracleConnection(connectionString))
            using (OracleCommand command = new OracleCommand(salaryQuery, connection))
            {
                connection.Open();
                command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;
                object result = command.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }



        private void salaryEmployee_Load(object sender, EventArgs e)
        {
            string sql = "SELECT CONCAT('$', E_SALARY) FROM Salary WHERE E_EMAIL_ID = :Email";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = _email;

                try
                {
                    connection.Open();
                    object salary = cmd.ExecuteScalar();
                    if (salary != null && DateTime.Now.Day == 30 )
                    {
                        textBox1.Text = salary.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Salary not found for the employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "End-Of-Month";
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving salary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



            dataGridView1.Rows.Clear();
            sql = "SELECT e_salary_id, e_salary, e_month, e_bonus FROM SALARY where e_email_id =:email";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = _email;
                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string salaryId = reader["e_salary_id"].ToString().Trim();
                            string eSalary = reader["e_salary"].ToString().Trim();
                            string eMonth = reader["e_month"].ToString().Trim();
                            string eBonus = reader["e_bonus"].ToString().Trim();
                            dataGridView1.Rows.Add(salaryId, eSalary, eBonus, eMonth);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
