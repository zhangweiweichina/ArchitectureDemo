using Pls.Iterpreter.Contract;
using Pls.Iterpreter.Impletation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Iterpreter.Demo
{
    class Program
    {
        //解析器
        //SQL 命令是典型的解析器命令
        //用于不同对象之间，通讯接口面临频繁的变化，
        //例如SQL语句的表名，参数名都会发生变化
        //但是类似的模式不断出现，SELECT/INSERT/DELETE/UPDATE模式固定
        //目的是实现通讯接口的扩展性，
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            string strContent = "1+8*(1+(1+2)*3)";

            EquationExpression equation = new EquationExpression();
            equation.InitExpression(strContent);
            Console.WriteLine(equation.Value);

            Console.ReadKey();
        }
    }
}
