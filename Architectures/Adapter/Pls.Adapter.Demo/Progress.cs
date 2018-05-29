using Pls.Adapter.Contact;
using Pls.Adapter.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Adapter.Demo
{
    public class Progress
    {
        //适配器设计模式有两种实现方式： 对象适配器和类适配器。
        //适配器的目的是为了让对象有指定的接口。
        //主要用于要求对现存（老）的对象有新的（接口）要求，使一些不兼容的类可以一起工作。
        //类适配器是通过类派生实现。
        //对象适配器通过聚合和组合实现。
        static Int32 Main()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            ITelescope clsAdapter = new ClsAdapter();
            Console.WriteLine(clsAdapter.Look());

            ITelescope obAdapter = new ObAdapter();
            Console.WriteLine(obAdapter.Look());

            Ancient ancient = new Ancient();
            obAdapter = new ObAdapter(ancient);
            ancient.DisplayName = "Aggregation";
            Console.WriteLine(obAdapter.Look());

            Console.ReadKey();
            return 0;
        }
    }
}
