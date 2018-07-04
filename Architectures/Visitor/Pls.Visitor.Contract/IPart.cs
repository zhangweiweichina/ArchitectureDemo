using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Visitor.Contract
{
    public interface IPart
    {
        void Accept(IVisitor vistor);
    }
}
