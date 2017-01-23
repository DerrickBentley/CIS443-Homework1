using CIS443Homework1___InterfaceFiles.InterfaceFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// is the HW1 Specifications for Names. Applies Regular Name logic and
    /// any other qualifying business logic for validation.
    /// </summary>
    class HW1Name : NameObj, InterfaceFieldsGeneric
    {
        public string errorMessage { get; set; }

        /// <summary>
        /// HW1 doesn't specify the name to be a certain number of characters
        /// or any other business logic, so we will only check if its a valid name.
        /// </summary>
        /// <returns>True if the name is a valid name</returns>
        public bool isValid()
        {
            if(IsValidName() == false)
            {
                errorMessage = "Names must contain only characters";
            }
            return IsValidName();
        }

        /// <summary>
        /// Maps the string to the Name of the NameObj Class.
        /// </summary>
        /// <param name="x"></param>
        /// <remarks> 
        /// can this be a Lambda?
        /// setProperty(string x => this.Name = x); ?
        /// </remarks>
        public void setProperty(string x)
        {
            this.Name = x;
        }

        /// <summary>
        /// Returns the Name property of the NameObj Class
        /// </summary>
        /// <returns></returns>
        public string getProperty()
        {
            return this.Name;
        }
    }
}
