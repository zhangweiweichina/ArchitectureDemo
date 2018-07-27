using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Strategy.Contract;

namespace Pls.Strategy.Implementation
{
    public class Add : IAlgorithm
    {
        public double Calc(double x, double y)
        {
            return x + y;
        }
    }

    public class Substract : IAlgorithm
    {
        public double Calc(double x, double y)
        {
            return x - y;
        }
    }
    public class Multipy : IAlgorithm
    {
        public double Calc(double x, double y)
        {
            return x * y;
        }
    }
    public class Divide : IAlgorithm
    {
        public double Calc(double x, double y)
        {
            return x / y;
        }
    }
}
