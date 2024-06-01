using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class sellTicketsEmployee : Form
    {
        List<Employee> ListCustomer = new List<Employee>();
        public sellTicketsEmployee()
        {
            InitializeComponent();
        }

        private void sellTickets_Load(object sender, EventArgs e)
        {
            Draw100chairs();
        }

        private void Draw100chairs()
        {
            int chair = 1;
            for (int i = 0; i < pnChairs.RowCount; i++)
            {
                for (int j = 0; j < pnChairs.ColumnCount; j++)
                {
                    Label lblchair = new Label();
                    lblchair.Text = chair + "";
                    lblchair.AutoSize = false;
                    lblchair.Dock = DockStyle.Fill;
                    lblchair.TextAlign = ContentAlignment.MiddleCenter;
                    lblchair.BackColor = Color.White;
                    pnChairs.Controls.Add(lblchair, i, j);
                    chair++;

                    lblchair.Click += lblchair_click;
                }
            }
        }

        private void lblchair_click(object sender, EventArgs e)
        {
            Label lblchair = sender as Label;
            if (lblchair.BackColor == Color.White)
            {
                lblchair.BackColor = Color.SkyBlue;
            }
            else if (lblchair.BackColor == Color.SkyBlue)
            {
                lblchair.BackColor = Color.White;
            }
            else if (lblchair.BackColor == Color.YellowGreen)
            {
                MessageBox.Show("The Chair " + lblchair.Text + " is choosen");
            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Employee emp = new Employee();
                emp.NameCustomer = frm.txtCustomerName.Text;
                emp.PhoneCustomer = frm.txtPhoneNumber.Text;
                for (int i = 0; i < pnChairs.Controls.Count; i++)
                {
                    Label lblchair = pnChairs.Controls[i] as Label;
                    if (lblchair.BackColor == Color.SkyBlue)
                    {
                        lblchair.BackColor = Color.YellowGreen;
                        int chair = int.Parse(lblchair.Text);
                        emp.chairs.Add(chair);
                    }
                }
                lblPrice.Text = emp.Price + "USD";
                ListCustomer.Add(emp);
                DisplayTotalMoneySys();
                DisplayCustomerOnListBox();
            }
        }
        private void DisplayTotalMoneySys()
        {
            double sum = 0;
            foreach (Employee emp in ListCustomer)
            {
                sum += emp.Price;
                lblTotalPrice.Text = sum + "USD";
            }
        }
        private void DisplayCustomerOnListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Employee emp in ListCustomer)
            {
                lstCustomers.Items.Add(emp);
            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = lstCustomers.SelectedItem as Employee;
            lblPrice.Text = emp.Price + "USD";
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            Employee emp = lstCustomers.SelectedItem as Employee;
            if (lstCustomers.SelectedIndex != -1)
            {
                for (int i = 0; i < pnChairs.Controls.Count; i++)
                {
                    Label lblchair = pnChairs.Controls[i] as Label;
                    int codeChair = int.Parse(lblchair.Text);
                    int flag = 0;
                    while (emp.chairs.Count > 0 && flag < emp.chairs.Count)
                    {
                        int orderedChair = emp.chairs[0];
                        if (codeChair == orderedChair)
                        {
                            lblchair.BackColor = Color.White;
                            emp.chairs.Remove(orderedChair);
                        }
                        flag++;
                    }
                }
                ListCustomer.Remove(emp);
                DisplayCustomerOnListBox();
                DisplayTotalMoneySys();
            }
            else
            {
                MessageBox.Show("You should select Customer.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Do you want to close the program", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                this.Activate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnChairs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
