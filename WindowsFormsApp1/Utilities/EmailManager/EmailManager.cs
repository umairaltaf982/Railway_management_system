using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MailKit.Security;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.Utilities
{
    public class EmailManager
    {
        public bool SendEmail(string recipientAddress, int OTP)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("RMS - Railway Mnagament System", "f223639@cfd.nu.edu.pk"));

            message.To.Add(new MailboxAddress("", recipientAddress));

            message.Subject = "RMS - One Time OTP";

            var bodyBuilder = new BodyBuilder();

            bodyBuilder.HtmlBody = $@"
    <!DOCTYPE html>
    <html>
    <head>
        <title>RMS - One Time OTP</title>
    </head>
    <body>
        <p>Dear User,</p>
        <p>Your One Time Password (OTP) for the Railway Management System is: <b>{OTP}</b></p>
        <p>Please use this OTP to access the system.</p>
        <p>This OTP is valid for a limited time. Please do not share it with anyone.</p>
        <p>Sincerely,</p>
        <p>RMS Team</p>
    </body>
    </html>
  ";

            message.Body = bodyBuilder.ToMessageBody();

            try
            {
                var client = new SmtpClient();

                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate(UserFunctions.testEmail, UserFunctions.testEmailPass);

                client.Send(message);
                client.Disconnect(true);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while sending the email: ";
                if (ex is SmtpCommandException smtpEx)
                {
                    errorMessage += "\nSMTP Error: " + smtpEx.StatusCode;
                    errorMessage += $"|{ex.Message}";
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}

