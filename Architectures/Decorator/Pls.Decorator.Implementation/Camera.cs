using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Decorator.Contract;

namespace Pls.Decorator.Implementation
{
    public class Camera : ICamera
    {
        private IPhone _phone;
        public Camera(IPhone phone)
        {
            _phone = phone;
        }

        public void PhotoGraph()
        {
            Console.WriteLine(string.Format("Using <{0}> to take a photograph", _phone.Description));   
        }
    }
}
