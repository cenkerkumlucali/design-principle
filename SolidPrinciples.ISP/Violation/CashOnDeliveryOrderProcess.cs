using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Violation
{
    // Clients should not be forced to depend upon interfaces that they do not use.
    // Violating the Interface Segregation Principle
    class CashOnDeliveryOrderProcess : IOrderProcess
    {
        public void ProcessOrder(string order)
        {
            // APPLICABLE
        }

        //Cash on Delivery does not support card payment
        public bool ValidateCardInfo(string cardInfo)
        {
            // NOT APPLICABLE
            throw new NotImplementedException();
        }

        public bool ValidateShippingAddress(string address)
        {
            // APPLICABLE
            return true;
        }
    }
}
