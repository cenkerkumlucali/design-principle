using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OCP.Solution
{
    //Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.
    class TaxCalculator
    {
        //If a new country has been added we don't have to modify this class
        public decimal Calculate(ICountryTaxCalculator obj)
        {
            decimal taxAmount = obj.CalculateTaxAmount();
            // TODO: Opererations if necessary
            return taxAmount;
        }
    }
}
