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
    public partial class helpSupportEmployee : Form
    {
        string conStr = UserFunctions.connectionString;

        public helpSupportEmployee()
        {
            InitializeComponent();
        }

        private void helpSupportEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT p_email_id, HELP_TITLE, P_HELPSUPPORT, P_HELPSUPPORTSTATUS, E_RESPONSE FROM HELPSUPPORTEMPLOYEE";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string email = reader["p_email_id"].ToString();
                            string helpSupport = reader["P_HELPSUPPORT"].ToString();
                            string helpTitle = reader["HELP_TITLE"].ToString();
                            string helpSupportStatus = reader["P_HELPSUPPORTSTATUS"].ToString();
                            string response = reader["E_RESPONSE"].ToString();
                            dataGridView1.Rows.Add(email, helpTitle, helpSupport, helpSupportStatus, response);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter a response in textBox1.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string helpSupport = selectedRow.Cells["HelpSupport"].Value.ToString();
                string response = textBox1.Text;
                string sql = "UPDATE HELPSUPPORTEMPLOYEE SET E_RESPONSE = :Response, P_HELPSUPPORTSTATUS = 'Resolved' WHERE P_HELPSUPPORT = :HelpSupport";
                using (OracleConnection connection = new OracleConnection(conStr))
                using (OracleCommand cmd = new OracleCommand(sql, connection))
                {
                    cmd.Parameters.Add(":Response", OracleDbType.Varchar2).Value = response;
                    cmd.Parameters.Add(":HelpSupport", OracleDbType.Varchar2).Value = helpSupport;
                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Response submitted successfully and issue resolved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("An error occurred while submitting response: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
