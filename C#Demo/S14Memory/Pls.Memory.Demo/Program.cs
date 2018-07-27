using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Memory.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            //Method 1
            using (MyClass c1 = new MyClass())
            {
            }

            //Method 2
            MyClass c2 = null;
            try
            {
                c2 = new MyClass();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if(c2!= null)
                    c2.Dispose();
            }

            Test();
            Console.WriteLine("Call GC.Collect");
            GC.Collect();

            Console.ReadKey();
        }

        private static void Test()
        {
            MyClass c3 = new MyClass();
        }
    }


    class MyClass : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);//释放所有的相关资源
            GC.SuppressFinalize(this);//告诉GC,这个对象不需要调用析构函数，直接清理内存即可
        }

        ~MyClass()
        {
            Dispose(false);//只需要非托管资源即可，托管资源交给GC处理
        }

        private bool _bDisposed = false; //资源是否释放
        protected virtual void Dispose(bool bDisposing)
        {
            if (!_bDisposed)
            {
                if (bDisposing)
                {
                    //释放托管对象
                    //调用内部成员变量的Dispose函数
                }
                //释放非托管资源
                Console.WriteLine("Dispose");
            }

            _bDisposed = true;
        }
    }

}
