using Pls.Iterpreter.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Iterpreter.Impletation
{
    public class EquationExpression : ITerminalExpression
    {
        public static Dictionary<char, Type> _dicExpressions = new Dictionary<char, Type>
        {
            { '+', typeof(AddExpression) },
            { '-', typeof(SubtractExpression) },
            { '*', typeof(MutliplyExpression) },
            { '/', typeof(DivideExpression) }
        };
        private Stack<ITerminalExpression> _stackValues = new Stack<ITerminalExpression>();
        private Stack<INonTerminalExpression> _stackExpressions = new Stack<INonTerminalExpression>();

        public EquationExpression()
        {
        }

        public Int32 InitExpression(string strContent)
        {
            string strValue = string.Empty;
            for (Int32 i = 0; i < strContent.Length; i++)
            {
                if (strContent[i] == '(')
                {
                    EquationExpression equation = new EquationExpression();
                    i += equation.InitExpression(strContent.Substring(i + 1));
                    _stackValues.Push(equation);
                }
                else if (_dicExpressions.ContainsKey(strContent[i]))
                {
                    if (!string.IsNullOrEmpty(strValue))
                    {
                        _stackValues.Push(new ValueExpression(strValue));
                        strValue = string.Empty;
                    }
                    Type type = _dicExpressions[strContent[i]];
                    INonTerminalExpression next = (INonTerminalExpression)Activator.CreateInstance(type);

                    if (_stackExpressions.Count > 0)
                    {
                        INonTerminalExpression top = _stackExpressions.Peek();
                        if (top.Level > next.Level)
                        {
                            ITerminalExpression value1 = _stackValues.Pop();
                            ITerminalExpression value2 = _stackValues.Pop();
                            _stackValues.Push(next.Interpret(value1, value2));
                            _stackExpressions.Pop();
                        }
                    }
                    _stackExpressions.Push(next);
                }
                else if (strContent[i] == ')')
                {
                    _stackValues.Push(new ValueExpression(strValue));
                    strValue = string.Empty;
                    return i + 1;
                }
                else
                {
                    strValue += strContent[i];
                }
            }

            if (!string.IsNullOrEmpty(strValue))
            {
                _stackValues.Push(new ValueExpression(strValue));
                strValue = string.Empty;
            }

            return -1;
        }

        public double Value
        {
            get
            {
                while(_stackExpressions.Count > 0)
                {
                    ITerminalExpression value1 = _stackValues.Pop();
                    ITerminalExpression value2 = _stackValues.Pop();
                    INonTerminalExpression interpret = _stackExpressions.Pop();
                    _stackValues.Push(interpret.Interpret(value1, value2));
                }

                ITerminalExpression value = _stackValues.Pop();
                return value.Value;
            }
            set
            {
            }
        }
    }

    public class ValueExpression : ITerminalExpression
    {
        public ValueExpression(double dbValue)
        {
            Value = dbValue;
        }

        public double Value
        {
            get;set;
        }
    }
}
