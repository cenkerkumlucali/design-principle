using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LSP.Violation
{
    /* If S is a subtype of T, then objects of type T may be replaced with objects of type S 
     (i.e. an object of type T may be substituted with any object of a subtype S) without altering any
     of the desirable properties of the program (correctness, task performed, etc.)*/

    class GuestSetting : ISetting
    {
        public ISetting GetSetting()
        {
            ISetting setting = null;
            return setting;
        }
        // Violating the Liskov substitution Principle
        public void SetSetting(string settingName, string settingValue)
        {
            // CAN NOT APPLICABLE
            throw new NotImplementedException();
        }
    }
}
