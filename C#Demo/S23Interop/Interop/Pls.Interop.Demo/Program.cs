using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PlsInteropCOMServerLib;

namespace Pls.Interop.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            MyMethodClass method = new MyMethodClass();
            IWelcome welcome = method;

            method.Completed += method_Completed;
            Console.WriteLine(welcome.Greeting("Polaris"));
            Marshal.ReleaseComObject(method);

            try
            {
                Console.WriteLine(welcome.Greeting("Polaris"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            //Type t = Type.GetTypeFromProgID("PlsInteropCOMServerLib.MyMethodClass");
            //dynamic o = Activator.CreateInstance(t);
            //Console.WriteLine(t.ToString());

            Console.ReadKey();
        }

        static void method_Completed()
        {
            Console.WriteLine("method_Completed");
        }
    }
}
