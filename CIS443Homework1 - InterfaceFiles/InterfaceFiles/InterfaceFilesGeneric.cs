using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Because another homework assignment may involve doing the same thing
    /// but with different data and specifications, we're going to make
    /// all of our classes interfaces to be implemented in a generic process
    /// At my work they call taking vendor information and integrating it into our system
    /// or exporting our softwares information into vendor specs "Interface Files"
    /// </summary>
    interface InterfaceFilesGeneric
    {
        /// <summary>
        /// Takes a relative file path and converts it into an array of strings
        /// Examples are uploaded CSV's or XML's
        /// </summary>
        /// <param name="RelPath">is the location of the file to be converted</param>
        /// <returns></returns>
        String[] ReadFile(String RelPath);

        /// <summary>
        /// Method turns the individual elements into their proper class to provide
        /// business logic.
        /// </summary>
        /// <example>
        /// HW1FirstName = New HW1FirstName(data[0]);
        /// HW1LastName = New HW1LastName(data[1]);
        /// </example>
        void mapAttributes();

        /// <summary>
        /// returns the fields back into a file type, such as a CSV or XML
        /// </summary>
        void outputData();

        /// <summary>
        /// returns fields that did not validate correctly back into a file with
        /// some additional information pertaining to the error.
        /// </summary>
        void outputDataErrors();

    }
}
