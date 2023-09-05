using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LSP.Violation
{
    interface ISetting
    {
        void SetSetting(string settingName, string settingValue);
        ISetting GetSetting();

    }
}
