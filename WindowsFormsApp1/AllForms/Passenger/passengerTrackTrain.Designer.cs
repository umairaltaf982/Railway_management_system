namespace WindowsFormsApp1.AllForms.Passenger
{
    partial class passengerTrackTrain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TRAIN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRAIN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANNOUNCEMENTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEST_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVAL_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRAIN_ID,
            this.TRAIN_NAME,
            this.ANNOUNCEMENTS,
            this.DESTINATION,
            this.ARRIVAL,
            this.TYPE,
            this.DEST_TIME,
            this.ARRIVAL_TIME});
            this.dataGridView1.Location = new System.Drawing.Point(35, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(719, 295);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tracking Trains";
            // 
            // TRAIN_ID
            // 
            this.TRAIN_ID.HeaderText = "TRAIN ID";
            this.TRAIN_ID.Name = "TRAIN_ID";
            this.TRAIN_ID.ReadOnly = true;
            // 
            // TRAIN_NAME
            // 
            this.TRAIN_NAME.HeaderText = "TRAIN NAME";
            this.TRAIN_NAME.Name = "TRAIN_NAME";
            this.TRAIN_NAME.ReadOnly = true;
            // 
            // ANNOUNCEMENTS
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ANNOUNCEMENTS.DefaultCellStyle = dataGridViewCellStyle2;
            this.ANNOUNCEMENTS.HeaderText = "STATUS";
            this.ANNOUNCEMENTS.Name = "ANNOUNCEMENTS";
            this.ANNOUNCEMENTS.ReadOnly = true;
            // 
            // DESTINATION
            // 
            this.DESTINATION.HeaderText = "DESTINATION";
            this.DESTINATION.Name = "DESTINATION";
            this.DESTINATION.ReadOnly = true;
            // 
            // ARRIVAL
            // 
            this.ARRIVAL.HeaderText = "DATE";
            this.ARRIVAL.Name = "ARRIVAL";
            this.ARRIVAL.ReadOnly = true;
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "TRAIN TYPE";
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            // 
            // DEST_TIME
            // 
            this.DEST_TIME.HeaderText = "DESTINATION TIME";
            this.DEST_TIME.Name = "DEST_TIME";
            this.DEST_TIME.ReadOnly = true;
            // 
            // ARRIVAL_TIME
            // 
            this.ARRIVAL_TIME.HeaderText = "ARRIVAL TIME";
            this.ARRIVAL_TIME.Name = "ARRIVAL_TIME";
            this.ARRIVAL_TIME.ReadOnly = true;
            // 
            // passengerTrackTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "passengerTrackTrain";
            this.Text = "passengerTrackTrain";
            this.Load += new System.EventHandler(this.passengerTrackTrain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRAIN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRAIN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANNOUNCEMENTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEST_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVAL_TIME;
    }
}