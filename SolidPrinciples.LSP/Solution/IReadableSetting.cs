using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LSP.Solution
{
    interface IReadableSetting
    {
        IReadableSetting GetSetting();
    }
}
