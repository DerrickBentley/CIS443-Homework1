using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Is the HW1 field for Earning YTD 
    /// Must be a number greater than 0, as you can't have negative earnings
    /// </summary>
    class HW1EarnedYTD : InterfaceFieldsGeneric
    {
        public string errorMessage { get; set; }

        private double EarnedYTD { get; set; }

        public string getProperty()
        {
           return Convert.ToString(EarnedYTD);
        }

        public bool isValid()
        {
            if(EarnedYTD < 0)
            {
                errorMessage = "EarningsYTD cannot be negative";
            }
            return errorMessage.Length == 0;
        }

        public void setProperty(string x)
        {
            try
            {
                EarnedYTD = Double.Parse(x);
            }
            catch
            {
                errorMessage = "EarnedYTD is not a valid double";
            }
        }
    }
}
