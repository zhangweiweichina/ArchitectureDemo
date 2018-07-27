using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Visitor.Contract;

namespace Pls.Visitor.Implementation
{
    public class Visitor : IVisitor
    {
        public void Visit(IPart part)
        {
            Console.WriteLine("Visit:" + part.GetType().ToString());
        }
    }
}
