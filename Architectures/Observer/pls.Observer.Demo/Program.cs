using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Observer.Contract;
using Pls.Observer.Implementation;

namespace pls.Observer.Demo
{
    class Program
    {
        //观察者模式
        //当一个对象的状态发生变化时，需要通知其他的相关对象
        //用于目标和观察者及观察者之间的解耦
        //C#中的典型应用就是事件和委托
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            ISubject subject = new Subject("Subject");
            subject.Attach(new Pls.Observer.Implementation.Observer("A"));
            subject.Attach(new Pls.Observer.Implementation.Observer("B"));
            subject.Attach(new Pls.Observer.Implementation.Observer("C"));

            subject.Notify();
            Console.ReadKey();
        }
    }
}
