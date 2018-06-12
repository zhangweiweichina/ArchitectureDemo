using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Decorator.Contract;

namespace Pls.Decorator.Implementation
{
    public class Phone : IPhone
    {
        public string Description
        {
            get
            {
                return "Normal Phone";
            }
        }
    }
}
