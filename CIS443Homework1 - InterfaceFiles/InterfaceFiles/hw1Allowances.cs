using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Is the HW1 field for number of allowances.
    /// Not sure the actual validation checks for allowances, you can probably go negative?
    /// lets just make sure its an integer.
    /// </summary>
    class HW1Allowances : InterfaceFieldsGeneric
    {
        public string errorMessage { get; set; }

        private int numAllowances { get; set; }

        public string getProperty()
        {
            return Convert.ToString(numAllowances);
        }

        public bool isValid()
        {
            return errorMessage.Length == 0;
        }

        public void setProperty(string x)
        {
            try
            {
                int.Parse(x);
            }
            catch
            {
                errorMessage = "Allowances must be an integer";
            }
        }
    }
}
