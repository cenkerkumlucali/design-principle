using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Violation
{
    interface IOrderProcess
    {
        bool ValidateShippingAddress(string address);
        bool ValidateCardInfo(string cardInfo);
        void ProcessOrder(string order);
    }
}
