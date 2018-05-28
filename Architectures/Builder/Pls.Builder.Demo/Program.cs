using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Builder.Contact;
using Pls.Builder.Factory;

namespace Pls.Builder.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            IDirector director = BuilderFactory.Create<IDirector>();
            IBuilder intelBuilder = BuilderFactory.Create<IIntelBuilder>();
            IBuilder amdBuilder = BuilderFactory.Create<IAMDBuilder>();

            INoteBook nbIntel = director.BuildNoteBook(intelBuilder);
            INoteBook nbAMD = director.BuildNoteBook(amdBuilder);

            Console.WriteLine("--------------");
            nbIntel.Display();
            Console.WriteLine("--------------");
            nbAMD.Display();

            Console.ReadKey();
        }
    }
}
