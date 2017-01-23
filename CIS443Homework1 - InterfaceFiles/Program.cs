using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS443Homework1___InterfaceFiles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //List<hw1Employee> employees = new List<hw1Employee>();

            //hw1FileIO myIO = new hw1FileIO();
            //myIO.fillEmployees("EmployeeData", ref employees);
            //myIO.outputEmployees($"OutPayroll{DateTime.Now.ToString("yyyyMMdd_hhmmss")}", $"OutPayrollError{DateTime.Now.ToString("yyyyMMdd_hhmmss")}", employees);
        }
    }
}
