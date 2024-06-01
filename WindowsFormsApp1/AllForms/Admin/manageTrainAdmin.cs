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
    public partial class manageTrainAdmin : Form
    {
        private DataTable trainScheduleData;
        string conStr = UserFunctions.connectionString;
        string trainID = "T020";
        public manageTrainAdmin()
        {
            InitializeComponent();
            trainScheduleData = new DataTable();
            
        }
        private string GetNextTicketId(string connectionString)
        {
            string nextTicketId = null;

            try
            {
   
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
         
                    string query = "SELECT MAX(TO_NUMBER(SUBSTR(TRAIN_ID, 2))) + 1 AS NextId FROM TRAINSCHEDULE";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int nextId = Convert.ToInt32(result);
                            nextTicketId = $"T{nextId:D3}"; 
                        }
                        else
                        {
                            nextTicketId = trainID;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("An Oracle error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nextTicketId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nextTicketId = null;
            }

            return nextTicketId;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
            nameBox.Text = "";
            destBox.Text = "";
            typeBox.Text = "";
            arrBox.Text = "";
            arrTBox.Text = "";
            destTBox.Text = "";
            annBox.Text = "";
            trainImageBox.Image = null;
        }

        private void manageTrainAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT TRAIN_ID, TRAIN_NAME, DESTINATION, ARRIVAL, TYPE, ANNOUNCEMENTS, DEST_TIME,ARRIVAL_TIME FROM TRAINSCHEDULE";
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
                            string destination = reader["destination"].ToString();
                            string arrival = reader["arrival"].ToString();
                            string id = reader["train_id"].ToString();
                            string type = reader["type"].ToString();
                            string destTime = reader["dest_time"].ToString();
                            string arrivalTime = reader["arrival_time"].ToString();
                            string name = reader["train_name"].ToString();
                            string announce = reader["announcements"].ToString();
                            dataGridView1.Rows.Add(id, name, arrival, destTime, arrivalTime,destination, type, announce);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string destination = destBox.Text;
            string arrival = arrBox.Text;
            string id = idBox.Text;
            string type = typeBox.Text;
            string destTime = destTBox.Text;
            string arrivalTime = arrTBox.Text;
            string name = nameBox.Text;
            string announce = annBox.Text;
            trainID = GetNextTicketId(conStr);

            string sql = "INSERT INTO trainschedule (TRAIN_ID, TRAIN_NAME, DESTINATION, ARRIVAL, TYPE, ANNOUNCEMENTS, DEST_TIME,ARRIVAL_TIME) " +
                         "VALUES (:id, :name, :destination, :arrival, :type, :announce, :destTime, :arrivalTime)";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                idBox.Text = trainID;
                cmd.Parameters.Add(new OracleParameter("id", trainID));
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.Parameters.Add(new OracleParameter("destination", destination));
                cmd.Parameters.Add(new OracleParameter("arrival", arrival));
                cmd.Parameters.Add(new OracleParameter("type", type));
                cmd.Parameters.Add(new OracleParameter("announce", announce));
                cmd.Parameters.Add(new OracleParameter("destTime", destTime));
                cmd.Parameters.Add(new OracleParameter("arrivalTime", arrivalTime));

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                nameBox.Text = selectedRow.Cells["train_name"].Value.ToString();
                idBox.Text = selectedRow.Cells["train_id"].Value.ToString();
                destBox.Text = selectedRow.Cells["destination"].Value.ToString();
                arrBox.Text = selectedRow.Cells["arrival"].Value.ToString();
                typeBox.Text = selectedRow.Cells["type"].Value.ToString();
                destTBox.Text = selectedRow.Cells["dest_time"].Value.ToString();
                arrTBox.Text = selectedRow.Cells["dest_time"].Value.ToString();
                annBox.Text = selectedRow.Cells["announcements"].Value.ToString();

                string train_ID = idBox.Text.ToString().Trim();
                // Loading Image
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    string sql = "SELECT TRAIN_PICTURE FROM TRAINSCHEDULE WHERE Train_id = :id";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":id", train_ID));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader[0] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader[0];
                                    trainImageBox.BackgroundImage = null;
                                    trainImageBox.Image = Image.FromStream(new MemoryStream(imageData));
                                    trainImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    trainImageBox.Image = null;
                                    MessageBox.Show("No image found for Train with id: " + train_ID);

                                }
                            }
                            else
                            {
                                trainImageBox.Image = null;
                                MessageBox.Show("Image not found with id: " + train_ID);
                            }
                        }
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string destination = destBox.Text;
            string arrival = arrBox.Text;
            string id = idBox.Text;
            string type = typeBox.Text;
            string destTime = destBox.Text;
            string arrivalTime = arrBox.Text;
            string name = nameBox.Text;
            string announce = annBox.Text;

            string sql = "UPDATE TRAINSCHEDULE SET TRAIN_ID = :id, TRAIN_NAME = :name, DESTINATION = :destination, ARRIVAL = :arrival, TYPE = :type, ANNOUNCEMENTS = :announce, DEST_TIME = :destTime, ARRIVAL_TIME = :arrivalTime WHERE train_id = :id";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":id", OracleDbType.Varchar2).Value = id.Trim();
                cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name.Trim();
                cmd.Parameters.Add(":destination", OracleDbType.Varchar2).Value = destination.Trim();
                cmd.Parameters.Add(":arrival", OracleDbType.Varchar2).Value = arrival.Trim();
                cmd.Parameters.Add(":type", OracleDbType.Varchar2).Value = type.Trim();
                cmd.Parameters.Add(":announce", OracleDbType.Varchar2).Value = announce.Trim();
                cmd.Parameters.Add(":destTime", OracleDbType.Varchar2).Value =  destTime.Trim();
                cmd.Parameters.Add(":arrivalTime", OracleDbType.Varchar2).Value =  arrivalTime.Trim();

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Train not found with the given id.");
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while updating Train information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idBox.Text;
            string sql = "DELETE FROM trainschedule WHERE train_id = :id";
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

        private void trainImageBox_Click(object sender, EventArgs e)
        {
            string train_ID = idBox.Text.ToString().Trim();
            // Ask user to choose an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK && train_ID != "")
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

                        string sql = "UPDATE TRAINSCHEDULE SET TRAIN_PICTURE = :imageData WHERE train_Id = :id";

                        using (OracleCommand command = new OracleCommand(sql, connection))
                        {
                            // Use OracleDbType.Blob for image data parameter
                            OracleParameter imageDataParam = new OracleParameter(":imageData", OracleDbType.Blob);
                            imageDataParam.Value = imageData;
                            command.Parameters.Add(imageDataParam);

                            command.Parameters.Add(new OracleParameter(":id", train_ID));

                            command.ExecuteNonQuery();
                            MessageBox.Show("Train image updated successfully!");
                        }
                    }

                    // Display the selected image in the picture box
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        trainImageBox.Image = Image.FromStream(ms);
                        trainImageBox.SizeMode = PictureBoxSizeMode.Zoom;
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
