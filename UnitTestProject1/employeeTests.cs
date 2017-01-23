using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS443Homework1___InterfaceFiles;

namespace UnitTestProject1
{
    /// <summary>
    /// Unit tests for my finance and employee class
    /// </summary>
    /// <remarks>
    /// I would have liked to used Test Cases instead of individual methods
    /// but native MSUnit Testing doesnt support it
    /// This style is taken from http://stackoverflow.com/questions/347535/how-to-rowtest-with-mstest
    /// </remarks>
    [TestClass]
    public class employeeTests
    {
        /// <summary>
        /// Name should check for null, just a space, double quotes ( "" )
        /// others are valid
        /// </summary>
        /// <param name="x"></param>
        /// <param name="expected"></param>
        public void checkName(string x, bool expected)
        {
            hw1Employee myEmployee = new hw1Employee();
            Assert.IsTrue(myEmployee.isValidName(x) == expected);
        }

        /// <summary>
        /// Hours worked should be between 0 and 60
        /// </summary>
        /// <param name="x"></param>
        /// <param name="expected"></param>
        public void checkHoursWorked(double x, bool expected)
        {
            hw1Employee myEmployee = new hw1Employee();
            Assert.IsTrue(myEmployee.isValidHoursWorked(x) == expected);
        }

        /// <summary>
        /// Payrate should not be negative
        /// </summary>
        /// <param name="x"></param>
        /// <param name="expected"></param>
        public void checkPayRate(double x, bool expected)
        {
            hw1Employee myEmployee = new hw1Employee();
            Assert.IsTrue(myEmployee.isValidPayRate(x) == expected);
        }

        /// <summary>
        /// Allowances should be between 0 and 20
        /// </summary>
        /// <param name="x"></param>
        /// <param name="expected"></param>
        public void checkAllowances(int x, bool expected)
        {
            hw1Employee myEmployee = new hw1Employee();
            Assert.IsTrue(myEmployee.isValidAllowances(x) == expected);
        }

        /// <summary>
        /// Marriage status should be either 0 or 1
        /// </summary>
        /// <param name="x"></param>
        /// <param name="expected"></param>
        public void checkMarriageStatus(int x, bool expected)
        {
            hw1Employee myEmployee = new hw1Employee();
            Assert.IsTrue(myEmployee.isValidMarriageStatus(x) == expected);
        }

        /// <summary>
        /// YTD should be not negative
        /// </summary>
        /// <param name="x"></param>
        /// <param name="expected"></param>
        public void checkYTD(double x, bool expected)
        {
            hw1Employee myEmployee = new hw1Employee();
            Assert.IsTrue(myEmployee.isValidYTD(x) == expected);
        }


        [TestMethod]
        public void checkYTDAsNeg()
        {
            checkYTD(-1, false);
        }

        [TestMethod]
        public void checkYTDAsZero()
        {
            checkYTD(0, true);
        }

        [TestMethod]
        public void checkYTDAsHigh()
        {
            checkYTD(50000, true);
        }

        [TestMethod]
        public void checkMarriageAsNeg()
        {
            checkMarriageStatus(-1, false);
        }

        [TestMethod]
        public void checkMarriageAsZero()
        {
            checkMarriageStatus(0, true);
        }

        [TestMethod]
        public void checkMarriageAsOne()
        {
            checkMarriageStatus(1, true);
        }

        [TestMethod]
        public void checkMarriageAsOver()
        {
            checkMarriageStatus(2, false);
        }

        [TestMethod]
        public void checkAllowancesAsNeg()
        {
            checkAllowances(-1, false);
        }

        [TestMethod]
        public void checkAllowancesAsZero()
        {
            checkAllowances(0, true);
        }

        [TestMethod]
        public void checkAllowancesAsStandard()
        {
            checkAllowances(5, true);
        }

        [TestMethod]
        public void checkAllowancesAsMax()
        {
            checkAllowances(20, true);
        }

        [TestMethod]
        public void checkAllowancesAsOver()
        {
            checkAllowances(21, false);
        }

        [TestMethod]
        public void checkPayRateAsNeg()
        {
            checkPayRate(-1, false);
        }

        [TestMethod]
        public void checkPayRateAsZero()
        {
            checkPayRate(0, true);
        }

        [TestMethod]
        public void checkPayRateAsHigh()
        {
            checkPayRate(1500, true);
        }

        [TestMethod]
        public void checkHoursWorkedAsNeg()
        {
            checkHoursWorked(-1, false);
        }

        [TestMethod]
        public void checkHoursWorkedAsZero()
        {
            checkHoursWorked(0, true);
        }

        [TestMethod]
        public void checkHoursWorkedAsStandard()
        {
            checkHoursWorked(40, true);
        }

        [TestMethod]
        public void checkHoursWorkedAsMax()
        {
            checkHoursWorked(60, true);
        }

        [TestMethod]
        public void checkHoursWorkedAsOver()
        {
            checkHoursWorked(60.01, false);
        }

        [TestMethod]
        public void checkNameAsDerrick()
        {
            checkName("Derrick", true);
        }

        [TestMethod]
        public void checkNameasSmall()
        {
            checkName("Bob", true);
        }

        [TestMethod]
        public void checkNameAsLong()
        {
            checkName("ThisismyVeryLongName", true);
        }


        [TestMethod]
        public void checkNameAsEmpty()
        {
            checkName("", false);
        }

        [TestMethod]
        public void checkNameAsSpace()
        {
            checkName(" ", false);
        }

        [TestMethod]
        public void checkNameAsNull()
        {
            checkName(null, false);
        }

    }
}
