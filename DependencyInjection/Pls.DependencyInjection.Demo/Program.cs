using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using Unity;

namespace Pls.DependencyInjection.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            RegisterInstance(container);

            ServiceLocator.Current.GetInstance<Shell>();

            Console.ReadKey();
        }
        
        private static void RegisterInstance(IUnityContainer container)
        {
            container.RegisterType<IClass,ClassA>();
            IClass cls1 = container.Resolve<IClass>();
            Console.WriteLine(cls1.GetHashCode());
            cls1 = container.Resolve<IClass>();
            Console.WriteLine(cls1.GetHashCode());

            IClass cls2 = new ClassA();
            cls2.Name = "Cls2";
            container.RegisterInstance<IClass>(cls2);

            IClass cls3 = new ClassA();
            cls3.Name = "Cls3";
            container.RegisterInstance< IClass>("Cls3", cls3);

            Console.WriteLine(container.Resolve<IClass>().Name);
            Console.WriteLine(container.Resolve<IClass>("Cls3").Name);
        }
    }

    public interface IClass
    {
        string Name { get; set; }
    }

    public class ClassA : IClass
    {
        public string Name { get; set; }
    }
}
