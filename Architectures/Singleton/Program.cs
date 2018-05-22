using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        //Singleton require:
        //1. Only one instance in process space.
        //2. Constructor should be protected or private.
        static Int32 Main(string[] args)
        {
            Logger.Instance.WriteLine("Singleton Demo");
            Console.Read();
            LoggerEx.Instance.WriteLine("Singleton Demo");
            Console.Read();
            SingletonBaseHungry<LoggerEx>.Instance.WriteLine("Singleton Hungry Mode Demo");
            Console.Read();
            return 0;
        }
    }
}
