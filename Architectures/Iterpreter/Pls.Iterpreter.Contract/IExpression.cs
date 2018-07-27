using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Iterpreter.Contract
{
    public interface INonTerminalExpression
    {
        Int32 Level { get; }
        ITerminalExpression Interpret(ITerminalExpression db1, ITerminalExpression db2);
    }
    
    public interface ITerminalExpression
    {
        double Value { get; set; }
    }
}
