using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Strategy.Implementation;

namespace Pls.Strategy.Demo
{
    class Program
    {
        //策略模式
        //数据和处理数据方法的解耦
        //使数据处理方法更灵活的扩展和应用
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            Record record = new Record(4,6);
            record.Algorithm = new Add();
            record.Calc();

            record.Algorithm = new Substract();
            record.Calc();

            record.Algorithm = new Multipy();
            record.Calc();

            record.Algorithm = new Divide();
            record.Calc();
            
            Console.ReadKey();
        }
    }
}
