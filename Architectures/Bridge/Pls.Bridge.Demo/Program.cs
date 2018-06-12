using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Bridge.Contract;
using Pls.Bridge.Implement;

namespace Pls.Bridge.Demo
{
    //要实现的类有一个或者多个维度的变化时
    //可以将类的功能按照维度拆分，
    //保证原有结构对扩展开发，对修改封闭，不引入额外的复杂度。
    class Program
    {
        public static object IPerson { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            IPerson person = new Person();
            person.Pen = new Pencil();
            person.Color = new ColorRed();
            person.Draw();
        }
    }
}
