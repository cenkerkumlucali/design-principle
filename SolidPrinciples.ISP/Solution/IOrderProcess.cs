using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Solution
{
    interface IOrderProcess
    {
        bool ValidateShippingAddress();
        void ProcessOder();

    }
}
