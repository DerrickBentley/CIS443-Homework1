using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS443Homework1___InterfaceFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultPanel.Visible = false;
            lblSuccessCount.Text = "No Records Processed";
            lblSuccessFile.Text = "No Records Processed";
            lblErrorCount.Text = "No Records Processed";
            lblErrorFile.Text = "No Records Processed";
            fxtFileName1.Text = "EmployeeData";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultPanel.Visible = true;
            String currTime = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string outputFile = $"OutPayroll{currTime}";
            string outputErrorFile = $"OutPayrollError{currTime}";


            List<hw1Employee> employees = new List<hw1Employee>();
            hw1FileIO myIO = new hw1FileIO();
            myIO.fillEmployees(fxtFileName1.Text, ref employees);
            int[] results = myIO.outputEmployees(outputFile, outputErrorFile, employees);
            if (results[0] > 0 || results[1] > 0)
            {
                lblSuccessCount.Text = Convert.ToString(results[0]);
                lblSuccessFile.Text = outputFile;
                lblErrorCount.Text = Convert.ToString(results[1]); ;
                lblErrorFile.Text = outputErrorFile;
            } else
            {
                lblSuccessCount.Text = "No Records Processed";
                lblSuccessFile.Text = "No Records Processed";
                lblErrorCount.Text = "No Records Processed";
                lblErrorFile.Text = "No Records Processed";
            }
        }
    }
}
