using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Is the field to meet the HW1 specification for Payrates
    /// must not be negative, must be a valid Double.
    /// </summary>
    class HW1PayRate : InterfaceFieldsGeneric
    {
        public string errorMessage { get; set; }

        private double payRate { get; set; }

        public string getProperty()
        {
           return Convert.ToString(payRate);
        }

        /// <summary>
        /// Pay rate must not be negative 
        /// </summary>
        /// <returns></returns>
        public bool isValid()
        {
            if(payRate < 0)
            {
                errorMessage = "Pay Rate cannot be a negative";
            }
            //should be invalid regardless of where error comes from
            return errorMessage.Length == 0;
        }

        public void setProperty(string x)
        {
            try
            {
                payRate = Double.Parse(x);
            }
            catch
            {
                errorMessage = "Pay Rate must be a double";
            }
        }
    }
}
