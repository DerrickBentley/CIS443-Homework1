using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// Interfaces will contain fields that need to be validated,
    /// be able to produce an error message, and should have a property
    /// </summary>
    /// <remarks>
    /// I'm unsure yet how to make an interface implement a field that could be not
    /// only a generic object, but also primitive data types
    /// </remarks>
    interface InterfaceFieldsGeneric
    {

        /// <summary>
        /// These interfaces will all be text documents
        /// The fields must then have a method to convert from a String
        /// to their appropriate datatypes
        /// </summary>
        /// <param name="x"></param>
        void setProperty(String x);

        /// <summary>
        /// Returns the Property within the field.
        /// </summary>
        /// <returns>The String value to be returned.</returns>
        String getProperty();

        /// <summary>
        /// Returns if the property is valid or not
        /// </summary>
        /// <returns></returns>
        Boolean isValid();

        /// <summary>
        /// Returns an error message if the IsValid propery failed.
        /// </summary>
        String errorMessage { get; set; }


           
    }
}
