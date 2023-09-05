using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OCP.Solution
{
    interface ICountryTaxCalculator
    {
        decimal TotalIncome { get; set; }
        decimal TotalDeduction { get; set; }
        string Country { get; set; }
        decimal CalculateTaxAmount();
    }
}
