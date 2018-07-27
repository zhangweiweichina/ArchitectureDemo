using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Pointer.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Console.WriteLine(sizeof(MyStruct));
                //Console.WriteLine(sizeof(MyClass));

                MyStruct st = new MyStruct();
                MyStruct* p = &st;
                Console.WriteLine(p->a);

                MyClass c1 = new MyClass();
                fixed (double* pValue = &c1.Value)
                {
                    *pValue = 2.0f;
                }
                Console.WriteLine(c1.Value);


                Int32 * arr = stackalloc Int32[10];

            }


            Console.WriteLine(sizeof(double));
            Console.ReadKey();
        }
    }


    public struct MyStruct
    {
        public Int32 a;
        public Int32 b;
    }

    public class MyClass
    {
        public double Value;
    }
}
