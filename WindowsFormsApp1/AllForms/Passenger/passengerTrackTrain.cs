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
    public partial class passengerTrackTrain : Form
    {
        string conStr = UserFunctions.connectionString;
        public passengerTrackTrain()
        {
            InitializeComponent();
        }

        private void passengerTrackTrain_Load(object sender, EventArgs e)
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
                            dataGridView1.Rows.Add(id, name, announce, destination, arrival, type, destTime, arrivalTime);
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
