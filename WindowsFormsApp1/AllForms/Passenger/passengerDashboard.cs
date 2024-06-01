using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AllForms.Employee;

namespace WindowsFormsApp1.AllForms.Passenger
{
    public partial class passengerDashboard : Form
    {
        bool sideBarExpand;
        Form pageForm;
        Timer timer = null;
        string _email = "umair@rmsdb.com";
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
        public void LoadPage(Form _pageForm)
        {

            centralPanel.Controls.Clear();
            pageForm = _pageForm;
            pageForm.Dock = DockStyle.Fill;
            pageForm.TopLevel = false;
            centralPanel.Controls.Add(pageForm);
            pageForm.Show();
        }

        public passengerDashboard()
        {
            InitializeComponent();
        }
        public passengerDashboard( string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void passengerDashboard_Load(object sender, EventArgs e)
        {
            mainTitle.Text = "Passenger Dashboard";
            LoadPage(new passengerCheckProfile(_email));
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
            mainTitle.Text = "Passenger Dashboard";
            LoadPage(new passengerCheckProfile(_email));
        }

        private void passengerLogoutBtn_Click(object sender, EventArgs e)
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

        private void PassengerProfileButton_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Passenger Dashboard";
            LoadPage(new passengerCheckProfile(_email));
        }

        private void PassengerCheckProfile_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Passenger Dashboard";
            LoadPage(new passengerCheckProfile(_email));
        }

        private void PassengerBookSeats_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Book Seats";
            LoadPage(new bookSeatsPassenger());
        }

        private void PassengerReportAndFeedback_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Feedback and Reports";
            LoadPage(new passengerGiveFeedback());
        }

        private void passengerTrackTrains_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Track the Trains";
            LoadPage(new passengerTrackTrain());
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

        private void PassengerPrevReservations_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Tickets you Own";
            LoadPage(new prevReservation(_email));
        }
    }
}
