namespace WindowsFormsApp1.AllForms.Admin
{
    partial class manageProfileEmployee
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.employeePicture = new System.Windows.Forms.PictureBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.e_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_EMAIL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel13.Controls.Add(this.salaryBox);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Controls.Add(this.updateBtn);
            this.panel13.Controls.Add(this.deleteBtn);
            this.panel13.Controls.Add(this.clearBtn);
            this.panel13.Controls.Add(this.addBtn);
            this.panel13.Controls.Add(this.employeePicture);
            this.panel13.Controls.Add(this.typeBox);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.nameBox);
            this.panel13.Controls.Add(this.passwordBox);
            this.panel13.Controls.Add(this.idBox);
            this.panel13.Controls.Add(this.emailBox);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(28, 166);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(716, 180);
            this.panel13.TabIndex = 11;
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(402, 110);
            this.salaryBox.Multiline = true;
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(158, 19);
            this.salaryBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Salary:";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Orange;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(273, 148);
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
            this.deleteBtn.Location = new System.Drawing.Point(366, 148);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 23);
            this.deleteBtn.TabIndex = 33;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Orange;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(459, 148);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(60, 23);
            this.clearBtn.TabIndex = 32;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Orange;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(181, 148);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(60, 23);
            this.addBtn.TabIndex = 31;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // employeePicture
            // 
            this.employeePicture.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_administrator_male_48;
            this.employeePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeePicture.Location = new System.Drawing.Point(586, 40);
            this.employeePicture.Name = "employeePicture";
            this.employeePicture.Size = new System.Drawing.Size(109, 103);
            this.employeePicture.TabIndex = 30;
            this.employeePicture.TabStop = false;
            this.employeePicture.Click += new System.EventHandler(this.employeePicture_Click);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(402, 82);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(158, 19);
            this.typeBox.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(335, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(402, 52);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(158, 20);
            this.nameBox.TabIndex = 22;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(154, 109);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(158, 20);
            this.passwordBox.TabIndex = 21;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(154, 50);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(158, 20);
            this.idBox.TabIndex = 20;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(154, 80);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(158, 20);
            this.emailBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee\'s Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.e_id,
            this.e_name,
            this.E_EMAIL_ID,
            this.E_PASSWORD,
            this.e_salary,
            this.E_TYPE});
            this.dataGridView1.Location = new System.Drawing.Point(29, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // e_id
            // 
            this.e_id.HeaderText = "ID";
            this.e_id.Name = "e_id";
            this.e_id.ReadOnly = true;
            // 
            // e_name
            // 
            this.e_name.HeaderText = "Username";
            this.e_name.Name = "e_name";
            this.e_name.ReadOnly = true;
            // 
            // E_EMAIL_ID
            // 
            this.E_EMAIL_ID.HeaderText = "EMAIL ID";
            this.E_EMAIL_ID.Name = "E_EMAIL_ID";
            this.E_EMAIL_ID.ReadOnly = true;
            // 
            // E_PASSWORD
            // 
            this.E_PASSWORD.HeaderText = "PASSWORD";
            this.E_PASSWORD.Name = "E_PASSWORD";
            this.E_PASSWORD.ReadOnly = true;
            // 
            // e_salary
            // 
            this.e_salary.HeaderText = "SALARY";
            this.e_salary.Name = "e_salary";
            this.e_salary.ReadOnly = true;
            // 
            // E_TYPE
            // 
            this.E_TYPE.HeaderText = "TYPE";
            this.E_TYPE.Name = "E_TYPE";
            this.E_TYPE.ReadOnly = true;
            // 
            // manageProfileEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageProfileEmployee";
            this.Text = "manageProfileAdmin";
            this.Load += new System.EventHandler(this.manageProfileEmployee_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox employeePicture;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_EMAIL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_TYPE;
    }
}