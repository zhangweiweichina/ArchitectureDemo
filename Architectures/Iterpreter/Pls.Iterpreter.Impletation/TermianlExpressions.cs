using Pls.Iterpreter.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Iterpreter.Impletation
{
    public class AddExpression : INonTerminalExpression
    {
        public Int32 Level { get { return 0; } }
        public ITerminalExpression Interpret(ITerminalExpression db1, ITerminalExpression db2)
        {
            return new ValueExpression(db1.Value + db2.Value);
        }
    }

    public class SubtractExpression : INonTerminalExpression
    {
        public Int32 Level { get { return 0; } }
        public ITerminalExpression Interpret(ITerminalExpression db1, ITerminalExpression db2)
        {
            return new ValueExpression(db1.Value - db2.Value);
        }
    }

    public class MutliplyExpression : INonTerminalExpression
    {
        public Int32 Level { get { return 1; } }
        public ITerminalExpression Interpret(ITerminalExpression db1, ITerminalExpression db2)
        {
            return new ValueExpression(db1.Value * db2.Value);
        }
    }
    
    public class DivideExpression : INonTerminalExpression
    {
        public Int32 Level { get { return 1; } }
        public ITerminalExpression Interpret(ITerminalExpression db1, ITerminalExpression db2)
        {
            return new ValueExpression(db1.Value / db2.Value);
        }
    }
}
