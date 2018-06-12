using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Proxy.Contract
{
    public interface IMethod
    {
        double Add(double x, double y);
        double Substract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }
}
