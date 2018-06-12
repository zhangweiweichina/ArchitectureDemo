using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Decorator.Contract;

namespace Pls.Decorator.Implementation
{
    public class PhoneWithAllFunctions : IPhone, ICamera, IInternet,INavigate
    {
        private IPhone _phone = null;
        private ICamera _camera = null;
        private IInternet _internet = null;
        private INavigate _navigate = null;

        public PhoneWithAllFunctions(IPhone phone)
        {
            _phone = phone;
            _camera = new Camera(phone);
            _internet = new Internet(phone);
            _navigate = new NavigatePhone(phone);
        }
        public string Description
        {
            get { return _phone.Description + " with Camera and Internet and Navigate functions"; }
        }

        public void PhotoGraph()
        {
            _camera.PhotoGraph();
        }

        public void Surf()
        {
            _internet.Surf();
        }

        public void Navigate()
        {
            _navigate.Navigate();
        }
    }
}
