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
using WindowsFormsApp1.AllForms.Employee;
using WindowsFormsApp1.AllForms.Passenger;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1
{
    public partial class LoginPassenger : Form
    {
        string conStr = UserFunctions.connectionString;

        public LoginPassenger()
        {
            InitializeComponent();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UserFunctions.Apply_Panel1_Transparency(panel1);
        }

        private void alreadyAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPassenger passengerSignUp = new SignUpPassenger();
            passengerSignUp.ShowDialog();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            SignUpPassenger passengerSignUp = new SignUpPassenger();
            passengerSignUp.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dashboard.getDashboard().Show();

        }

        private void passengerLoginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email address and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open();
                string sql = "SELECT * FROM Passenger WHERE p_email_id = :email AND p_password = :password";
                using (OracleCommand cmd = new OracleCommand(sql, connection))
                {
                    cmd.Parameters.Add(new OracleParameter(":email", email));
                    cmd.Parameters.Add(new OracleParameter(":password", password));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            this.Close();
                            var passengerDash = new passengerDashboard(email);
                            passengerDash.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email address or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (passwordBox.PasswordChar == '⚫')
            {
                passwordBox.PasswordChar = (char)0;
                pictureBox1.Image = Properties.Resources.icons8_eye_25;
            }
            else
            {
                passwordBox.PasswordChar = '⚫';
                pictureBox1.Image = Properties.Resources.icons8_eye_25__1_;
            }
        }
    }
}
