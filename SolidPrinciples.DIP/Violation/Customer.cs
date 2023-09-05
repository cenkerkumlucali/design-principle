using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DIP.Violation
{
    // Violating the Dependency inversion Principle. We are relying on the customer to say that we 
    // are using a File Logger, rather than another type of
    // logger, e.g. EmailLogger.
    internal class Customer
    {
        FileLogger logger = new FileLogger();

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
