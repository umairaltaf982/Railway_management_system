namespace WindowsFormsApp1.AllForms.Admin
{
    partial class viewTrainAdmin
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trainAnnoucementBox = new System.Windows.Forms.TextBox();
            this.trainEndTimeBox = new System.Windows.Forms.TextBox();
            this.trainStartTimeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.traintypeBox = new System.Windows.Forms.TextBox();
            this.searchtrainButton = new System.Windows.Forms.Button();
            this.trainImageBox = new System.Windows.Forms.PictureBox();
            this.trainArrivalBox = new System.Windows.Forms.TextBox();
            this.trainNamebox = new System.Windows.Forms.TextBox();
            this.trainDestinationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchIdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Arrival Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(298, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Announcements:";
            // 
            // trainAnnoucementBox
            // 
            this.trainAnnoucementBox.Location = new System.Drawing.Point(304, 298);
            this.trainAnnoucementBox.Multiline = true;
            this.trainAnnoucementBox.Name = "trainAnnoucementBox";
            this.trainAnnoucementBox.Size = new System.Drawing.Size(254, 76);
            this.trainAnnoucementBox.TabIndex = 44;
            // 
            // trainEndTimeBox
            // 
            this.trainEndTimeBox.Location = new System.Drawing.Point(400, 182);
            this.trainEndTimeBox.Name = "trainEndTimeBox";
            this.trainEndTimeBox.Size = new System.Drawing.Size(158, 20);
            this.trainEndTimeBox.TabIndex = 43;
            // 
            // trainStartTimeBox
            // 
            this.trainStartTimeBox.Location = new System.Drawing.Point(400, 230);
            this.trainStartTimeBox.Name = "trainStartTimeBox";
            this.trainStartTimeBox.Size = new System.Drawing.Size(158, 20);
            this.trainStartTimeBox.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(300, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 41;
            this.label12.Text = "Dest. Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Destination:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Arrival:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Type:";
            // 
            // traintypeBox
            // 
            this.traintypeBox.Location = new System.Drawing.Point(115, 327);
            this.traintypeBox.Name = "traintypeBox";
            this.traintypeBox.Size = new System.Drawing.Size(158, 20);
            this.traintypeBox.TabIndex = 35;
            // 
            // searchtrainButton
            // 
            this.searchtrainButton.BackColor = System.Drawing.Color.Orange;
            this.searchtrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchtrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtrainButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_25;
            this.searchtrainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchtrainButton.Location = new System.Drawing.Point(361, 128);
            this.searchtrainButton.Name = "searchtrainButton";
            this.searchtrainButton.Size = new System.Drawing.Size(94, 33);
            this.searchtrainButton.TabIndex = 37;
            this.searchtrainButton.Text = "     Search";
            this.searchtrainButton.UseVisualStyleBackColor = false;
            this.searchtrainButton.Click += new System.EventHandler(this.searchtrainButton_Click);
            // 
            // trainImageBox
            // 
            this.trainImageBox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_train_64;
            this.trainImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainImageBox.Location = new System.Drawing.Point(581, 181);
            this.trainImageBox.Name = "trainImageBox";
            this.trainImageBox.Size = new System.Drawing.Size(165, 153);
            this.trainImageBox.TabIndex = 36;
            this.trainImageBox.TabStop = false;
            this.trainImageBox.Click += new System.EventHandler(this.trainImageBox_Click);
            // 
            // trainArrivalBox
            // 
            this.trainArrivalBox.Location = new System.Drawing.Point(115, 278);
            this.trainArrivalBox.Name = "trainArrivalBox";
            this.trainArrivalBox.Size = new System.Drawing.Size(158, 20);
            this.trainArrivalBox.TabIndex = 34;
            // 
            // trainNamebox
            // 
            this.trainNamebox.Location = new System.Drawing.Point(115, 183);
            this.trainNamebox.Name = "trainNamebox";
            this.trainNamebox.Size = new System.Drawing.Size(158, 20);
            this.trainNamebox.TabIndex = 33;
            // 
            // trainDestinationBox
            // 
            this.trainDestinationBox.Location = new System.Drawing.Point(115, 231);
            this.trainDestinationBox.Name = "trainDestinationBox";
            this.trainDestinationBox.Size = new System.Drawing.Size(158, 20);
            this.trainDestinationBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Train Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Enter Train ID";
            // 
            // searchIdBox
            // 
            this.searchIdBox.Location = new System.Drawing.Point(328, 97);
            this.searchIdBox.Name = "searchIdBox";
            this.searchIdBox.Size = new System.Drawing.Size(158, 20);
            this.searchIdBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Search the Trains Here...";
            // 
            // viewTrainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trainAnnoucementBox);
            this.Controls.Add(this.trainEndTimeBox);
            this.Controls.Add(this.trainStartTimeBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.traintypeBox);
            this.Controls.Add(this.searchtrainButton);
            this.Controls.Add(this.trainImageBox);
            this.Controls.Add(this.trainArrivalBox);
            this.Controls.Add(this.trainNamebox);
            this.Controls.Add(this.trainDestinationBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchIdBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewTrainAdmin";
            this.Text = "viewTrainAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.trainImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox trainAnnoucementBox;
        private System.Windows.Forms.TextBox trainEndTimeBox;
        private System.Windows.Forms.TextBox trainStartTimeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox traintypeBox;
        private System.Windows.Forms.Button searchtrainButton;
        private System.Windows.Forms.PictureBox trainImageBox;
        private System.Windows.Forms.TextBox trainArrivalBox;
        private System.Windows.Forms.TextBox trainNamebox;
        private System.Windows.Forms.TextBox trainDestinationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchIdBox;
        private System.Windows.Forms.Label label3;
    }
}