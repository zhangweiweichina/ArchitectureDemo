using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Proxy.Contract;

namespace Pls.Proxy.Implementation
{
    public class MethodWrong : IMethod
    {
        public double Add(double x, double y)
        {
            return x - y;
        }

        public double Substract(double x, double y)
        {
            return x + y;
        }

        public double Multiply(double x, double y)
        {
            return x / y;
        }

        public double Divide(double x, double y)
        {
            return x * y;
        }
    }
}
