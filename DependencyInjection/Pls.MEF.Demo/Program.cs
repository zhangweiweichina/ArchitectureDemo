using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.MEF.Demo
{
    class Program
    {

        private static CompositionContainer _container;
        static void Main(string[] args)
        {

            var catalog = new AssemblyCatalog(typeof(Program).Assembly);
            _container = new CompositionContainer(catalog);

            var studentManager = _container.GetExportedValue<MyComponent>();
            
            Console.ReadLine();
        }
    }

    [Export]
    class MyComponent : IPartImportsSatisfiedNotification
    {
        public void OnImportsSatisfied()
        {
            Console.WriteLine("OK!~");
        }
    }
}
