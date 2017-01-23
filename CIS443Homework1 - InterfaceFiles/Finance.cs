using System;
using System.Collections.Generic;

namespace CIS443Homework1___InterfaceFiles
{
    /// <summary>
    /// Finance Class contains information regarding calculating taxes and pay 
    /// information.
    /// </summary>
    public class Finance
    {
        private readonly double MEDICARE_TAX_RATE = 0.0145;
        private readonly double MICHIGAN_TAX_RATE = 0.0425;
        private readonly double SS_TAX_LIMIT = 118500;
        private readonly double SS_TAX_RATE = 0.062;
        private readonly double ALLOWANCE_RATE = 67.31;

        public Finance()
        {
        }

        /// <summary>
        /// Calculates the gross pay based on an employees hours worked and their payrate
        /// uses payrate * 1.5 for anything over 40 hours
        /// </summary>
        /// <param name="hoursWorked">is the number of hours worked by an employee</param>
        /// <param name="payRate">is the pay rate of the employee</param>
        /// <returns></returns>
        public double calculateGrossPay(double hoursWorked, double payRate)
        {
            if(hoursWorked <= 40)
            {
                return hoursWorked * payRate;
            }
            else
            {
                // normal rate for first 40, then 1.5 for anything > 40
                return (payRate * 40) + ((payRate * 1.5) * (hoursWorked - 40));
            }
        }

        /// <summary>
        /// Calculates the Michigan State Tax for a gross pay
        /// </summary>
        /// <param name="grossPay"></param>
        /// <returns></returns>
        public double calculateMichiganStateTax(double grossPay)
        {
            return grossPay * MICHIGAN_TAX_RATE;
        }

        /// <summary>
        /// Adds together the Social Security and Medicare Tax for an employee
        /// </summary>
        /// <param name="grossPay"></param>
        /// <param name="earnedYTD"></param>
        /// <returns></returns>
        public double calculateFICATax(double grossPay, double earnedYTD)
        {
            return calculateSocialSecurity(grossPay, earnedYTD) + calculateMedicareTax(grossPay);
        }

        /// <summary>
        /// calculates the Social Security tax for a gross pay
        /// applies tax up to a limit of income a year.
        /// </summary>
        /// <param name="grossPay"></param>
        /// <param name="earnedYTD"></param>
        /// <returns></returns>
        public double calculateSocialSecurity(double grossPay, double earnedYTD)
        {
            double newYTD = grossPay + earnedYTD;
            if (newYTD <= SS_TAX_LIMIT)
            {
                return grossPay * SS_TAX_RATE;
            }
            else
            {
                if(earnedYTD >= SS_TAX_LIMIT)
                {
                    return 0;
                }else
                {
                    return (SS_TAX_LIMIT - earnedYTD) * SS_TAX_RATE;
                }
            }
        }

