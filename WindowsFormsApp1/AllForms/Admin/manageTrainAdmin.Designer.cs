namespace WindowsFormsApp1.AllForms.Admin
{
    partial class manageTrainAdmin
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.annBox = new System.Windows.Forms.TextBox();
            this.destTBox = new System.Windows.Forms.TextBox();
            this.arrTBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.trainImageBox = new System.Windows.Forms.PictureBox();
            this.arrBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.destBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.train_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.train_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEST_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVAL_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.announcements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.manageTrainAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageTrainAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Orange;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(272, 160);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(60, 23);
            this.updateBtn.TabIndex = 34;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Orange;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(366, 160);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 23);
            this.deleteBtn.TabIndex = 33;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Orange;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(459, 160);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 23);
            this.button13.TabIndex = 32;
            this.button13.Text = "Clear";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Orange;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(181, 160);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 23);
            this.AddButton.TabIndex = 31;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel13.Controls.Add(this.idBox);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.annBox);
            this.panel13.Controls.Add(this.destTBox);
            this.panel13.Controls.Add(this.arrTBox);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.typeBox);
            this.panel13.Controls.Add(this.trainImageBox);
            this.panel13.Controls.Add(this.arrBox);
            this.panel13.Controls.Add(this.nameBox);
            this.panel13.Controls.Add(this.destBox);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.updateBtn);
            this.panel13.Controls.Add(this.deleteBtn);
            this.panel13.Controls.Add(this.button13);
            this.panel13.Controls.Add(this.AddButton);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(26, 155);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(720, 191);
            this.panel13.TabIndex = 15;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(112, 30);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(158, 20);
            this.idBox.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Train ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 61;
            this.label9.Text = "Arrival Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 60;
            this.label10.Text = "Announcements:";
            // 
            // annBox
            // 
            this.annBox.Location = new System.Drawing.Point(297, 119);
            this.annBox.Multiline = true;
            this.annBox.Name = "annBox";
            this.annBox.Size = new System.Drawing.Size(276, 35);
            this.annBox.TabIndex = 59;
            // 
            // destTBox
            // 
            this.destTBox.Location = new System.Drawing.Point(415, 39);
            this.destTBox.Name = "destTBox";
            this.destTBox.Size = new System.Drawing.Size(158, 20);
            this.destTBox.TabIndex = 58;
            // 
            // arrTBox
            // 
            this.arrTBox.Location = new System.Drawing.Point(415, 72);
            this.arrTBox.Name = "arrTBox";
            this.arrTBox.Size = new System.Drawing.Size(158, 20);
            this.arrTBox.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(295, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Dest. Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Destination:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Arrival:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Type:";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(112, 134);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(158, 20);
            this.typeBox.TabIndex = 51;
            // 
            // trainImageBox
            // 
            this.trainImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainImageBox.Image = global::WindowsFormsApp1.Properties.Resources.icons8_train_64;
            this.trainImageBox.Location = new System.Drawing.Point(593, 33);
            this.trainImageBox.Name = "trainImageBox";
            this.trainImageBox.Size = new System.Drawing.Size(109, 103);
            this.trainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trainImageBox.TabIndex = 52;
            this.trainImageBox.TabStop = false;
            this.trainImageBox.Click += new System.EventHandler(this.trainImageBox_Click);
            // 
            // arrBox
            // 
            this.arrBox.Location = new System.Drawing.Point(112, 108);
            this.arrBox.Name = "arrBox";
            this.arrBox.Size = new System.Drawing.Size(158, 20);
            this.arrBox.TabIndex = 50;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(112, 56);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(158, 20);
            this.nameBox.TabIndex = 49;
            // 
            // destBox
            // 
            this.destBox.Location = new System.Drawing.Point(112, 82);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(158, 20);
            this.destBox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Train Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Train\'s Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.train_id,
            this.train_name,
            this.ARRIVAL,
            this.DEST_TIME,
            this.ARRIVAL_TIME,
            this.DESTINATION,
            this.TYPE,
            this.announcements});
            this.dataGridView1.Location = new System.Drawing.Point(26, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(720, 105);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // train_id
            // 
            this.train_id.HeaderText = "TRAIN ID";
            this.train_id.Name = "train_id";
            this.train_id.ReadOnly = true;
            // 
            // train_name
            // 
            this.train_name.HeaderText = "TRAIN NAME";
            this.train_name.Name = "train_name";
            this.train_name.ReadOnly = true;
            // 
            // ARRIVAL
            // 
            this.ARRIVAL.HeaderText = "DATE";
            this.ARRIVAL.Name = "ARRIVAL";
            this.ARRIVAL.ReadOnly = true;
            // 
            // DEST_TIME
            // 
            this.DEST_TIME.HeaderText = "DEST TIME";
            this.DEST_TIME.Name = "DEST_TIME";
            this.DEST_TIME.ReadOnly = true;
            // 
            // ARRIVAL_TIME
            // 
            this.ARRIVAL_TIME.HeaderText = "ARRIVAL TIME";
            this.ARRIVAL_TIME.Name = "ARRIVAL_TIME";
            this.ARRIVAL_TIME.ReadOnly = true;
            // 
            // DESTINATION
            // 
            this.DESTINATION.HeaderText = "DESTINATION";
            this.DESTINATION.Name = "DESTINATION";
            this.DESTINATION.ReadOnly = true;
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "CLASS";
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            // 
            // announcements
            // 
            this.announcements.HeaderText = "ANNOUNCEMENTS";
            this.announcements.Name = "announcements";
            this.announcements.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 62;
            this.label1.Text = "Trains Data";
            // 
            // manageTrainAdminBindingSource
            // 
            this.manageTrainAdminBindingSource.DataSource = typeof(WindowsFormsApp1.AllForms.Admin.manageTrainAdmin);
            // 
            // manageTrainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageTrainAdmin";
            this.Text = "manageTrainAdmin";
            this.Load += new System.EventHandler(this.manageTrainAdmin_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageTrainAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox annBox;
        private System.Windows.Forms.TextBox destTBox;
        private System.Windows.Forms.TextBox arrTBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.PictureBox trainImageBox;
        private System.Windows.Forms.TextBox arrBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox destBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource manageTrainAdminBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEST_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVAL_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn announcements;
    }
}