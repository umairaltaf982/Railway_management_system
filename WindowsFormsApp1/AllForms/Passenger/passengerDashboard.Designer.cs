namespace WindowsFormsApp1.AllForms.Passenger
{
    partial class passengerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PassengerCheckProfile = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PassengerBookSeats = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PassengerPrevReservations = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PassengerReportAndFeedback = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.passengerTrackTrains = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.passengerLogoutBtn = new System.Windows.Forms.Button();
            this.mainTitle = new System.Windows.Forms.Label();
            this.tempInfo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.reloadButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PassengerProfileButton = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).BeginInit();
            this.panel6.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // centralPanel
            // 
            this.centralPanel.BackColor = System.Drawing.SystemColors.Control;
            this.centralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralPanel.Location = new System.Drawing.Point(194, 52);
            this.centralPanel.MaximumSize = new System.Drawing.Size(788, 397);
            this.centralPanel.MinimumSize = new System.Drawing.Size(788, 397);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(788, 397);
            this.centralPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 49);
            this.panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_menu_50;
            this.menuButton.Location = new System.Drawing.Point(9, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(35, 25);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PassengerCheckProfile);
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 43);
            this.panel2.TabIndex = 1;
            // 
            // PassengerCheckProfile
            // 
            this.PassengerCheckProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassengerCheckProfile.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.PassengerCheckProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerCheckProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerCheckProfile.ForeColor = System.Drawing.Color.White;
            this.PassengerCheckProfile.Image = global::WindowsFormsApp1.Properties.Resources.icons8_employees_25__1_;
            this.PassengerCheckProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerCheckProfile.Location = new System.Drawing.Point(-1, -2);
            this.PassengerCheckProfile.Name = "PassengerCheckProfile";
            this.PassengerCheckProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PassengerCheckProfile.Size = new System.Drawing.Size(188, 55);
            this.PassengerCheckProfile.TabIndex = 1;
            this.PassengerCheckProfile.Text = "          Check Profile";
            this.PassengerCheckProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerCheckProfile.UseVisualStyleBackColor = true;
            this.PassengerCheckProfile.Click += new System.EventHandler(this.PassengerCheckProfile_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.PassengerBookSeats);
            this.panel5.Location = new System.Drawing.Point(3, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 43);
            this.panel5.TabIndex = 2;
            // 
            // PassengerBookSeats
            // 
            this.PassengerBookSeats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassengerBookSeats.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.PassengerBookSeats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerBookSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerBookSeats.ForeColor = System.Drawing.Color.White;
            this.PassengerBookSeats.Image = global::WindowsFormsApp1.Properties.Resources.icons8_seat_25;
            this.PassengerBookSeats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerBookSeats.Location = new System.Drawing.Point(-1, -6);
            this.PassengerBookSeats.Name = "PassengerBookSeats";
            this.PassengerBookSeats.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PassengerBookSeats.Size = new System.Drawing.Size(189, 55);
            this.PassengerBookSeats.TabIndex = 2;
            this.PassengerBookSeats.Text = "          Book Seat";
            this.PassengerBookSeats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerBookSeats.UseVisualStyleBackColor = true;
            this.PassengerBookSeats.Click += new System.EventHandler(this.PassengerBookSeats_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PassengerPrevReservations);
            this.panel4.Location = new System.Drawing.Point(3, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 43);
            this.panel4.TabIndex = 2;
            // 
            // PassengerPrevReservations
            // 
            this.PassengerPrevReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassengerPrevReservations.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.PassengerPrevReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerPrevReservations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerPrevReservations.ForeColor = System.Drawing.Color.White;
            this.PassengerPrevReservations.Image = global::WindowsFormsApp1.Properties.Resources.icons8_ticket_purchase_25;
            this.PassengerPrevReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerPrevReservations.Location = new System.Drawing.Point(-1, -10);
            this.PassengerPrevReservations.Name = "PassengerPrevReservations";
            this.PassengerPrevReservations.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PassengerPrevReservations.Size = new System.Drawing.Size(189, 56);
            this.PassengerPrevReservations.TabIndex = 3;
            this.PassengerPrevReservations.Text = "          Prev. Reservs";
            this.PassengerPrevReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerPrevReservations.UseVisualStyleBackColor = true;
            this.PassengerPrevReservations.Click += new System.EventHandler(this.PassengerPrevReservations_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PassengerReportAndFeedback);
            this.panel3.Location = new System.Drawing.Point(3, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 37);
            this.panel3.TabIndex = 2;
            // 
            // PassengerReportAndFeedback
            // 
            this.PassengerReportAndFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassengerReportAndFeedback.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.PassengerReportAndFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerReportAndFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerReportAndFeedback.ForeColor = System.Drawing.Color.White;
            this.PassengerReportAndFeedback.Image = global::WindowsFormsApp1.Properties.Resources.icons8_open_email_25;
            this.PassengerReportAndFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerReportAndFeedback.Location = new System.Drawing.Point(-1, -15);
            this.PassengerReportAndFeedback.Name = "PassengerReportAndFeedback";
            this.PassengerReportAndFeedback.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PassengerReportAndFeedback.Size = new System.Drawing.Size(188, 54);
            this.PassengerReportAndFeedback.TabIndex = 4;
            this.PassengerReportAndFeedback.Text = "          Give Feedback";
            this.PassengerReportAndFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassengerReportAndFeedback.UseVisualStyleBackColor = true;
            this.PassengerReportAndFeedback.Click += new System.EventHandler(this.PassengerReportAndFeedback_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.passengerTrackTrains);
            this.panel14.Location = new System.Drawing.Point(3, 248);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(208, 37);
            this.panel14.TabIndex = 3;
            // 
            // passengerTrackTrains
            // 
            this.passengerTrackTrains.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passengerTrackTrains.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.passengerTrackTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passengerTrackTrains.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerTrackTrains.ForeColor = System.Drawing.Color.White;
            this.passengerTrackTrains.Image = global::WindowsFormsApp1.Properties.Resources.icons8_train_25;
            this.passengerTrackTrains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passengerTrackTrains.Location = new System.Drawing.Point(-1, -14);
            this.passengerTrackTrains.Name = "passengerTrackTrains";
            this.passengerTrackTrains.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passengerTrackTrains.Size = new System.Drawing.Size(188, 54);
            this.passengerTrackTrains.TabIndex = 5;
            this.passengerTrackTrains.Text = "          Track Trains";
            this.passengerTrackTrains.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passengerTrackTrains.UseVisualStyleBackColor = true;
            this.passengerTrackTrains.Click += new System.EventHandler(this.passengerTrackTrains_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.passengerLogoutBtn);
            this.panel15.Location = new System.Drawing.Point(3, 291);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(208, 37);
            this.panel15.TabIndex = 3;
            // 
            // passengerLogoutBtn
            // 
            this.passengerLogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passengerLogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.passengerLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passengerLogoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLogoutBtn.ForeColor = System.Drawing.Color.White;
            this.passengerLogoutBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_logout_25;
            this.passengerLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passengerLogoutBtn.Location = new System.Drawing.Point(-1, -14);
            this.passengerLogoutBtn.Name = "passengerLogoutBtn";
            this.passengerLogoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passengerLogoutBtn.Size = new System.Drawing.Size(188, 54);
            this.passengerLogoutBtn.TabIndex = 6;
            this.passengerLogoutBtn.Text = "          Log Out";
            this.passengerLogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passengerLogoutBtn.UseVisualStyleBackColor = true;
            this.passengerLogoutBtn.Click += new System.EventHandler(this.passengerLogoutBtn_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mainTitle.Location = new System.Drawing.Point(85, 11);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(248, 32);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Passenger Dashboard";
            // 
            // tempInfo
            // 
            this.tempInfo.BackColor = System.Drawing.Color.Black;
            this.tempInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempInfo.ForeColor = System.Drawing.Color.White;
            this.tempInfo.Location = new System.Drawing.Point(339, 21);
            this.tempInfo.Multiline = true;
            this.tempInfo.Name = "tempInfo";
            this.tempInfo.ReadOnly = true;
            this.tempInfo.Size = new System.Drawing.Size(276, 21);
            this.tempInfo.TabIndex = 101;
            this.tempInfo.Text = "Logout action declined";
            this.tempInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempInfo.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.reloadButton);
            this.panel7.Controls.Add(this.backButton);
            this.panel7.Controls.Add(this.mainTitle);
            this.panel7.Controls.Add(this.tempInfo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(679, 52);
            this.panel7.TabIndex = 0;
            // 
            // reloadButton
            // 
            this.reloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.reloadButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reload_25;
            this.reloadButton.Location = new System.Drawing.Point(649, 0);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(30, 52);
            this.reloadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reloadButton.TabIndex = 103;
            this.reloadButton.TabStop = false;
            this.reloadButton.Tag = "Reload the Data";
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_25;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(6, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 34);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.PassengerProfileButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(194, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(788, 52);
            this.panel6.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::WindowsFormsApp1.Properties.Resources.icons8_notification_25;
            this.button7.Location = new System.Drawing.Point(679, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 52);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = global::WindowsFormsApp1.Properties.Resources.icons8_message_25;
            this.button6.Location = new System.Drawing.Point(716, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 52);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // PassengerProfileButton
            // 
            this.PassengerProfileButton.BackColor = System.Drawing.Color.Black;
            this.PassengerProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PassengerProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassengerProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PassengerProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerProfileButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_administrator_male_48;
            this.PassengerProfileButton.Location = new System.Drawing.Point(748, 0);
            this.PassengerProfileButton.Name = "PassengerProfileButton";
            this.PassengerProfileButton.Size = new System.Drawing.Size(40, 52);
            this.PassengerProfileButton.TabIndex = 1;
            this.PassengerProfileButton.UseVisualStyleBackColor = false;
            this.PassengerProfileButton.Click += new System.EventHandler(this.PassengerProfileButton_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Black;
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel14);
            this.sideBar.Controls.Add(this.panel15);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(211, 450);
            this.sideBar.MinimumSize = new System.Drawing.Size(58, 450);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(194, 450);
            this.sideBar.TabIndex = 3;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Enabled = true;
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // passengerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 449);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.sideBar);
            this.MaximumSize = new System.Drawing.Size(998, 488);
            this.MinimumSize = new System.Drawing.Size(998, 488);
            this.Name = "passengerDashboard";
            this.Text = "passengerDashboard";
            this.Load += new System.EventHandler(this.passengerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).EndInit();
            this.panel6.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PassengerCheckProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PassengerBookSeats;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button PassengerPrevReservations;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PassengerReportAndFeedback;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button passengerTrackTrains;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button passengerLogoutBtn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button PassengerProfileButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TextBox tempInfo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.PictureBox reloadButton;
    }
}