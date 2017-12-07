using System;

namespace Calculator
{
    internal class PayCalculator
    {
        /* have it standalone so it's not directly couples with the calculate tax income
        private TaxTable _taxTable;    TaxTable = class

        public PayCalculator(TaxTable taxTable)
        {
            _taxTable = taxTable;
        }
        */

        internal int calculateGrossIncome(int salary)
        {
            int result = salary / 12;
            return result;
        }

        internal double calculateIncomeTax(double income) // have in a separate class that stores the list of tax bracket = loop through
        {
            
            double result = 0;
            double Income;

            if (18200 > income)
            {
                result = 0;
            }

            else if (18200 < income && income < 37000)
            {
                Income = income - 18200;
                result = 0.19 * Income;
            }
            else if (37000 < income && income < 80000)
            {
                Income = income - 37000;
                result = (0.325 * Income) + 3575;
            }
            else if (80000 < income && income < 180000)
            {
                Income = income - 80000;
                result = (0.37 * Income) + 17547;
            }
            else 
            {
                Income = income - 180000;
                result = (0.45 * Income) + 54547;
            }
            
            return Math.Round(result);
        }

        internal string calculatePayPeriod(string period)
        {
            return period;
            //throw new NotImplementedException();
        }

        internal double calculateNetIncome(double gIncome, double tIncome)
        {
            return Math.Round(gIncome - tIncome);
            //double incomeNet = gIncome - tIncome;
           // return incomeNet;
        }

        internal double calculateSuperRate(double rate, double netIncome)
        {
            //double result = netIncome * (rate / 100);
            return Math.Round(netIncome * (rate / 100));
        }
    }
}