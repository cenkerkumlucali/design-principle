using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrinciples.SRP.Solution
{
    //A class should have one, and only one, reason to change.
    //Customer Search has been separated. Therefore, this class do the search only
    class CustomerSearch
    {
        private ICustomerRepository customerRepo;

        public CustomerSearch(ICustomerRepository repo)
        {
            customerRepo = repo;
        }

        public ICustomerRepository SearchById(string searchItem)
        {
            return (ICustomerRepository)customerRepo.Customers.Where(x => x.CustomerId == searchItem);
        }

        public ICustomerRepository SearchByName(string searchItem)
        {
            return (ICustomerRepository)customerRepo.Customers.Where(x => x.CustomerName == searchItem);
        }


    }
}
