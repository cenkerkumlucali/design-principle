using System;
using System.Collections.Generic;
using System.Text;
using SolidPrinciples.DIP.Violation;

namespace SolidPrinciples.DIP.Solution
{
    /* High-level modules, which provide complex logic, should be easily reusable and unaffected by changes in low-level
     modules, which provide utility features. To achieve that, you need to introduce an abstraction that decouples the
     high-level and low-level modules from each other.*/
  
    class Customer
    {
        private ILogger logger;
        // We pass a Logger interface to the customer so it doesn't know what type of logger it is
        public Customer(ILogger logger)
        {
            this.logger = logger;
        }

        public void Add()
        {
            try
            {
                // Add Customer
            }
            catch (Exception error)
            {
                logger.Handle(error.ToString());
            }
        }
    }
}
