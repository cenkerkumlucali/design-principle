using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples.SRP.Solution
{
    interface ICustomerRepository
    {
        IQueryable<Violation.Customer> Customers { get; set; }
    }
}
