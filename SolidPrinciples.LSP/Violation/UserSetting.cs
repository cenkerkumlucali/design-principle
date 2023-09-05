using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LSP.Violation
{
    class UserSetting : ISetting
    {

        public ISetting GetSetting()
        {
            ISetting setting = null;
            return setting;
        }

        public void SetSetting(string settingName, string settingValue)
        {
            ISetting newSetting = null;
            // Set settings based on given parameters
        }
    }
}
