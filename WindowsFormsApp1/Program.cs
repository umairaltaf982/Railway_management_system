using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AllForms.Admin;
using WindowsFormsApp1.AllForms.Employee;
using WindowsFormsApp1.AllForms.Passenger;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(Dashboard.getDashboard());
            Application.Run(new sellTicketsEmployee());
     }
    }
}
