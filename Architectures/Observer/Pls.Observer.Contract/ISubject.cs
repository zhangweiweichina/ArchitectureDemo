using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Observer.Contract
{
    public interface ISubject
    {
        string Description { get; }

        void Attach(IObserver ob);

        void Detach(IObserver ob);

        void Notify();
    }
}
