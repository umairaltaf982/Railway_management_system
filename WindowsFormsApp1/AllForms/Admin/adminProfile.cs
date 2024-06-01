using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Admin
{

    public partial class adminProfile : Form
    {
        string conStr = UserFunctions.connectionString;
        //private TextBox adminNameTextBox;
        //private TextBox emailTextBox;
        //private TextBox passwordTextBox;
        private string emailFromAdmin = "umair@rmsdb.com";
        public adminProfile()
        {
            InitializeComponent();
        }
        public adminProfile(string _email)
        {
            InitializeComponent();
            emailFromAdmin =_email;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dashboard.getDashboard().Show();
            }
        }

        private void adminProfile_Load(object sender, EventArgs e)
        {
            string sql = "SELECT A_NAME, A_About, a_password, a_email_id FROM administrator WHERE A_EMAIL_ID = :Email";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = emailFromAdmin;

                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string aName = reader["A_NAME"].ToString();
                            string aEmail = reader["A_EMAIL_ID"].ToString();
                            string aPassword = reader["A_PASSWORD"].ToString();
                            string aAbout = reader["A_ABOUT"].ToString();

                            adminName.Text = aName;
                            adminEmail.Text = emailFromAdmin;
                            adminAbout.Text = aAbout;
                            adminPassword.Text = aPassword;
                        }
                        else
                        {
                            MessageBox.Show("Admin information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving admin information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try { 

            // Loading Image
            using (OracleConnection connection = new OracleConnection(conStr))
            {
                connection.Open();

                sql = "SELECT A_PICTURE FROM administrator WHERE A_EMAIL_ID = :email";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(new OracleParameter(":email", emailFromAdmin));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader[0] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader[0];
                                adminPicture.Image = Image.FromStream(new MemoryStream(imageData));
                                adminPicture.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            else
                            {
                                adminPicture.Image = null; 
                                MessageBox.Show("No image found for Admin with email: " + emailFromAdmin);
                                adminPicture.Image = Properties.Resources.pngwing_com;
                            }
                        }
                        else
                        {
                            adminPicture.Image = null; 
                            MessageBox.Show("Admin not found with email: " + emailFromAdmin);
                        }
                    }
                }
            }
            }
            catch(OracleException ex)
            {
                MessageBox.Show("An error occurred while retrieving image : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                if (adminPassword.PasswordChar == '*')
                {
                    adminPassword.PasswordChar = (char)0;
                    pictureBox1.Image = Properties.Resources.icons8_eye_25;
                }
                else
                {
                    adminPassword.PasswordChar = '*';
                    pictureBox1.Image = Properties.Resources.icons8_eye_25__1_;
                }
            

        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            string a_name = adminName.Text;
            string a_email_id = adminEmail.Text;
            string a_password = adminPassword.Text;
            string a_about = adminAbout.Text;

            string sql = "UPDATE ADMINISTRATOR SET A_NAME = :Username, A_EMAIL_ID = :Email, A_PASSWORD = :Password, A_ABOUT = :About WHERE A_EMAIL_ID = :OldEmail";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Username", OracleDbType.Varchar2).Value = a_name;
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = a_email_id;
                cmd.Parameters.Add(":Password", OracleDbType.Varchar2).Value = a_password;
                cmd.Parameters.Add(":About", OracleDbType.Varchar2).Value = a_about;
                cmd.Parameters.Add(":OldEmail", OracleDbType.Varchar2).Value = emailFromAdmin;

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee information updated successfully.");
                        // Update the emailFromEmployee if the email is changed
                        emailFromAdmin = a_email_id;
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the given email.");
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while updating employee information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void adminPicture_Click(object sender, EventArgs e)
        {
            // Ask user to choose an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageData;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, (int)fs.Length);
                    }

                    using (OracleConnection connection = new OracleConnection(conStr))
                    {
                        connection.Open();

                        string sql = "UPDATE administrator SET a_PICTURE = :imageData WHERE a_EMAIL_ID = :email";

                        using (OracleCommand command = new OracleCommand(sql, connection))
                        {
                            // Use OracleDbType.Blob for image data parameter
                            OracleParameter imageDataParam = new OracleParameter(":imageData", OracleDbType.Blob);
                            imageDataParam.Value = imageData;
                            command.Parameters.Add(imageDataParam);

                            command.Parameters.Add(new OracleParameter(":email", emailFromAdmin));

                            command.ExecuteNonQuery();
                            MessageBox.Show("admin image updated successfully!");
                        }
                    }

                    // Display the selected image in the picture box
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        adminPicture.Image = Image.FromStream(ms);
                        adminPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating image: " + ex.Message);
                }
            }
        }
    }
}
