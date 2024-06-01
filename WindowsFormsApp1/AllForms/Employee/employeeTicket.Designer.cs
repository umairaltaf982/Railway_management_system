namespace WindowsFormsApp1.AllForms.Employee
{
    partial class employeeTicket
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
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trainBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.train_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(347, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 41;
            this.label10.Text = "Phone No.:";
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Location = new System.Drawing.Point(449, 283);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(199, 27);
            this.phoneBox.TabIndex = 40;
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Location = new System.Drawing.Point(129, 283);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(199, 27);
            this.emailBox.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "Email ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ticket ID:";
            // 
            // ticketBox
            // 
            this.ticketBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ticketBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketBox.Location = new System.Drawing.Point(449, 248);
            this.ticketBox.Multiline = true;
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.ReadOnly = true;
            this.ticketBox.Size = new System.Drawing.Size(199, 27);
            this.ticketBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 30);
            this.label7.TabIndex = 35;
            this.label7.Text = "Cancel Your Ticket";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Gold;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cancelBtn.Location = new System.Drawing.Point(686, 359);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 34;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.BackColor = System.Drawing.Color.Gold;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bookBtn.Location = new System.Drawing.Point(686, 288);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(75, 23);
            this.bookBtn.TabIndex = 33;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Gold;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchBtn.Location = new System.Drawing.Point(686, 206);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 32;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Enter Ticket ID to cancel a Ticket:";
            // 
            // cancelBox
            // 
            this.cancelBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cancelBox.Location = new System.Drawing.Point(330, 355);
            this.cancelBox.Multiline = true;
            this.cancelBox.Name = "cancelBox";
            this.cancelBox.Size = new System.Drawing.Size(247, 27);
            this.cancelBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Train ID:";
            // 
            // trainBox
            // 
            this.trainBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trainBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trainBox.Location = new System.Drawing.Point(129, 249);
            this.trainBox.Multiline = true;
            this.trainBox.Name = "trainBox";
            this.trainBox.Size = new System.Drawing.Size(199, 27);
            this.trainBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Origin";
            // 
            // originBox
            // 
            this.originBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.originBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originBox.Location = new System.Drawing.Point(113, 59);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(187, 20);
            this.originBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Book Your Ticket";
            // 
            // p_phone
            // 
            this.p_phone.HeaderText = "CONTACT";
            this.p_phone.Name = "p_phone";
            this.p_phone.ReadOnly = true;
            // 
            // p_email
            // 
            this.p_email.HeaderText = "EMAIL";
            this.p_email.Name = "p_email";
            this.p_email.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.HeaderText = "DESTINATION";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // origin
            // 
            this.origin.HeaderText = "ORIGIN";
            this.origin.Name = "origin";
            this.origin.ReadOnly = true;
            // 
            // train_id
            // 
            this.train_id.HeaderText = "TRAIN ID";
            this.train_id.Name = "train_id";
            this.train_id.ReadOnly = true;
            // 
            // ticket_id
            // 
            this.ticket_id.HeaderText = "TICKET ID";
            this.ticket_id.Name = "ticket_id";
            this.ticket_id.ReadOnly = true;
            // 
            // destBox
            // 
            this.destBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.destBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destBox.Location = new System.Drawing.Point(553, 59);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(187, 20);
            this.destBox.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticket_id,
            this.train_id,
            this.origin,
            this.destination,
            this.p_email,
            this.p_phone});
            this.dataGridView1.Location = new System.Drawing.Point(28, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 117);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Book Tickets";
            // 
            // employeeTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ticketBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trainBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeTicket";
            this.Text = "employeeTicket";
            this.Load += new System.EventHandler(this.employeeTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ticketBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cancelBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trainBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox originBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_id;
        private System.Windows.Forms.TextBox destBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}