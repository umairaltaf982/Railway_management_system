namespace WindowsFormsApp1.AllForms.Employee
{
    partial class viewTaskEmployee
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBoxCompleteTasks = new System.Windows.Forms.ListBox();
            this.btnCompletedTasks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTodoTasks = new System.Windows.Forms.Button();
            this.listBoxTodoTasks = new System.Windows.Forms.ListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Wheat;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "washroom Cleaning",
            "Maintainance",
            "Train Service",
            "sell Tickets"});
            this.checkedListBox1.Location = new System.Drawing.Point(40, 88);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(699, 139);
            this.checkedListBox1.TabIndex = 0;
            // 
            // listBoxCompleteTasks
            // 
            this.listBoxCompleteTasks.BackColor = System.Drawing.Color.Wheat;
            this.listBoxCompleteTasks.FormattingEnabled = true;
            this.listBoxCompleteTasks.Location = new System.Drawing.Point(40, 284);
            this.listBoxCompleteTasks.Name = "listBoxCompleteTasks";
            this.listBoxCompleteTasks.Size = new System.Drawing.Size(307, 95);
            this.listBoxCompleteTasks.TabIndex = 1;
            // 
            // btnCompletedTasks
            // 
            this.btnCompletedTasks.BackColor = System.Drawing.Color.Gold;
            this.btnCompletedTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletedTasks.Location = new System.Drawing.Point(40, 248);
            this.btnCompletedTasks.Name = "btnCompletedTasks";
            this.btnCompletedTasks.Size = new System.Drawing.Size(108, 23);
            this.btnCompletedTasks.TabIndex = 2;
            this.btnCompletedTasks.Text = "Completed Tasks";
            this.btnCompletedTasks.UseVisualStyleBackColor = false;
            this.btnCompletedTasks.Click += new System.EventHandler(this.btnCompletedTasks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "To-do List";
            // 
            // btnTodoTasks
            // 
            this.btnTodoTasks.BackColor = System.Drawing.Color.Gold;
            this.btnTodoTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodoTasks.Location = new System.Drawing.Point(432, 248);
            this.btnTodoTasks.Name = "btnTodoTasks";
            this.btnTodoTasks.Size = new System.Drawing.Size(93, 23);
            this.btnTodoTasks.TabIndex = 6;
            this.btnTodoTasks.Text = "To-do Tasks";
            this.btnTodoTasks.UseVisualStyleBackColor = false;
            this.btnTodoTasks.Click += new System.EventHandler(this.btnTodoTasks_Click);
            // 
            // listBoxTodoTasks
            // 
            this.listBoxTodoTasks.BackColor = System.Drawing.Color.Wheat;
            this.listBoxTodoTasks.FormattingEnabled = true;
            this.listBoxTodoTasks.Location = new System.Drawing.Point(432, 284);
            this.listBoxTodoTasks.Name = "listBoxTodoTasks";
            this.listBoxTodoTasks.Size = new System.Drawing.Size(307, 95);
            this.listBoxTodoTasks.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Gold;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Location = new System.Drawing.Point(666, 57);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(73, 23);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // viewTaskEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.btnTodoTasks);
            this.Controls.Add(this.listBoxTodoTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompletedTasks);
            this.Controls.Add(this.listBoxCompleteTasks);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewTaskEmployee";
            this.Text = "viewTaskEmployee";
            this.Load += new System.EventHandler(this.viewTaskEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBoxCompleteTasks;
        private System.Windows.Forms.Button btnCompletedTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTodoTasks;
        private System.Windows.Forms.ListBox listBoxTodoTasks;
        private System.Windows.Forms.Button submitBtn;
    }
}