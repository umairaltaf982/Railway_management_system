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


namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        

         static readonly Dashboard dashboard = new Dashboard();
        private Dashboard()
        {
            InitializeComponent();
        }
        public static Dashboard getDashboard()
        {
            return dashboard;
        }
        private void passengerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPassenger passengerLoginForm = new LoginPassenger();
            passengerLoginForm.ShowDialog();
        }
        private void employeePassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmployee employeeLoginForm = new LoginEmployee();
            employeeLoginForm.ShowDialog();
        }
        private void adminPassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin adminLoginForm = new LoginAdmin();
            adminLoginForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           UserFunctions.Apply_Panel1_Transparency(panel1);
        }

    }
}
