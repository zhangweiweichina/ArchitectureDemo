using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Decorator.Implementation;

namespace Pls.Decorator.Demo
{
    class Program
    {
        //装饰模式通过聚合的方式动态的给一个对象增加新的功能
        //也是为了避免过度使用类的继承来扩展类的功能
        //同时也用来解决C++多重继承的问题
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            PhoneWithCameraAndInternet phoneWithCameraAndInternet = new PhoneWithCameraAndInternet(new Phone());
            Console.WriteLine(phoneWithCameraAndInternet.Description);
            phoneWithCameraAndInternet.PhotoGraph();
            phoneWithCameraAndInternet.Surf();

            PhoneWithAllFunctions phoneWithAllFunctions = new PhoneWithAllFunctions(new Phone());
            Console.WriteLine(phoneWithAllFunctions.Description);
            phoneWithAllFunctions.PhotoGraph();
            phoneWithAllFunctions.Surf();
            phoneWithAllFunctions.Navigate();

            Console.ReadKey();
        }
    }
}
