using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DIP.Solution
{
    interface ILogger
    {
        void Handle(string error);
    }
}
