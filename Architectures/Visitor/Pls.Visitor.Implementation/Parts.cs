using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Visitor.Contract;

namespace Pls.Visitor.Implementation
{
    public abstract class Part : IPart
    {
        public void Accept(IVisitor vistor)
        {
            vistor.Visit(this);
        }
    }

    public class PartA : Part
    {
    }

    public class PartB : Part
    {
    }

    public class PartC : Part
    {
    }
}
