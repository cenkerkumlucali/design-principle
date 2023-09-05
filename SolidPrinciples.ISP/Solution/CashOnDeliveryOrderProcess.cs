using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Solution
{
    //Separate ValidateCardInfo for Online Process Order because Card is not necessary for CashonDeliveryOrderProcess
    class CashOnDeliveryOrderProcess : IOrderProcess
    {
        public void ProcessOder()
        {
            // APPLICABLE
        }

        public bool ValidateShippingAddress()
        {
            // APPLICABLE
            return true;
        }
    }
}
