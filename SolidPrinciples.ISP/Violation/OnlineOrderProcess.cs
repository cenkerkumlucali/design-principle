using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Violation
{
    class OnlineOrderProcess : IOrderProcess
    {
        public void ProcessOrder(string order)
        {
            // APPLICABLE
        }

        public bool ValidateCardInfo(string cardInfo)
        {
            // APPLICABLE
            return true;
        }

        public bool ValidateShippingAddress(string address)
        {
            // APPLICABLE
            return true;
        }
    }
}
