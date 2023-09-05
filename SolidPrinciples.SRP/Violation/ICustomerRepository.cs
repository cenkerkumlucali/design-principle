using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples.SRP.Violation
{
    interface ICustomerRepository
    {
        IQueryable<Customer> Customers { get; set; }
    }
}
