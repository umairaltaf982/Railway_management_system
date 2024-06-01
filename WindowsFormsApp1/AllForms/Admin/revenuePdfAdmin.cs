using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Admin
{
    public partial class revenuePdfAdmin : Form
    {
        public revenuePdfAdmin()
        {
            InitializeComponent();
        }

        private void DownloadPDFButton_Click(object sender, EventArgs e)
        {
            decimal totalRevenue = CalculateTotalRevenue();
            int totalEmployees = GetTotalEmployees();
            int totalPassengers = GetTotalPassengers();

            Document document = new Document();
            try
            {
                string outputPath = "TotalRevenueReport.pdf";

                PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

                document.Open();

                document.Add(new Paragraph("Total Revenue Report"));
                document.Add(new Paragraph($"Total Revenue: ${totalRevenue}"));
                document.Add(new Paragraph($"Total Employees: {totalEmployees}"));
                document.Add(new Paragraph($"Total Passengers: {totalPassengers}"));

                MessageBox.Show("PDF report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(outputPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document.Close();
            }
        }

        private decimal CalculateTotalRevenue()
        {
            decimal totalTicketPrice = 0;
            decimal totalEmployeeSalary = 0;

            string ticketPriceQuery = "SELECT SUM(ticket_price) FROM ticket";

            string employeeSalaryQuery = "SELECT SUM(e_salary) FROM Employee";

            string conStr = UserFunctions.connectionString;

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(ticketPriceQuery, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalTicketPrice = Convert.ToDecimal(result);
                        }
                    }

                    using (OracleCommand cmd = new OracleCommand(employeeSalaryQuery, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalEmployeeSalary = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total revenue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalTicketPrice - totalEmployeeSalary;
        }

        private int GetTotalEmployees()
        {
            int totalEmployees = 0;

            string employeeCountQuery = "SELECT COUNT(*) FROM Employee";

            string conStr = UserFunctions.connectionString;

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(employeeCountQuery, connection))
                    {
                        totalEmployees = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalEmployees;
        }

        private int GetTotalPassengers()
        {
            int totalPassengers = 0;

            string passengerCountQuery = "SELECT COUNT(*) FROM ticket";

            string conStr = UserFunctions.connectionString;

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(passengerCountQuery, connection))
                    {
                        totalPassengers = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total passengers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalPassengers;
        }
    }
}
