using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Bridge.Contract;
using Pls.Bridge.Implement;

namespace Pls.Bridge.Demo
{
    class Program
    {
        public static object IPerson { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            IPerson person = new Person();
            person.Pen = new Pencil();
            person.Color = new ColorRed();
            person.Draw();
        }
    }
}
