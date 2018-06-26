using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Iterator.Implementation;

namespace Pls.Iterator.Demo
{
    class Program
    {
        //迭代器 IEnumable/IEnumerator
        //访问一个聚合对象，而不需要暴露其内部
        //为遍历不同的集合提供统一的接口，使得相同的算法适用于不同的集合。
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            PsCollection collection = new PsCollection();
            collection.Add("a");
            collection.Add("b");
            collection.Add("c");
            collection.Add("d");

            foreach (object ob in collection)
            {
                Console.WriteLine(ob.ToString());
            }

            Console.ReadKey();
        }
    }

}
