using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Composite.Contract;
using Pls.Composite.Implementation;

namespace Pls.Composite.Demo
{
    class Program
    {
        //组合又叫部分-整体结构，
        //他模糊了复杂的元素，使复杂的元素可以像简单元素一样被使用者调用
        //他实现了客户程序和各个元素之间内部结构的解耦
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            IPainter painter = new Painter();
            painter.Items.Add(new Cycle());
            painter.Items.Add(new Line());

            painter.Draw();

            Console.ReadKey();
        }
    }
}
