using System;

namespace CIS443Homework1___InterfaceFiles
{
    internal class Validator
    {
        /// <summary>
        /// returns true if a field is empty, null, or blank
        /// </summary>
        /// <param name="field"> is the field we are checking</param>
        /// <returns></returns>
        internal static bool isEmpty(string field)
        {
            return field == "" || field == " " || field == null;
        }

        /// <summary>
        /// checks if a field is between two values
        /// </summary>
        /// <param name="field">is the value we are checking</param>
        /// <param name="min">is the lowest the value can be</param>
        /// <param name="max">is the highest the value can be</param>
        /// <returns></returns>
        internal static bool isWithinRange(int field, int min, int max)
        {
            return field >= min && field <= max;
        }

        /// <summary>
        /// checks if a field is between two values
        /// </summary>
        /// <param name="field">is the value we are checking</param>
        /// <param name="min">is the lowest the value can be</param>
        /// <param name="max">is the highest the value can be</param>
        /// <returns></returns>
        internal static bool isWithinRange(double field, double min, double max)
        {
            return field >= min && field <= max;
        }
    }
}