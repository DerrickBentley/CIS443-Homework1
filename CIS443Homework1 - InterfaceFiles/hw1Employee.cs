using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles
{
    /// <summary>
    /// is an individual employee record that a vendor might import.
    /// Has the properties of the imported file, can validate the information
    /// and produce an output record based on our financial calculations
    /// </summary>
    public class hw1Employee
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public double hoursWorked { get; set; }
        public double payRate { get; set; }
        public double earnedYTD { get; set; }
        public int marriageStatus { get; set; }
        public int allowances { get; set; }

        /// <summary>
        /// Checks all the properties to determine if they are valid
        /// </summary>
        /// <returns></returns>
        public List<string> isValid()
        {
            List<string> results = new List<string>();
            if (!isValidName(firstName))
            {
                results.Add("First name must not be blank or spaces");
            }
            if (!isValidName(lastName))
            {
                results.Add("Last name must not be blank or spaces");
            }
            if (!isValidHoursWorked(hoursWorked))
            {
                results.Add("Hours Worked must be between 0 and 60");
            }
            if (!isValidPayRate(payRate))
            {
                results.Add("Pay rate must be greater than 0");
            }
            if (!isValidYTD(earnedYTD))
            {
                results.Add("Earned YTD must be greater or equal to 0");
            }
            if (!isValidMarriageStatus(marriageStatus))
            {
                results.Add("Marriage Status must be a 1 or a 0");
            }
            if (!isValidAllowances(allowances))
            {
                results.Add("Allowances must be between 0 and 20");
            }
            return results;
        }
        /// <summary>
        /// Allowances must be greater or equal to 0
        /// </summary>
        /// <param name="allownaces"></param>
        /// <returns></returns>
        public bool isValidAllowances(int allowances)
        {
            return Validator.isWithinRange(allowances, 0, 20);
        }

        /// <summary>
        /// MarriageStatus must either be a 0 or a 1
        /// </summary>
        /// <param name="marriageStatus"></param>
        /// <returns></returns>
        public bool isValidMarriageStatus(int marriageStatus)
        {
            return marriageStatus == 0 || marriageStatus == 1;
        }

        /// <summary>
        /// returns true if earnedYTD is greater than 0
        /// </summary>
        /// <param name="earnedYTD"></param>
        /// <returns></returns>
        public bool isValidYTD(double earnedYTD)
        {
            return earnedYTD >= 0;
        }

        /// <summary>
        /// returns true if hoursWorked is between 0 and 60
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public bool isValidHoursWorked(double hoursWorked)
        {
            return Validator.isWithinRange(hoursWorked, 0.0, 60.0);
        }

        /// <summary>
        /// Checks to see if payrate is greater than 0
        /// </summary>
        /// <param name="payRate"></param>
        /// <returns></returns>
        public bool isValidPayRate(double payRate)
        {
            return payRate >= 0;
        }

        /// <summary>
        /// Checks if the name field is empty
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public bool isValidName(string Name)
        {
            return !Validator.isEmpty(Name);
        }

        /// <summary>
        /// prints the object back to its original CSV format
        /// </summary>
        /// <returns>the employee in its original form</returns>
        public String getRecord()
        {
            return $"{firstName},{lastName},{hoursWorked},{payRate},{earnedYTD},{marriageStatus},{allowances}";
        }

        /// <summary>
        /// Calculates the employees weekly financial information, and returns the record in CSV format
        /// format is as follows
        /// firstName,lastName,hoursWorked,PayRate,GrossPay,StateTax,FICA,FedWIthholding,NetPay
        /// </summary>
        /// <returns></returns>
        public String getCalculatedRecord()
        {
            Finance myFinances = new Finance();
            Dictionary<String, double> payInfo = myFinances.calculatePayInformation(hoursWorked, payRate, earnedYTD, allowances, marriageStatus);
            return $"{firstName},{lastName},{hoursWorked},{payRate},{payInfo["GrossPay"]},{payInfo["MIStateTax"]},{payInfo["FICATax"]},{payInfo["FedWithholding"]},{payInfo["NetPay"]}";
        }
    }
}
