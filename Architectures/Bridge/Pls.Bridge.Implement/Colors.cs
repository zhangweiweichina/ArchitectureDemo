using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Bridge.Contract;

namespace Pls.Bridge.Implement
{
    public class ColorRed: IColor
    {
        public string Name
        {
            get { return "Red"; }
        }
    }

    public class YellowRed : IColor
    {
        public string Name
        {
            get { return "Yellow"; }
        }
    }
}
