using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Strategy.Contract;

namespace Pls.Strategy.Implementation
{
    public class Record
    {
        private double _x;
        private double _y;
        public Record(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public IAlgorithm Algorithm { get; set; }
        public void Calc()
        {
            if(Algorithm != null)
                Console.WriteLine("Result: " + Algorithm.Calc(_x, _y));
        }
    }
}
