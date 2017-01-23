using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles
{
    /// <summary>
    /// Reads and Writes strings to files
    /// </summary>
    class hw1FileIO
    {

        /// <summary>
        /// Takes a file and populates the fields into an Employee object, and puts it in the list
        /// </summary>
        /// <param name="FileName">is the file to be read with the data</param>
        /// <param name="employees">is the list of employees to be filled</param>
        /// <remarks>
        /// taken from https://msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx
        /// </remarks>
        internal bool fillEmployees(string FileName, ref List<hw1Employee> employees)
        {
            string line;
            // Read the file and display it line by line.
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader($"{FileName}.txt");
                while ((line = file.ReadLine()) != null)
                {
                    String[] lineInfo = line.Split(',');
                    employees.Add(FillEmployee(lineInfo));
                }

                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Generates an employee object given an array of string info
        /// if the field cannot be converted to the objects primitives from a string
        /// they populate with a -1, to fail future validations.
        /// </summary>
        /// <param name="lineInfo">is a split employee record</param>
        /// <returns>a new employee with the fields populated</returns>
        private hw1Employee FillEmployee(string[] lineInfo)
        {
            hw1Employee myEmployee = new hw1Employee();
            myEmployee.firstName = convertString(lineInfo[0]);
            myEmployee.lastName = convertString(lineInfo[1]);
            myEmployee.hoursWorked = convertDouble(lineInfo[2]);
            myEmployee.payRate = convertDouble(lineInfo[3]);
            myEmployee.earnedYTD = convertDouble(lineInfo[4]);
            myEmployee.marriageStatus = convertInt(lineInfo[5]);
            myEmployee.allowances = convertInt(lineInfo[6]);
            return myEmployee;
        }

        /// <summary>
        /// if a conversion to string fails, populate with a -1
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private string convertString(string field)
        {
            try
            {
                return Convert.ToString(field);
            }
            catch
            {
                return "-1";
            }
        }

        /// <summary>
        /// if conversion of doubles fails, populate with a -1
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private double convertDouble(string field){
            try
            {
                return Convert.ToDouble(field);
            }
            catch
            {
                return -1;
            }
        }
        
        /// <summary>
        /// if conversion of integers fails, populate with a -1
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private int convertInt(string field)
        {
            try
            {
                return Convert.ToInt16(field);
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// For a list of employees, check if they are valid, and print them to the corresponding files
        /// </summary>
        /// <param name="validFileName">is the file name for valid records</param>
        /// <param name="invalidFileName">is the file name for invalid records</param>
        /// <param name="employees">is the employee data we are checking</param>
        /// <returns> an int[2] where [0] = number of successful records, and [1] = number of invalid records</returns>
        internal int[] outputEmployees(string validFileName, string invalidFileName, List<hw1Employee> employees)
        {
            int success = 0;
            int error = 0;
           foreach (hw1Employee employee in employees)
            {
                List<string> errors = employee.isValid();
                if (errors.Count == 0)
                {
                    writeOutput(validFileName, employee.getCalculatedRecord());
                    success++;
                }else
                {
                    string myErrors = "";
                    foreach(string singleError in errors)
                    {
                        myErrors += $" ! {singleError}";
                    }
                    writeOutput(invalidFileName, employee.getRecord() + myErrors);
                    error++;
                }
            }
            return new int[2] { success, error };
        }

        /// <summary>
        /// prints a line appended to the given filename
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="employeeRecord"></param>
        private void writeOutput(string fileName, string line)
        {

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true);
            file.WriteLine(line);
            file.Close();
        }
    }
}
