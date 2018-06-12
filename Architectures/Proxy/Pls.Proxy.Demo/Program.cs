using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Proxy.Implementation;

namespace Pls.Proxy.Demo
{
    class Program
    {
        //1.代理模式用于提供的服务的对象不在本台计算机上，
        //使用实际对象的时候需要复杂的通讯，代理可以封装通讯的过程。
        //2.代理模式还可以使用在不停的切换需要使用的对象时（如下例所示）
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            MethodProxy proxy = new MethodProxy();
            proxy.Method = new Method();
            Console.WriteLine("1 + 2 = " + proxy.Add(1,2) + " is right.");
            proxy.Method = new MethodWrong();
            Console.WriteLine("1 + 2 = " + proxy.Add(1,2) + " is wrong.");
            Console.ReadKey();
        }
    }
}
