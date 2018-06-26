using System;
using System.Linq;
using System.Reflection;
using Pls.TemplateMethod.Implementation;

namespace Pls.TemplateMethod.Demo
{
    class Program
    {
        //模板方法类
        //定义了子类必须重写的方法，然后交给不同的人员去实现具体的内容
        private static Int32 Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            DbAccess user = new DbAccessUser();
            user.Run();

            DbAccess group = new DbAccessGroup();
            group.Run();

            Console.ReadKey();
            return 0;
        }
    }
}
