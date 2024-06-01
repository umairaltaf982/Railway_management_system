using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AllForms.Admin;

namespace WindowsFormsApp1
{
    public partial class AdminDashboard : Form
    {
        Form pageForm;
        bool sideBarExpand;
        Timer timer = null;

        string _email = "umair@rmsdb.com";
        public void LoadPage(Form _pageForm)
        {

            centralPanel.Controls.Clear();
            pageForm = _pageForm;
            pageForm.Dock = DockStyle.Fill;
            pageForm.TopLevel = false;
            centralPanel.Controls.Add(pageForm);
            pageForm.Show();
        }

        public AdminDashboard()
        {

            InitializeComponent();
        }
        public AdminDashboard(string email)
        {

            InitializeComponent();
            _email = email;
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Admin Dashboard";
            LoadPage(new MainAdminPage());
        }
        private void menuButton_Click(object sender, EventArgs e)
        {

            sideBarTimer.Start();
        }


        private void adminCheckProfileBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new adminProfile(_email));
            mainTitle.Text = "Admin Profile";
        }



        private void adminManageProfileBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new manageProfileEmployee());
            mainTitle.Text = "Manage Employees ";
        }

        private void adminManageScheduleBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new manageTrainAdmin());
            mainTitle.Text = "Manage Train Schedule";
        }

        private void adminRevenueBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new revenuePdfAdmin());
            mainTitle.Text = "Revenue";
        }

        private void adminViewTrainsBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new viewTrainAdmin());
            mainTitle.Text = "View Train Details";
        }

        private void adminTasksBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new assignTasksAdmin());
            mainTitle.Text = "Manage Employee Tasks";
        }

        private void adminViewFeedbackBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new viewFeedbacksAAdmin());
            mainTitle.Text = "Passengers Feedback";
        }

        private void adminLogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dashboard.getDashboard().Show();
            }
            else
            {
                ShowTempText("Logout action declined!", 3);

            }
        }
        private void ShowTempText(string text, int durationSeconds)
        {

            tempInfo.Text = text;

            tempInfo.Visible = true;

            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = durationSeconds * 1000; 
                timer.Tick += OnTimerElapsed;
            }
            timer.Start();
        }

        private void OnTimerElapsed(object sender, EventArgs e)
        {
            tempInfo.Visible = false;
            timer.Stop();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadPage(new MainAdminPage());
        }

        private void adminProfileButton_Click(object sender, EventArgs e)
        {
            LoadPage(new adminProfile(_email));
            mainTitle.Text = "Admin Profile";
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            if (pageForm != null)
            {
                centralPanel.Controls.Clear();

                Type formType = pageForm.GetType();
                pageForm = (Form)Activator.CreateInstance(formType);

                pageForm.Dock = DockStyle.Fill;
                pageForm.TopLevel = false;
                centralPanel.Controls.Add(pageForm);
                pageForm.Show();
            }
            else
            {
                ShowTempText("No form loaded to reload!", 3);
            }
        }
    }
}
