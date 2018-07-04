using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Observer.Contract;

namespace Pls.Observer.Implementation
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public string Description { get; private set; }

        public Subject(string strName)
        {
            Description = strName;
        }

        public void Attach(IObserver ob)
        {
            _observers.Add(ob);
        }

        public void Detach(IObserver ob)
        {
            _observers.Remove(ob);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
