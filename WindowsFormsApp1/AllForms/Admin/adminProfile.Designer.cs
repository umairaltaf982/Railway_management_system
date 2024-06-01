namespace WindowsFormsApp1.AllForms.Admin
{
    partial class adminProfile
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
            this.label10 = new System.Windows.Forms.Label();
            this.adminAbout = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminEmail = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.adminPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "About:";
            // 
            // adminAbout
            // 
            this.adminAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAbout.Location = new System.Drawing.Point(155, 259);
            this.adminAbout.Multiline = true;
            this.adminAbout.Name = "adminAbout";
            this.adminAbout.Size = new System.Drawing.Size(305, 90);
            this.adminAbout.TabIndex = 42;
            this.adminAbout.Text = "I am a responsible admin of this railway manament system, Hope will continue serv" +
    "ing till my death.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Email:";
            // 
            // adminName
            // 
            this.adminName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName.Location = new System.Drawing.Point(155, 107);
            this.adminName.Multiline = true;
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(305, 31);
            this.adminName.TabIndex = 31;
            this.adminName.Text = "Mr Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Administrator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "My Profile";
            // 
            // adminEmail
            // 
            this.adminEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmail.Location = new System.Drawing.Point(155, 160);
            this.adminEmail.Multiline = true;
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(305, 31);
            this.adminEmail.TabIndex = 44;
            this.adminEmail.Text = "admin@rmsdb.com";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_25;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(640, 297);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 43);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "Logout";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // adminPicture
            // 
            this.adminPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminPicture.Image = global::WindowsFormsApp1.Properties.Resources.icons8_admin_100;
            this.adminPicture.Location = new System.Drawing.Point(551, 99);
            this.adminPicture.Name = "adminPicture";
            this.adminPicture.Size = new System.Drawing.Size(175, 173);
            this.adminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminPicture.TabIndex = 34;
            this.adminPicture.TabStop = false;
            this.adminPicture.Click += new System.EventHandler(this.adminPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_eye_25__1_;
            this.pictureBox1.Location = new System.Drawing.Point(421, 216);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adminPassword
            // 
            this.adminPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassword.Location = new System.Drawing.Point(155, 213);
            this.adminPassword.Margin = new System.Windows.Forms.Padding(0);
            this.adminPassword.Multiline = true;
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.PasswordChar = '*';
            this.adminPassword.Size = new System.Drawing.Size(305, 31);
            this.adminPassword.TabIndex = 72;
            this.adminPassword.Text = "admin@rmsdb.com";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Gold;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_update_25;
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.Location = new System.Drawing.Point(551, 297);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(82, 43);
            this.updateButton.TabIndex = 73;
            this.updateButton.Text = "Update";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Password:";
            // 
            // adminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.adminEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.adminAbout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adminPicture);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminProfile";
            this.Text = "adminCheckProfile";
            this.Load += new System.EventHandler(this.adminProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox adminAbout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox adminPicture;
        private System.Windows.Forms.TextBox adminName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminEmail;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
    }
}