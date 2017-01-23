using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Is the HW1 field for Marriage Status. Marriage Status is either just Single or Married.
    /// True being the person is Married, false being they are single.
    /// We're just going to use C#'s default bool.TryParse to deciding whether or not
    /// a field is a valid boolean or not
    /// </summary>
    class HW1MarriageStatus : InterfaceFieldsGeneric
    {

        public string errorMessage { get; set; }

        private Boolean MarriageStatus { get; set; }

        public string getProperty()
        {
            return Convert.ToString(MarriageStatus);
        }

        public bool isValid()
        {
            return errorMessage.Length == 0;
        }

        public void setProperty(string x)
        {
            try
            {
                bool.Parse(x);

            }
            catch
            {
                errorMessage = "Marriage Status is not a valid boolean";
            }
        }
    }
}
