using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Facade.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
        }
    }
}
