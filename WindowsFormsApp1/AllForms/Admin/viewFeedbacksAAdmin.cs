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

namespace WindowsFormsApp1.AllForms.Admin
{
    public partial class viewFeedbacksAAdmin : Form
    {
        string conStr = UserFunctions.connectionString;
        public viewFeedbacksAAdmin()
        {
            InitializeComponent();
        }

        private void viewFeedbacksAAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT p_email_id,help_title, P_HELPSUPPORT, P_HELPSUPPORTSTATUS, E_RESPONSE FROM HELPSUPPORTEMPLOYEE";
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
                            string helpSupportT = reader["help_title"].ToString();
                            string helpSupportStatus = reader["P_HELPSUPPORTSTATUS"].ToString();
                            string response = reader["E_RESPONSE"].ToString();
                            dataGridView1.Rows.Add(email, helpSupportT, helpSupport, helpSupportStatus, response);
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
