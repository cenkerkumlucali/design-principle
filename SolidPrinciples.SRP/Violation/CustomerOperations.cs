using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples.SRP.Violation
{
    // Violating the Single Responsibility Principle
    class CustomerOperations
    {
        private ICustomerRepository customerRepo;

        public CustomerOperations(ICustomerRepository repo)
        {
            customerRepo = repo;
        }

        //Search and Export feature shouldn't be done in the same class
        public ICustomerRepository SearchById(string searchItem)
        {
            return (ICustomerRepository)customerRepo.Customers.Where(x => x.CustomerId == searchItem);
        }

        public ICustomerRepository SearchByName(string searchItem)
        {
            return (ICustomerRepository)customerRepo.Customers.Where(x => x.CustomerName == searchItem);
        }

        public void ExportToCsv()
        {
            // TODO: Export operations
        }

        public void ExportToPdf()
        {
            // TODO: Export operations
        }
    }
}
