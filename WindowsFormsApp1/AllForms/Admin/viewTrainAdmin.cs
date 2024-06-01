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

    public partial class viewTrainAdmin : Form
    {
        string conStr = UserFunctions.connectionString;
        public viewTrainAdmin()
        {
            InitializeComponent();
        }

        private void searchtrainButton_Click(object sender, EventArgs e)
        {
            string trainId = searchIdBox.Text.Trim();

            if (string.IsNullOrEmpty(trainId))
            {
                MessageBox.Show("Please enter a train ID to search.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open();

                string sql = "SELECT * FROM TRAINSCHEDULE WHERE train_id = :trainId";
                using (OracleCommand cmd = new OracleCommand(sql, connection))
                {
                    cmd.Parameters.Add(new OracleParameter(":trainId", trainId));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            trainNamebox.Text = reader.GetString(0); trainDestinationBox.Text = reader.GetString(1); trainArrivalBox.Text = reader.GetString(2); traintypeBox.Text = reader.GetString(3); trainEndTimeBox.Text = reader.GetString(4); trainStartTimeBox.Text = reader.GetString(5); trainAnnoucementBox.Text = reader.GetString(6);
                            

                            // Loading Image
                            using (OracleConnection connection1 = new OracleConnection(conStr))
                            {
                                connection1.Open();

                               sql = "SELECT TRAIN_PICTURE FROM TRAINSCHEDULE WHERE Train_id = :id";

                                using (OracleCommand command1 = new OracleCommand(sql, connection1))
                                {
                                    command1.Parameters.Add(new OracleParameter(":id", trainId));

                                    using (OracleDataReader reader1 = command1.ExecuteReader())
                                    {
                                        if (reader1.Read())
                                        {
                                            if (reader1[0] != DBNull.Value)
                                            {
                                                byte[] imageData = (byte[])reader1[0];
                                                trainImageBox.BackgroundImage = null;
                                                trainImageBox.Image = Image.FromStream(new MemoryStream(imageData));
                                                trainImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                            }
                                            else
                                            {
                                                trainImageBox.Image = null;
                                                MessageBox.Show("No image found for Train with id: " + trainId);

                                            }
                                        }
                                        else
                                        {
                                            trainImageBox.Image = null;
                                            MessageBox.Show("Image not found with id: " + trainId);
                                        }
                                    }
                                }
                            }


                            //Image loaded

                        }
                        else
                        {
                            trainNamebox.Text = "";
                            trainDestinationBox.Text = "";
                            traintypeBox.Text = "";
                            trainArrivalBox.Text = "";
                            trainEndTimeBox.Text = "";
                            trainStartTimeBox.Text = "";
                            trainAnnoucementBox.Text = "";
                            trainImageBox.Image = null;

                            MessageBox.Show("No train schedule found for the entered train ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void trainImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Select Image";

            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Filter += "|Image Files (.bmp;.jpg;.jpeg,.png)|.BMP;.JPG;.JPEG;.PNG";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog1.FileName;
                    trainImageBox.Image = Image.FromFile(imagePath);
                    trainImageBox.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
