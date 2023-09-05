using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.SRP.Solution
{
    //A class should have one, and only one, reason to change.
    //Customer Exports have been separated. Therefore, this class is for export feature only
    class CustomerExports
    {
        public void ExportToCsv()
        {
            // TODO: Export operations
        }

        public void ExportToPdf()
        {
            // TODO: Export operations
        }
    }
}
