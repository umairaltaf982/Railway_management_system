using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Static_Resources
{
    public class UserFunctions
    {
        //MEMEBERS
        public static readonly string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID = rmsdb; PASSWORD = rmsdb";
        public static readonly string testEmail = "umairaltaf982@gmail.com";
        public static readonly string testEmailPass = "Enter your Password";
        //Apply Transparency to any panel
        public static void Apply_Panel1_Transparency(Panel panel1)
        {
            int opacity = 50;
            panel1.BackColor = Color.FromArgb(opacity, panel1.BackColor);
            
        }
        //SignUp Validator
        public static bool ValidateUserInput(string email, string phoneNumber, string cnic, string name, Form parentForm)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(parentForm, "Email cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show(parentForm, "Invalid email format. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show(parentForm, "Phone number cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show(parentForm, "Invalid phone number format. Please enter a valid Pakistani phone number (e.g., 03XXXXXXXXX).", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cnic))
            {
                MessageBox.Show(parentForm, "CNIC cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidCnic(cnic))
            {
                MessageBox.Show(parentForm, "Invalid CNIC format. Please enter a valid 13-digit CNIC number.", "Invalid CNIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(parentForm, "Name cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // All validations passed
            return true;
        }

        private static bool IsValidEmail(string email)
        {
            // Use the previous function from the previous response
            var regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w{2,4}$");
            return regex.IsMatch(email);
        }

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Assuming Pakistani phone number format (03XXXXXXXXX)
            return Regex.IsMatch(phoneNumber, @"^03\d{9}$");
        }

        private static bool IsValidCnic(string cnic)
        {
            // Check for 13 digits and numeric characters only
            return cnic.Length == 13 && Regex.IsMatch(cnic, @"^\d+$");
        }


    }
}
