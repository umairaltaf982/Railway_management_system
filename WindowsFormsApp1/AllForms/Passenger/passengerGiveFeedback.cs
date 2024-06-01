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

namespace WindowsFormsApp1.AllForms.Passenger
{
    public partial class passengerGiveFeedback : Form
    {
        string conStr = UserFunctions.connectionString;
        public passengerGiveFeedback()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text.Trim();
            if (IsEmailValid(email))
            {
                if (!string.IsNullOrWhiteSpace(titleBox.Text) && !string.IsNullOrWhiteSpace(responseBox.Text))
                {
                    string sql = "INSERT INTO HELPSUPPORTEMPLOYEE (help_title, p_helpsupport, p_email_id, p_helpsupportstatus) " +
                                 "VALUES (:title, :feedback, :email, 'pending')";
                    using (OracleConnection connection = new OracleConnection(conStr))
                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        cmd.Parameters.Add(new OracleParameter("title", titleBox.Text));
                        cmd.Parameters.Add(new OracleParameter("feedback", responseBox.Text));
                        cmd.Parameters.Add(new OracleParameter("email", email));
                        try
                        {
                            connection.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to submit feedback.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("An error occurred while submitting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in both Title and Response fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsEmailValid(string email)
        {
            string sql = "SELECT COUNT(*) FROM passenger WHERE p_email_id = :email";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(new OracleParameter("email", email));
                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (OracleException)
                {
                    return false;
                }
            }
        }
        private void ClearTextBoxes()
        {
            titleBox.Text = "";
            responseBox.Text = "";
        }
    }
}
