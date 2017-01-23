using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Is the Homework1 Hours Worked field meeting specifications.
    /// Hours are an Int and therefore round.
    /// Valid hours range from 0 to 60
    /// </summary>
    class HW1HoursWorked : InterfaceFieldsGeneric
    {
        /// <summary>
        /// this double is the actual value of the field
        /// </summary>
        private int hoursWorked { get; set; }
        
        private int MAXHOURS = 60;

        public string errorMessage { get; set; }

        public string getProperty()
        {
            return Convert.ToString(hoursWorked);
        }

        /// <summary>
        /// Checks if the HoursWorked field is between 0 and 60
        /// </summary>
        /// <returns>True if the HoursWorked is valid</returns>
        public bool isValid()
        {
            if(hoursWorked < 0)
            {
                errorMessage = "Hours Worked cannot be less than 0";
            }
            if(hoursWorked >= MAXHOURS)
            {
                errorMessage = $"Hours Worked cannot be greater than {MAXHOURS}";
            }
            return hoursWorked >= 0 && hoursWorked <= MAXHOURS && errorMessage.Length == 0; ;
        }

        /// <summary>
        /// Parses the string input into an integer for Hours
        /// </summary>
        /// <param name="x"></param>
        public void setProperty(string x)
        {
            try
            {
                hoursWorked = int.Parse(x);
            }
            catch
            {
                errorMessage = "Hours Worked is not a number";
            }
        }
    }
}
