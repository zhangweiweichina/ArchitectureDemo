using Pls.Chain.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Chain.Implementation
{
    public class ChainManager
    {
        private List<IHandler> _handlers = new List<IHandler>();

        public void Add(IHandler handler)
        {
            _handlers.Add(handler);
        }

        public void Handle(double dbvalue)
        {
            foreach(IHandler handler in _handlers)
            {
                handler.Handle(dbvalue);
            }
        }
    }
}
