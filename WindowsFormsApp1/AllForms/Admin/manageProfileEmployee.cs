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
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.Static_Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.AllForms.Admin
{

    public partial class manageProfileEmployee : Form
    {
        string conStr = UserFunctions.connectionString;
        string _empID = "E020";
        public manageProfileEmployee()
        {
            InitializeComponent();
        }

        public string GetNextEmployeeId(string connectionString)
        {
            string nextEmployeeId = null;

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    string query = "SELECT MAX(TO_NUMBER(SUBSTR(E_ID, 2))) + 1 AS NextId FROM EMPLOYEE";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int nextId = Convert.ToInt32(result);
                            nextEmployeeId = $"E{nextId:D3}"; // Format the next ID as E001, E002, ...
                        }
                        else
                        {
                            nextEmployeeId = "E001"; // If no records in the table, start from E001
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("An Oracle error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nextEmployeeId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nextEmployeeId = null;
            }

            return nextEmployeeId;
        }

        private void manageProfileEmployee_Load(object sender, EventArgs e)
        {
            string email = "";
            dataGridView1.Rows.Clear();
            string sql = "SELECT e_name, e_email_id, e_id, e_type, e_SALARY, e_password FROM employee";
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
                            email = reader["e_email_id"].ToString();
                            string password = reader["e_password"].ToString();
                            string id = reader["e_id"].ToString();
                            string type = reader["e_type"].ToString();
                            string salary = reader["e_salary"].ToString();
                            string name = reader["e_name"].ToString();
                            dataGridView1.Rows.Add(id, name, email, password, salary, type);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                emailBox.Text = selectedRow.Cells["e_email_id"].Value.ToString();
                nameBox.Text = selectedRow.Cells["e_name"].Value.ToString();
                passwordBox.Text = selectedRow.Cells["e_password"].Value.ToString();
                idBox.Text = selectedRow.Cells["e_id"].Value.ToString();
                salaryBox.Text = selectedRow.Cells["e_SALARY"].Value.ToString();
                typeBox.Text = selectedRow.Cells["e_type"].Value.ToString();
                string empEmail = emailBox.Text.ToString().Trim();
                // Loading Image
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    string sql = "SELECT E_PICTURE FROM employee WHERE e_EMAIL_ID = :email";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":email", empEmail));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader[0] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader[0];
                                    employeePicture.Image = Image.FromStream(new MemoryStream(imageData));
                                    employeePicture.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    employeePicture.Image = null;
                                    MessageBox.Show("No image found for employee with email: " + empEmail);
                                    
                                }
                            }
                            else
                            {
                                employeePicture.Image = null;
                                MessageBox.Show("Image not found with email: " + empEmail);
                            }
                        }
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string e_name = nameBox.Text;
            string e_email_id = emailBox.Text;
            string e_password = passwordBox.Text;
            string e_salary = salaryBox.Text;
            string e_type = typeBox.Text;
            string e_id = idBox.Text;

            string sql = "UPDATE EMPLOYEE SET E_NAME = :Username, E_EMAIL_ID = :Email, E_PASSWORD = :Password, E_SALARY = :Salary, E_TYPE = :Type, E_ID = :id WHERE E_EMAIL_ID = :Email";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Username", OracleDbType.Varchar2).Value = e_name;
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = e_email_id;
                cmd.Parameters.Add(":Password", OracleDbType.Varchar2).Value = e_password;
                cmd.Parameters.Add(":Salary", OracleDbType.Varchar2).Value = e_salary;
                cmd.Parameters.Add(":Type", OracleDbType.Varchar2).Value = e_type;
                cmd.Parameters.Add(":id", OracleDbType.Varchar2).Value = e_id;

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee information updated successfully.");
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string name = nameBox.Text;
            string password = passwordBox.Text;
            string id = idBox.Text;
            string salary = salaryBox.Text;
            string type = typeBox.Text;
            _empID = GetNextEmployeeId(conStr);

            string sql = "INSERT INTO employee (e_email_id, e_name, e_password, e_id, e_salary, e_type) " +
                         "VALUES (:email, :name, :password, :id, :salary, :type)";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                idBox.Text = _empID;
                cmd.Parameters.Add(new OracleParameter("email", email));
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.Parameters.Add(new OracleParameter("password", password));
                cmd.Parameters.Add(new OracleParameter("id", _empID));
                cmd.Parameters.Add(new OracleParameter("salary", salary));
                cmd.Parameters.Add(new OracleParameter("type", type));

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No rows were affected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while adding data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idBox.Text;
            string sql = "DELETE FROM employee WHERE e_id = :id";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(new OracleParameter("id", id));
                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        emailBox.Text = "";
                        nameBox.Text = "";
                        passwordBox.Text = "";
                        idBox.Text = "";
                        salaryBox.Text = "";
                        typeBox.Text = "";
                        employeePicture.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("No matching data found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            emailBox.Text = "";
            nameBox.Text = "";
            passwordBox.Text = "";
            idBox.Text = "";
            salaryBox.Text = "";
            typeBox.Text = "";
            employeePicture.Image = null;

        }

        private void employeePicture_Click(object sender, EventArgs e)
        {
            string empEmail = emailBox.Text.ToString().Trim();
            // Ask user to choose an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK && empEmail!="")
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

                        string sql = "UPDATE employee SET e_PICTURE = :imageData WHERE e_EMAIL_ID = :email";

                        using (OracleCommand command = new OracleCommand(sql, connection))
                        {
                            // Use OracleDbType.Blob for image data parameter
                            OracleParameter imageDataParam = new OracleParameter(":imageData", OracleDbType.Blob);
                            imageDataParam.Value = imageData;
                            command.Parameters.Add(imageDataParam);

                            command.Parameters.Add(new OracleParameter(":email", empEmail));

                            command.ExecuteNonQuery();
                            MessageBox.Show("employee image updated successfully!");
                        }
                    }

                    // Display the selected image in the picture box
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        employeePicture.Image = Image.FromStream(ms);
                        employeePicture.SizeMode = PictureBoxSizeMode.Zoom;
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
