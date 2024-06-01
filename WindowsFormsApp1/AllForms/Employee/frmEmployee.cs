using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCustomerName, "");
            if(txtCustomerName.Text == "")
            {
                errorProvider.SetError(txtCustomerName, "You should enter customer name.");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
