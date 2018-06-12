using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Pls.Decorator.Contract;

namespace Pls.Decorator.Implementation
{
    public class Internet : IInternet
    {
        private IPhone _phone = null;
        public Internet(IPhone phone)
        {
            _phone = phone;
        }

        public void Surf()
        {
            Console.WriteLine(string.Format("Using <{0}> to surf",_phone.Description));
        }
    }
}
