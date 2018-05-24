using Pls.Factory.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Factory.Implementation
{
    public class HwPhone : IHWPhone
    {
        public string Name
        {
            get { return "HuaWei"; }
        }
    }
}
