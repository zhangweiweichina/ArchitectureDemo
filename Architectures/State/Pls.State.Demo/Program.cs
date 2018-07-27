using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.State.Contract;
using Pls.State.Implementation;

namespace Pls.State.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            Person person = new Person();
            person.Test();

            person.State = PersonState.Drink;
            person.Test();

            person.State = PersonState.Work;
            person.Test();

            Console.ReadKey();
        }
    }
}
