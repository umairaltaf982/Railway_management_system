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
using WindowsFormsApp1.AllForms.Passenger;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1
{
    public partial class SignUpPassenger : Form
    {
        string conStr = UserFunctions.connectionString;
        string passengerEmail;
        private string passengerName;
        string passengerPhoneNumber;
        string passengerCNIC;
        string passengerPass;
        public SignUpPassenger()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UserFunctions.Apply_Panel1_Transparency(panel1);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dashboard.getDashboard().Show();
        }
        private void alreadyHaveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            LoginPassenger passengerLoginForm = new LoginPassenger();
            passengerLoginForm.Show();
        }

        private void SignUpPassenger_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard.getDashboard().Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)

        {
            passengerEmail = emailBox.Text.Trim();
            passengerName = NameBox.Text.Trim();
            passengerPhoneNumber = phoneNumberBox.Text.Trim();
            passengerCNIC = cnicBox.Text.Trim();
            passengerPass = passwordBox.Text.Trim();
            bool signUpInputStatus = UserFunctions.ValidateUserInput(passengerEmail, passengerPhoneNumber, passengerCNIC, passengerName, this);

            if (string.IsNullOrEmpty(passengerEmail) || string.IsNullOrEmpty(passengerName) ||
     string.IsNullOrEmpty(passengerPhoneNumber) || string.IsNullOrEmpty(passengerCNIC) ||
     string.IsNullOrEmpty(passengerPass) || !signUpInputStatus)
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open();
                string checkExistingUserSql = "SELECT * FROM Passenger WHERE p_phone_number = :phoneNumber OR p_email_id = :email OR p_cnic = :cnic";
                using (OracleCommand checkUserCmd = new OracleCommand(checkExistingUserSql, connection))
                {
                    checkUserCmd.Parameters.Add(new OracleParameter(":phoneNumber", passengerPhoneNumber));
                    checkUserCmd.Parameters.Add(new OracleParameter(":email", passengerEmail));
                    checkUserCmd.Parameters.Add(new OracleParameter(":cnic", passengerCNIC));

                    using (OracleDataReader reader = checkUserCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("A user with this phone number, email, or CNIC already exists. Please try a different combination.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                var otpObj = new OTPWindow(passengerEmail);
                otpObj.ShowDialog();
                bool otpStatus = otpObj.OTPStatusInfo1;

                if (otpStatus)
                {
                    string insertPassengerSql = "INSERT INTO Passenger (p_email_id, p_name, p_phone_number, p_password, p_cnic) VALUES (:email, :name, :phoneNumber, :password, :cnic)";
                    using (OracleCommand insertPassengerCmd = new OracleCommand(insertPassengerSql, connection))
                    {
                        insertPassengerCmd.Parameters.Add(new OracleParameter(":email", passengerEmail));
                        insertPassengerCmd.Parameters.Add(new OracleParameter(":name", passengerName));
                        insertPassengerCmd.Parameters.Add(new OracleParameter(":phoneNumber", passengerPhoneNumber));
                        insertPassengerCmd.Parameters.Add(new OracleParameter(":password", passengerPass));
                        insertPassengerCmd.Parameters.Add(new OracleParameter(":cnic", passengerCNIC));

                        insertPassengerCmd.ExecuteNonQuery();
                        MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        var passengerlogin = new LoginPassenger();
                        passengerlogin.Show();
                    }
                }
                else
                {
                    MessageBox.Show("OTP verification Error❌...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