        /// <summary>
        /// calculates the medicare tax for a gross pay
        /// </summary>
        /// <param name="grossPay"></param>
        /// <returns></returns>
        public double calculateMedicareTax(double grossPay)
        {
            return grossPay * MEDICARE_TAX_RATE;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grossPay"></param>
        /// <param name="numAllowances"></param>
        /// <returns></returns>
        public double calculateFederalWithholding(double grossPay, int numAllowances, int marriageStatus)
        {
            double AWI = calculateAdjustedWeeklyIncome(grossPay, numAllowances);
            if(marriageStatus == 0)
            {
                return CalcFedWithholdingSingle(AWI);
            }
            else
            {
                return CalcFedWithholdingMarried(AWI);
            }
        }

        /// <summary>
        /// Removes the withholding tax from gross pay to get Adjusted Weekly income
        /// </summary>
        /// <param name="grossPay"></param>
        /// <param name="numAllowances"></param>
        /// <returns></returns>
        private double calculateAdjustedWeeklyIncome(double grossPay, int numAllowances)
        {
            double WithholdingTax = numAllowances * ALLOWANCE_RATE;
            return grossPay - WithholdingTax;
        }

        /// <summary>
        /// calculates federal withholding for adjusted income if you are married
        /// </summary>
        /// <param name="awi">is the adjusted income</param>
        public double CalcFedWithholdingMarried(double awi)
        {
            if (awi <= 164)
            {
                return 0;
            }
            else if (Validator.isWithinRange(awi, 165, 521))
            {
                return (awi - 164) * .10;
            }
            else if (Validator.isWithinRange(awi, 522, 1613))
            {
                return 35.70 + ((awi - 521) * .15);
            }
            else if (Validator.isWithinRange(awi, 1614, 3086))
            {
                return 199.50 + ((awi - 1613) * 0.25);
            }
            else if (Validator.isWithinRange(awi, 3087, 4615))
            {
                return 567.75 + ((awi - 3086) * 0.28);
            }
            else if (Validator.isWithinRange(awi, 4616, 8113))
            {
                return 995.87 + ((awi - 4615) * 0.33);
            }
            else if (Validator.isWithinRange(awi, 8114, 9144))
            {
                return 2150.20 + ((awi - 8113) * 0.35);
            }
            else if (awi > 9144)
            {
                return 2511.06 + ((awi - 9144) * 0.396);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// calculates federal withholding for adjusted income if you are single
        /// </summary>
        /// <param name="awi">is the adjusted income</param>
        /// <returns></returns>
        public double CalcFedWithholdingSingle(double awi)
        {
            if (awi <= 43)
            {
                return 0;
            } else if (Validator.isWithinRange(awi, 44, 222))
            {
                return (awi - 43) * .10;
            } else if (Validator.isWithinRange(awi, 223, 767))
            {
                return 17.90 + ((awi - 222) * .15);
            } else if (Validator.isWithinRange(awi, 768, 1796))
            {
                return 99.65 + ((awi - 767) * 0.25);
            } else if (Validator.isWithinRange(awi, 1797, 3700))
            {
                return 356.90 + ((awi - 1796) * 0.28);
            } else if (Validator.isWithinRange(awi, 3701, 7992))
            {
                return 890.22 + ((awi - 3700) * 0.33);
            } else if (Validator.isWithinRange(awi, 7993, 8025))
            {
                return 2306.38 + ((awi - 7992) * 0.35);
            } else if (awi > 8025)
            {
                return 2317.93 + ((awi - 8025) * 0.396);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Given pay information, return a dictionary of pay related information.
        /// Information returned includes:
        /// GrossPay = hours worked * payrate, accounting for overtime
        /// MIStateTax = Michigan State Tax
        /// FICATax = Medicare Tax + Social Security
        /// FedWithholding = Federal Withholding
        /// NetPay = Grosspay - all of the taxes
        /// </summary>
        /// <param name="hoursWorked">is the number of hours an employee worked</param>
        /// <param name="payRate"> is their standard pay rate, or their payrate for the given hours</param>
        /// <param name="earnedYTD"> is the income they've already received this year</param>
        /// <param name="numAllowances"> is the number of allowances an employee is claiming </param>
        /// <param name="marriageStatus"> is 0 for single or 1 for married</param>
        /// <returns></returns>
        public Dictionary<string, double> calculatePayInformation(double hoursWorked, double payRate, double earnedYTD, int numAllowances, int marriageStatus)
        {
            Dictionary<string, double> payInfo = new Dictionary<string, double>();
            double grossPay = calculateGrossPay(hoursWorked, payRate);
            double MITax = calculateMichiganStateTax(grossPay);
            double FICATax = calculateFICATax(grossPay, earnedYTD);
            double FederalWithHolding = calculateFederalWithholding(grossPay, numAllowances, marriageStatus);
            double netPay = grossPay - (MITax + FICATax + FederalWithHolding);

            payInfo.Add("GrossPay", grossPay);
            payInfo.Add("MIStateTax", MITax);
            payInfo.Add("FICATax", FICATax);
            payInfo.Add("FedWithholding", FederalWithHolding);
            payInfo.Add("NetPay", netPay);

            return payInfo;
        }
    }
}