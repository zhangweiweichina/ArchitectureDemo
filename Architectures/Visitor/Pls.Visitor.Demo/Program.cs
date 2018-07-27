using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Visitor.Implementation;

namespace Pls.Visitor.Demo
{
    class Program
    {
        //访问者模式用于分离数据和处理数据的方法
        //用于数据结构比较稳定，不想通过扩充类来破坏类原有的结构
        //将访问对象传给访问者，让访问者做数据的处理
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            Entirety entirety = new Entirety();
            entirety.Add(new PartA());
            entirety.Add(new PartB());
            entirety.Add(new PartC());

            entirety.Visit(new Implementation.Visitor());

            Console.ReadKey();
        }
    }
}
