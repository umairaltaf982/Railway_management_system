namespace WindowsFormsApp1.AllForms.Employee
{
    partial class employeeDashoard
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
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmpCheckProfileBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EmpSalaryBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.reloadButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.mainTitle = new System.Windows.Forms.Label();
            this.tempInfo = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.EmpProfileButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EmpManageTaskBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmpSupportBtn = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.EmpSelTicketBtn = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.EmpLogoutBtn = new System.Windows.Forms.Button();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Enabled = true;
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
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
            this.panel2.Controls.Add(this.EmpCheckProfileBtn);
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 43);
            this.panel2.TabIndex = 1;
            // 
            // EmpCheckProfileBtn
            // 
            this.EmpCheckProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpCheckProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.EmpCheckProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpCheckProfileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpCheckProfileBtn.ForeColor = System.Drawing.Color.White;
            this.EmpCheckProfileBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_employees_25__1_;
            this.EmpCheckProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpCheckProfileBtn.Location = new System.Drawing.Point(-1, -2);
            this.EmpCheckProfileBtn.Name = "EmpCheckProfileBtn";
            this.EmpCheckProfileBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmpCheckProfileBtn.Size = new System.Drawing.Size(188, 55);
            this.EmpCheckProfileBtn.TabIndex = 1;
            this.EmpCheckProfileBtn.Text = "          Check Profile";
            this.EmpCheckProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpCheckProfileBtn.UseVisualStyleBackColor = true;
            this.EmpCheckProfileBtn.Click += new System.EventHandler(this.EmpCheckProfileBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.EmpSalaryBtn);
            this.panel5.Location = new System.Drawing.Point(3, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 43);
            this.panel5.TabIndex = 2;
            // 
            // EmpSalaryBtn
            // 
            this.EmpSalaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpSalaryBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.EmpSalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSalaryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryBtn.ForeColor = System.Drawing.Color.White;
            this.EmpSalaryBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_money_25;
            this.EmpSalaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpSalaryBtn.Location = new System.Drawing.Point(-1, -6);
            this.EmpSalaryBtn.Name = "EmpSalaryBtn";
            this.EmpSalaryBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmpSalaryBtn.Size = new System.Drawing.Size(189, 55);
            this.EmpSalaryBtn.TabIndex = 2;
            this.EmpSalaryBtn.Text = "          Salary";
            this.EmpSalaryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpSalaryBtn.UseVisualStyleBackColor = true;
            this.EmpSalaryBtn.Click += new System.EventHandler(this.EmpSalaryBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.EmpProfileButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(194, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(788, 52);
            this.panel6.TabIndex = 7;
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
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mainTitle.Location = new System.Drawing.Point(85, 11);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(244, 32);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Employee Dashboard";
            // 
            // tempInfo
            // 
            this.tempInfo.BackColor = System.Drawing.Color.Black;
            this.tempInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempInfo.ForeColor = System.Drawing.Color.White;
            this.tempInfo.Location = new System.Drawing.Point(324, 21);
            this.tempInfo.Multiline = true;
            this.tempInfo.Name = "tempInfo";
            this.tempInfo.ReadOnly = true;
            this.tempInfo.Size = new System.Drawing.Size(282, 21);
            this.tempInfo.TabIndex = 101;
            this.tempInfo.Text = "Login action declined";
            this.tempInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempInfo.Visible = false;
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
            // EmpProfileButton
            // 
            this.EmpProfileButton.BackColor = System.Drawing.Color.Black;
            this.EmpProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmpProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmpProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpProfileButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_administrator_male_48;
            this.EmpProfileButton.Location = new System.Drawing.Point(748, 0);
            this.EmpProfileButton.Name = "EmpProfileButton";
            this.EmpProfileButton.Size = new System.Drawing.Size(40, 52);
            this.EmpProfileButton.TabIndex = 1;
            this.EmpProfileButton.UseVisualStyleBackColor = false;
            this.EmpProfileButton.Click += new System.EventHandler(this.EmpProfileButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EmpManageTaskBtn);
            this.panel4.Location = new System.Drawing.Point(3, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 43);
            this.panel4.TabIndex = 2;
            // 
            // EmpManageTaskBtn
            // 
            this.EmpManageTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpManageTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.EmpManageTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpManageTaskBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpManageTaskBtn.ForeColor = System.Drawing.Color.White;
            this.EmpManageTaskBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_task_25;
            this.EmpManageTaskBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpManageTaskBtn.Location = new System.Drawing.Point(-1, -10);
            this.EmpManageTaskBtn.Name = "EmpManageTaskBtn";
            this.EmpManageTaskBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmpManageTaskBtn.Size = new System.Drawing.Size(189, 56);
            this.EmpManageTaskBtn.TabIndex = 3;
            this.EmpManageTaskBtn.Text = "          View Tasks";
            this.EmpManageTaskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpManageTaskBtn.UseVisualStyleBackColor = true;
            this.EmpManageTaskBtn.Click += new System.EventHandler(this.EmpManageTaskBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EmpSupportBtn);
            this.panel3.Location = new System.Drawing.Point(3, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 37);
            this.panel3.TabIndex = 2;
            // 
            // EmpSupportBtn
            // 
            this.EmpSupportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpSupportBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.EmpSupportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSupportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSupportBtn.ForeColor = System.Drawing.Color.White;
            this.EmpSupportBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_help_26;
            this.EmpSupportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpSupportBtn.Location = new System.Drawing.Point(-1, -15);
            this.EmpSupportBtn.Name = "EmpSupportBtn";
            this.EmpSupportBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmpSupportBtn.Size = new System.Drawing.Size(188, 54);
            this.EmpSupportBtn.TabIndex = 4;
            this.EmpSupportBtn.Text = "          Support/Help";
            this.EmpSupportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpSupportBtn.UseVisualStyleBackColor = true;
            this.EmpSupportBtn.Click += new System.EventHandler(this.EmpSupportBtn_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.EmpSelTicketBtn);
            this.panel14.Location = new System.Drawing.Point(3, 248);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(208, 37);
            this.panel14.TabIndex = 3;
            // 
            // EmpSelTicketBtn
            // 
            this.EmpSelTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpSelTicketBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.EmpSelTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSelTicketBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSelTicketBtn.ForeColor = System.Drawing.Color.White;
            this.EmpSelTicketBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_tickets_25;
            this.EmpSelTicketBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpSelTicketBtn.Location = new System.Drawing.Point(-1, -14);
            this.EmpSelTicketBtn.Name = "EmpSelTicketBtn";
            this.EmpSelTicketBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmpSelTicketBtn.Size = new System.Drawing.Size(188, 54);
            this.EmpSelTicketBtn.TabIndex = 5;
            this.EmpSelTicketBtn.Text = "          Sell Tickets";
            this.EmpSelTicketBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpSelTicketBtn.UseVisualStyleBackColor = true;
            this.EmpSelTicketBtn.Click += new System.EventHandler(this.EmpSelTicketBtn_Click);
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
            this.sideBar.TabIndex = 6;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.EmpLogoutBtn);
            this.panel15.Location = new System.Drawing.Point(3, 291);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(208, 37);
            this.panel15.TabIndex = 3;
            // 
            // EmpLogoutBtn
            // 
            this.EmpLogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpLogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.EmpLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpLogoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLogoutBtn.ForeColor = System.Drawing.Color.White;
            this.EmpLogoutBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_logout_25;
            this.EmpLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpLogoutBtn.Location = new System.Drawing.Point(-1, -14);
            this.EmpLogoutBtn.Name = "EmpLogoutBtn";
            this.EmpLogoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmpLogoutBtn.Size = new System.Drawing.Size(188, 54);
            this.EmpLogoutBtn.TabIndex = 6;
            this.EmpLogoutBtn.Text = "          Log Out";
            this.EmpLogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpLogoutBtn.UseVisualStyleBackColor = true;
            this.EmpLogoutBtn.Click += new System.EventHandler(this.EmpLogoutBtn_Click);
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
            this.centralPanel.TabIndex = 8;
            // 
            // employeeDashoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 449);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.sideBar);
            this.MaximumSize = new System.Drawing.Size(998, 488);
            this.MinimumSize = new System.Drawing.Size(998, 488);
            this.Name = "employeeDashoard";
            this.Text = "employeeDashoard";
            this.Load += new System.EventHandler(this.employeeDashoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Button EmpProfileButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EmpCheckProfileBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button EmpSalaryBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TextBox tempInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button EmpManageTaskBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button EmpSupportBtn;
        private System.Windows.Forms.Button EmpLogoutBtn;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button EmpSelTicketBtn;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.PictureBox reloadButton;
    }
}