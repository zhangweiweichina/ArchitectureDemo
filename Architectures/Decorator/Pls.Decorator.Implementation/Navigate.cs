using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Decorator.Contract;

namespace Pls.Decorator.Implementation
{
    public class NavigatePhone : INavigate
    {
        private IPhone _phone = null;
        public NavigatePhone(IPhone phone)
        {
            _phone = phone;
        }

        public void Navigate()
        {
            Console.WriteLine(string.Format("Using <{0}> to navigate.", _phone.Description));
        }
    }
}
