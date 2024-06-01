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
    public partial class prevReservation : Form
    {
        string conStr = UserFunctions.connectionString;
        private string _email = "umair@rmsdb.com";
        public prevReservation()
        {
            InitializeComponent();
        }
        public prevReservation(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void prevReservation_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            string sql = "SELECT TRAIN_ID, ticket_id, DESTINATION, origin, p_email, p_phone FROM TICKET where p_email =:email";
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
                            string destination = reader["destination"].ToString();
                            string origin = reader["ORIGIN"].ToString();
                            string trainid = reader["train_id"].ToString();
                            string ticketid = reader["ticket_id"].ToString();
                            string phone = reader["p_phone"].ToString();
                            string xemail = reader["p_email"].ToString();
                            dataGridView1.Rows.Add(ticketid, trainid, origin, destination, xemail, phone);
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
