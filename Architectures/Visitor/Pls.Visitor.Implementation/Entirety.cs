using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Visitor.Contract;

namespace Pls.Visitor.Implementation
{
    public class Entirety
    {
        private List<IPart> _parts = new List<IPart>();

        public void Add(IPart part)
        {
            _parts.Add(part);
        }

        public void Visit(IVisitor visitor)
        {
            foreach (var part in _parts)
            {
                part.Accept(visitor);
            }
        }
    }
}
