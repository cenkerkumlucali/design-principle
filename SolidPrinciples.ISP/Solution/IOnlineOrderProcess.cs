using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Solution
{
    interface IOnlineOrderProcess
    {
        bool ValidateCardInfo();
    }
}
