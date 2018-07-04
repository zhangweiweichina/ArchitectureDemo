using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Strategy.Contract
{
    public interface IAlgorithm
    {
        double Calc(double x, double y);
    }
}
