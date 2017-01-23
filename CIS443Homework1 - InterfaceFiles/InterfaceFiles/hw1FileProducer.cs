using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS443Homework1___InterfaceFiles.InterfaceFiles
{
    /// <summary>
    /// This is the class implementing the InterfaceFiles for Homework1
    /// We're receiving a CSV with the information in the following format:
    /// firstName, lastName, hoursWorked, payRate, earnedYTD, marriageStatus, allowances
    /// </summary>
    class hw1FileProducer : InterfaceFilesGeneric
    {
        private HW1Name firstName;
        private HW1Name lastName;
        private HW1HoursWorked hoursWorked;
        private HW1PayRate payRate;
        private HW1EarnedYTD earnedYTD;
        private HW1MarriageStatus marriageStatus;
        private HW1Allowances allowances;

        private InterfaceFieldsGeneric[] rowItems;
        private List<InterfaceFieldsGeneric> inputData;
        
        /// <summary>
        /// HW1 specs says we are receiving a CSV
        /// </summary>
        /// <param name="VendorFile">is the vendors employee information</param>
        /// <returns> a String array of employee information</returns>
        /// <remarks>
        /// Source: http://stackoverflow.com/questions/8644767/convert-a-fileinfo-array-into-a-string-array-c-sharp
        /// DATE FOUND : 01/16/2017
        /// </remarks>
        public void ReadFile(String filePath)
        {
            //String result = "";
            //using (StreamReader sr = VendorFile.OpenText())
            //{
            //    String s = " ";
            //    while((s = sr.ReadLine()) != null)
            //    {
            //        result += s + "\n";
            //    }
            //}
            //return result.Split(',');

            String[] contents = File.ReadAllText(filePath).Split('\n');
            foreach (string line in contents) {

            }
        }

        public void mapAttributes()
        {
            
        }

        public void outputData()
        {
            throw new NotImplementedException();
        }

        public void outputDataErrors()
        {
            throw new NotImplementedException();
        }

        string[] InterfaceFilesGeneric.ReadFile(string RelPath)
        {
            throw new NotImplementedException();
        }
    }
}
