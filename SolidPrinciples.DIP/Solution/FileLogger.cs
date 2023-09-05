using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPrinciples.DIP.Solution
{
    class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
