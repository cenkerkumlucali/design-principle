using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OCP.Violation
{
    // Violating the Open Closed Principle
    class TaxCalculator
    {
        //The problem is if we add a new country then we need to go and add one more Case statement in the “Calculate” function,
        //in other words we need to change the taxCalculator class.
        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            decimal taxAmount = 0;
            decimal taxableIncome = income - deduction;

            
            switch (country)
            {
                case "Bangladeseh":
                    // TODO: Calculate
                    break;
                case "India":
                    // TODO: Calculate
                    break;
                case "UK":
                    // TODO: Calculate
                    break;
            }

            return taxAmount;
        }
    }
}
