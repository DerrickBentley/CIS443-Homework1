using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS443Homework1___InterfaceFiles;


namespace UnitTestProject1
{
    /// <summary>
    /// Tests the Finance Classes methods
    /// </summary>
    [TestClass]
    public class FinanceTests
    {

        /// <summary>
        /// Gross Pay is hours * rate, with 1.5 the rate being applied to hours over 40
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="rate"></param>
        /// <param name="expected"></param>
        public void checkGrossPay(double hours, double rate, double expected)
        {
            Finance myFinance = new Finance();
            Assert.IsTrue(myFinance.calculateGrossPay(hours, rate) == expected);
        }

        /// <summary>
        /// SS Tax is 6.2% up to the first 118500
        /// </summary>
        /// <param name="grossPay"></param>
        /// <param name="YTD"></param>
        /// <param name="expected"></param>
        public void checkSocialSecurity(double grossPay, double YTD, double expected)
        {
            Finance myFinance = new Finance();
            Assert.IsTrue(myFinance.calculateSocialSecurity(grossPay, YTD) == expected);
        }

        /// <summary>
        /// should find the appropriate tax bracket and calculate federal withholding accordingly.
        /// Number of Allowances is going to always be 0, and we'll test calcAdjustedWeeklyIncome separately
        /// </summary>
        /// <param name="grossPay"></param>
        /// <param name="numAllowances"></param>
        /// <param name="marriageStatus"></param>
        /// <param name="expected"></param>
        public void checkFedWithHolding(double grossPay, int numAllowances, int marriageStatus, double expected)
        {
            Finance myFinance = new Finance();
            Assert.IsTrue(Math.Abs(myFinance.calculateFederalWithholding(grossPay, numAllowances, marriageStatus) - expected) < .0001);
        }

        [TestMethod]
        public void checkFedWithholdingZeroPaySingle()
        {
            checkFedWithHolding(0, 0, 0, 0);
        }

        [TestMethod]
        public void checkFedWithholdingZeroPayMarried()
        {
            checkFedWithHolding(0, 0, 1, 0);
        }

        [TestMethod]
        public void checkFedWithholdingFirstBracketMidSingle()
        {
            checkFedWithHolding(20, 0, 0, 0);
        }

        [TestMethod]
        public void checkFedWithholdingFirstBracketMidMarried()
        {
            checkFedWithHolding(100, 0, 1, 0);
        }

        [TestMethod]
        public void checkFedWithholdingFirstBracketMaxSingle()
        {
            checkFedWithHolding(43, 0, 0, 0);
        }

        [TestMethod]
        public void checkFedWithholdingFirstBracketMaxMarried()
        {
            checkFedWithHolding(164, 0, 1, 0);
        }

        [TestMethod]
        public void checkFedWithholdingSecondBracketMinSingle()
        {
            checkFedWithHolding(44, 0, 0, 0.1);
        }

        [TestMethod]
        public void checkFedWithholdingSecondBracketMinMarried()
        {
            checkFedWithHolding(165, 0, 1, 0.1);
        }

        [TestMethod]
        public void checkFedWithholdingSecondBracketMaxSingle()
        {
            checkFedWithHolding(222, 0, 0, 17.9);
        }

        [TestMethod]
        public void checkFedWithholdingSecondBracketMaxMarried()
        {
            checkFedWithHolding(521, 0, 1, 35.70);
        }

        [TestMethod]
        public void checkFedWithholdingThirdBracketMinSingle()
        {
            checkFedWithHolding(768, 0, 0, 99.65 + 0.25);
        }

        [TestMethod]
        public void checkFedWithholdingThirdBracketMinMarried()
        {
            checkFedWithHolding(1614, 0, 1, 199.5 + 0.25);
        }

        [TestMethod]
        public void checkFedWithholdingThirdBracketMaxSingle()
        {
            checkFedWithHolding(1796, 0, 0, 356.9);
        }

        [TestMethod]
        public void checkFedWithholdingThirdBracketMaxMarried()
        {
            checkFedWithHolding(3086, 0, 1, 567.75);
        }

        [TestMethod]
        public void checkFedWithholdingFourthBracketMinSingle()
        {
            checkFedWithHolding(1797, 0, 0, 356.9 + 0.28);
        }

        [TestMethod]
        public void checkFedWithholdingFourthBracketMinMarried()
        {
            checkFedWithHolding(3087, 0, 1, 567.75 + 0.28);
        }

        [TestMethod]
        public void checkFedWithholdingFourthBracketMaxSingle()
        {
            checkFedWithHolding(3700, 0, 0, 890.02);
        }

        [TestMethod]
        public void checkFedWithholdingFourthBracketMaxMarried()
        {
            checkFedWithHolding(4615, 0, 1, 995.87);
        }

        [TestMethod]
        public void checkSocSecZeroPayZeroTotal()
        {
            checkSocialSecurity(0, 0, 0);
        }

        [TestMethod]
        public void checkSocSecRegPayZeroTotal()
        {
            checkSocialSecurity(600, 0, 37.2);
        }

        [TestMethod]
        public void checkSocSecRegPayMaxTotal()
        {
            checkSocialSecurity(600, 118500, 0);
        }

        [TestMethod]
        public void checkSocSecRegPayHalfBefore()
        {
            checkSocialSecurity(600, 118200, 18.6);
        }

        [TestMethod]
        public void checkSocSecRegPayHundredBefore()
        {
            checkSocialSecurity(600, 118400, 6.2);
        }

        [TestMethod]
        public void checkSocSecRegPayFiveHundredBefore()
        {
            checkSocialSecurity(600, 118000, 31);
        }

        [TestMethod]
        public void checkSocSecRegPayOverLimit()
        {
            checkSocialSecurity(600, 119000, 0);
        }

        [TestMethod]
        public void checkGrossPayZeroHours()
        {
            checkGrossPay(0, 40, 0);
        }

        [TestMethod]
        public void checkGrossPayZeroRate()
        {
            checkGrossPay(40, 0, 0);
        }

        [TestMethod]
        public void checkGrossMinHours()
        {
            checkGrossPay(1, 15, 15);
        }

        [TestMethod]
        public void checkGrossMinRates()
        {
            checkGrossPay(15, 1, 15);
        }

        [TestMethod]
        public void checkGrossFortyHours()
        {
            checkGrossPay(40, 1, 40);
        }

        [TestMethod]
        public void checkGrossMinOverTime()
        {
            checkGrossPay(41, 1, 41.5);
        }

        [TestMethod]
        public void checkGrossMaxOverTime()
        {
            checkGrossPay(60, 1, 70);
        }

        [TestMethod]
        public void checkGrossFortyHoursWithRates()
        {
            checkGrossPay(40, 15, 600);
        }

        [TestMethod]
        public void checkGrossMinOverTimeWithRates()
        {
            checkGrossPay(41, 15, 622.5);
        }

        [TestMethod]
        public void checkGrossMaxOverTimeWithRates()
        {
            checkGrossPay(60, 15, 1050);
        }
    }
}
