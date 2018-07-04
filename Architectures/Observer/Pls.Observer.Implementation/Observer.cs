using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Observer.Contract;

namespace Pls.Observer.Implementation
{
    public class Observer : IObserver
    {
        public string Name { get; set; }

        public Observer(string strName)
        {
            Name = strName;
        }

        public void Update(ISubject subject)
        {
            Console.WriteLine(subject.Description + " has notified " + Name);
        }
    }
}
