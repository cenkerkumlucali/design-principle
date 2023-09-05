using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPrinciples.DIP.Violation
{
    class FileLogger
    {
        public void Handle(string error)
        {
            File.WriteAllText(@"C:\Error.txt", error);
        }
    }
}
