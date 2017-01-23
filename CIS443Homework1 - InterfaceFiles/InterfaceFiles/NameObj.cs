using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Is a common Name object to hold a first, middle, last, or any other titles
    /// an individual may have.
    /// </summary>
    class NameObj
    {
        /// <summary>
        /// Is the name property the object is storing
        /// </summary>
        protected String Name { get; set; }

        /// <summary>
        /// Is a reference to check if the name contains only Letters,
        /// </summary>
        /// <returns>True of if the name Contains all letters</returns>
        protected Boolean IsValidName()
        {
            return Regex.IsMatch(Name, "([a-zA-Z]*)");
        }
    }
}
