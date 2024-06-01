namespace WindowsFormsApp1
{
    partial class SignUpPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPassenger));
            this.signUpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.alreadyHaveAccount = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passengerNameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.customPictureBox1 = new WindowsFormsApp1.Static_Resources.CustomPictureBox();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotPassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Crimson;
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(60, 379);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(354, 31);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.alreadyHaveAccount);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.passengerNameLabel);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.customPictureBox1);
            this.panel1.Controls.Add(this.cnicBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.phoneNumberBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.forgotPassLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(347, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 450);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // passwordBox
            // 
            this.passwordBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.passwordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.passwordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(60, 319);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '⚫';
            this.passwordBox.Size = new System.Drawing.Size(354, 27);
            this.passwordBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(131, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Passenger";
            // 
            // alreadyHaveAccount
            // 
            this.alreadyHaveAccount.AutoSize = true;
            this.alreadyHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.alreadyHaveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alreadyHaveAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyHaveAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.alreadyHaveAccount.Location = new System.Drawing.Point(229, 349);
            this.alreadyHaveAccount.Name = "alreadyHaveAccount";
            this.alreadyHaveAccount.Size = new System.Drawing.Size(185, 20);
            this.alreadyHaveAccount.TabIndex = 8;
            this.alreadyHaveAccount.Text = "Already have an account?";
            this.alreadyHaveAccount.Click += new System.EventHandler(this.alreadyHaveAccount_Click);
            // 
            // emailBox
            // 
            this.emailBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.emailBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emailBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(59, 213);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(354, 27);
            this.emailBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email";
            // 
            // passengerNameLabel
            // 
            this.passengerNameLabel.AutoSize = true;
            this.passengerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.passengerNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerNameLabel.ForeColor = System.Drawing.Color.White;
            this.passengerNameLabel.Location = new System.Drawing.Point(55, 81);
            this.passengerNameLabel.Name = "passengerNameLabel";
            this.passengerNameLabel.Size = new System.Drawing.Size(53, 21);
            this.passengerNameLabel.TabIndex = 20;
            this.passengerNameLabel.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.NameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(59, 105);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(355, 27);
            this.NameBox.TabIndex = 0;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.customPictureBox1.BorderColor = System.Drawing.Color.Black;
            this.customPictureBox1.BorderColor2 = System.Drawing.Color.Black;
            this.customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.customPictureBox1.BorderSize = 2;
            this.customPictureBox1.GradientAngle = 50F;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(59, 12);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(66, 66);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPictureBox1.TabIndex = 11;
            this.customPictureBox1.TabStop = false;
            // 
            // cnicBox
            // 
            this.cnicBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.cnicBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cnicBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cnicBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicBox.Location = new System.Drawing.Point(60, 267);
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.Size = new System.Drawing.Size(354, 27);
            this.cnicBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "CNIC";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.phoneNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.phoneNumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.phoneNumberBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberBox.Location = new System.Drawing.Point(59, 159);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(354, 27);
            this.phoneNumberBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone Number";
            // 
            // forgotPassLabel
            // 
            this.forgotPassLabel.AutoSize = true;
            this.forgotPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLabel.ForeColor = System.Drawing.Color.Gold;
            this.forgotPassLabel.Location = new System.Drawing.Point(56, 349);
            this.forgotPassLabel.Name = "forgotPassLabel";
            this.forgotPassLabel.Size = new System.Drawing.Size(125, 20);
            this.forgotPassLabel.TabIndex = 7;
            this.forgotPassLabel.Text = "Forgot Password?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "SignUp";
            // 
            // backButton
            // 
            this.backButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::WindowsFormsApp1.Properties.Resources.angle_circle_arrow_left_icon;
            this.backButton.Location = new System.Drawing.Point(12, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 50);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 13;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-37, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpPassenger
            // 
            this.AcceptButton = this.signUpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "SignUpPassenger";
            this.Text = "SignUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUpPassenger_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Panel panel1;
        private Static_Resources.CustomPictureBox customPictureBox1;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forgotPassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label passengerNameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label alreadyHaveAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
    }
}