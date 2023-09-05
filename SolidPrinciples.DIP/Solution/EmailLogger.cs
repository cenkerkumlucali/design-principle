using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPrinciples.DIP.Solution
{
    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
