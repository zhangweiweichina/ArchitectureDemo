using Pls.Factory.Contract;
using Pls.Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        //工厂类用于调用者和具体实现对象的解耦
        static void Main(string[] args)
        {
            //Simple Factory
            IPhone phone = SimpleFactory.Create<IMiPhone>();
            Console.WriteLine(phone.Name);

            phone = SimpleFactory.Create<IHWPhone>();
            Console.WriteLine(phone.Name);

            //Factory Method
            FactroyMethodBase method = new MiPhoneFactoryMethod();
            Console.WriteLine(method.CreatePhone().Name);
            
            method = new HwPhoneFactoryMethod();
            Console.WriteLine(method.CreatePhone().Name);

            //Virtual
            VirtualFactoryBase factory = new XiaoMiFactory();
            Console.WriteLine(factory.CreatePhone().Name);
            Console.WriteLine(factory.CreateTV().Name);

            factory = new HWFactory();
            Console.WriteLine(factory.CreatePhone().Name);
            Console.WriteLine(factory.CreateTV().Name);

            Console.ReadKey();
        }
    }
}
