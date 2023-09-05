using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Solution
{
    class OnlineOrderProcess : IOrderProcess, IOnlineOrderProcess
    {
        public void ProcessOder()
        {
            // APPLICABLE
        }

        public bool ValidateCardInfo()
        {
            // APPLICABLE
            return true;
        }

        public bool ValidateShippingAddress()
        {
            // APPLICABLE
            return true;
        }
    }
}
