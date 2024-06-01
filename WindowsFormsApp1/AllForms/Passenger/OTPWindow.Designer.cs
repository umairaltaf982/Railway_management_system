namespace WindowsFormsApp1.AllForms.Passenger
{
    partial class OTPWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPWindow));
            this.label9 = new System.Windows.Forms.Label();
            this.OTPVerifyButton = new System.Windows.Forms.Button();
            this.resendOTPLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enterOTPLabel = new System.Windows.Forms.Label();
            this.OTPBox = new System.Windows.Forms.TextBox();
            this.otpStatusBoxIcon = new WindowsFormsApp1.Static_Resources.CustomPictureBox();
            this.customPictureBox1 = new WindowsFormsApp1.Static_Resources.CustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.otpStatusBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(211, -62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Passenger";
            // 
            // OTPVerifyButton
            // 
            this.OTPVerifyButton.BackColor = System.Drawing.Color.Crimson;
            this.OTPVerifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OTPVerifyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OTPVerifyButton.FlatAppearance.BorderSize = 0;
            this.OTPVerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OTPVerifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPVerifyButton.ForeColor = System.Drawing.Color.White;
            this.OTPVerifyButton.Location = new System.Drawing.Point(0, 135);
            this.OTPVerifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.OTPVerifyButton.Name = "OTPVerifyButton";
            this.OTPVerifyButton.Size = new System.Drawing.Size(367, 31);
            this.OTPVerifyButton.TabIndex = 27;
            this.OTPVerifyButton.Text = "Verify OTP";
            this.OTPVerifyButton.UseVisualStyleBackColor = false;
            this.OTPVerifyButton.Click += new System.EventHandler(this.OTPVerifyButton_Click);
            // 
            // resendOTPLabel
            // 
            this.resendOTPLabel.AutoSize = true;
            this.resendOTPLabel.BackColor = System.Drawing.Color.Transparent;
            this.resendOTPLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resendOTPLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendOTPLabel.ForeColor = System.Drawing.Color.DarkKhaki;
            this.resendOTPLabel.Location = new System.Drawing.Point(108, 90);
            this.resendOTPLabel.Name = "resendOTPLabel";
            this.resendOTPLabel.Size = new System.Drawing.Size(84, 17);
            this.resendOTPLabel.TabIndex = 30;
            this.resendOTPLabel.Text = "Resend OTP?";
            this.resendOTPLabel.Click += new System.EventHandler(this.resendOTPLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, -50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 47);
            this.label1.TabIndex = 28;
            this.label1.Text = "SignUp";
            // 
            // enterOTPLabel
            // 
            this.enterOTPLabel.AutoSize = true;
            this.enterOTPLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterOTPLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterOTPLabel.ForeColor = System.Drawing.Color.White;
            this.enterOTPLabel.Location = new System.Drawing.Point(107, 28);
            this.enterOTPLabel.Name = "enterOTPLabel";
            this.enterOTPLabel.Size = new System.Drawing.Size(123, 21);
            this.enterOTPLabel.TabIndex = 33;
            this.enterOTPLabel.Text = "Enter Email OTP";
            // 
            // OTPBox
            // 
            this.OTPBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.OTPBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.OTPBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.OTPBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPBox.ForeColor = System.Drawing.Color.Crimson;
            this.OTPBox.Location = new System.Drawing.Point(111, 52);
            this.OTPBox.Margin = new System.Windows.Forms.Padding(0);
            this.OTPBox.Name = "OTPBox";
            this.OTPBox.Size = new System.Drawing.Size(148, 35);
            this.OTPBox.TabIndex = 0;
            this.OTPBox.WordWrap = false;
            // 
            // otpStatusBoxIcon
            // 
            this.otpStatusBoxIcon.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.otpStatusBoxIcon.BorderColor = System.Drawing.Color.Red;
            this.otpStatusBoxIcon.BorderColor2 = System.Drawing.Color.HotPink;
            this.otpStatusBoxIcon.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.otpStatusBoxIcon.BorderSize = 0;
            this.otpStatusBoxIcon.GradientAngle = 50F;
            this.otpStatusBoxIcon.Image = global::WindowsFormsApp1.Properties.Resources.icons8_verified_account;
            this.otpStatusBoxIcon.Location = new System.Drawing.Point(262, 54);
            this.otpStatusBoxIcon.Name = "otpStatusBoxIcon";
            this.otpStatusBoxIcon.Size = new System.Drawing.Size(33, 33);
            this.otpStatusBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otpStatusBoxIcon.TabIndex = 34;
            this.otpStatusBoxIcon.TabStop = false;
            this.otpStatusBoxIcon.Visible = false;
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
            this.customPictureBox1.Location = new System.Drawing.Point(43, 28);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(58, 58);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPictureBox1.TabIndex = 29;
            this.customPictureBox1.TabStop = false;
            // 
            // OTPWindow
            // 
            this.AcceptButton = this.OTPVerifyButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(367, 166);
            this.Controls.Add(this.otpStatusBoxIcon);
            this.Controls.Add(this.OTPBox);
            this.Controls.Add(this.enterOTPLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.OTPVerifyButton);
            this.Controls.Add(this.resendOTPLabel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 166);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(367, 166);
            this.Name = "OTPWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTPWindow";
            ((System.ComponentModel.ISupportInitialize)(this.otpStatusBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Static_Resources.CustomPictureBox customPictureBox1;
        private System.Windows.Forms.Button OTPVerifyButton;
        private System.Windows.Forms.Label resendOTPLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enterOTPLabel;
        private System.Windows.Forms.TextBox OTPBox;
        private Static_Resources.CustomPictureBox otpStatusBoxIcon;
    }
}