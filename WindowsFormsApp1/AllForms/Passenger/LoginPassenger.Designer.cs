namespace WindowsFormsApp1
{
    partial class LoginPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPassenger));
            this.passengerLoginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customPictureBox1 = new WindowsFormsApp1.Static_Resources.CustomPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passengerLoginBtn
            // 
            this.passengerLoginBtn.BackColor = System.Drawing.Color.Crimson;
            this.passengerLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passengerLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passengerLoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLoginBtn.ForeColor = System.Drawing.Color.White;
            this.passengerLoginBtn.Location = new System.Drawing.Point(56, 297);
            this.passengerLoginBtn.Name = "passengerLoginBtn";
            this.passengerLoginBtn.Size = new System.Drawing.Size(310, 31);
            this.passengerLoginBtn.TabIndex = 3;
            this.passengerLoginBtn.Text = "Login";
            this.passengerLoginBtn.UseVisualStyleBackColor = false;
            this.passengerLoginBtn.Click += new System.EventHandler(this.passengerLoginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.forgotPassword);
            this.panel1.Controls.Add(this.createAccountButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.customPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passengerLoginBtn);
            this.panel1.Location = new System.Drawing.Point(385, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 449);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword.ForeColor = System.Drawing.Color.Gold;
            this.forgotPassword.Location = new System.Drawing.Point(52, 248);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(125, 20);
            this.forgotPassword.TabIndex = 30;
            this.forgotPassword.Text = "Forgot Password?";
            this.forgotPassword.Click += new System.EventHandler(this.forgotPassword_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.AutoSize = true;
            this.createAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createAccountButton.Location = new System.Drawing.Point(253, 247);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(113, 20);
            this.createAccountButton.TabIndex = 26;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(137, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Passenger";
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.customPictureBox1.BorderColor = System.Drawing.Color.Crimson;
            this.customPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.customPictureBox1.BorderSize = 2;
            this.customPictureBox1.GradientAngle = 50F;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(56, 24);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(69, 69);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPictureBox1.TabIndex = 28;
            this.customPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 47);
            this.label1.TabIndex = 27;
            this.label1.Text = "Login";
            // 
            // passwordBox
            // 
            this.passwordBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.passwordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.passwordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(56, 217);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '⚫';
            this.passwordBox.Size = new System.Drawing.Size(310, 27);
            this.passwordBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.emailBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emailBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(56, 141);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(310, 27);
            this.emailBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::WindowsFormsApp1.Properties.Resources.angle_circle_arrow_left_icon;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 50);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 13;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_eye_25__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(336, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginPassenger
            // 
            this.AcceptButton = this.passengerLoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.a_fast_modern_train_in_motion_at_sunset_a_commercial_transportation_free_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginPassenger";
            this.Text = "LoginPassenger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Static_Resources.CustomPictureBox customPictureBox1;
        private System.Windows.Forms.Button passengerLoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label createAccountButton;
        private System.Windows.Forms.Label forgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}