using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LSP.Solution
{
    class GuestSetting : IReadableSetting
    {
        public IReadableSetting GetSetting()
        {
            IReadableSetting setting = null;
            return setting;
        }

        // NO WRITE SETTING OPERATION
    }
}
