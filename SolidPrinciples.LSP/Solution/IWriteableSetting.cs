using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LSP.Solution
{
    interface IWriteableSetting
    {
        void SetSetting(string settingName, string settingValue);
    }
}
