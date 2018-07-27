using Pls.Chain.Contract;
using Pls.Chain.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Chain.Demo
{
    class Program
    {
        //责任链
        //用于多个处理对象和处理数据的解耦
        //新增加处理对象的时候，只需要添加新的处理对象即可。
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            IHandler leader = new Leader();
            IHandler manager = new Manager();
            IHandler director = new Director();

            //Method B
            ChainManager mgrChain = new ChainManager();
            mgrChain.Add(leader);
            mgrChain.Add(manager);
            mgrChain.Add(director);

            mgrChain.Handle(500);
            mgrChain.Handle(1500);
            mgrChain.Handle(15000);

            //Method A
            leader.Next = manager;
            manager.Next = director;

            leader.Handle(500);
            leader.Handle(1500);
            leader.Handle(15000);

            
            Console.ReadKey();
        }


    }
}
