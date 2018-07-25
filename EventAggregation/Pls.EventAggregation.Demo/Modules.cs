using Pls.EventAggregation.Contract;
using Pls.EventAggregation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.EventAggregation.Demo
{
    public class ModuleA
    {
        public ModuleA()
        {
            IEventAggregator eventAggregator = EventAggregationFactory.EventAggregator;
            eventAggregator.GetEvent<EventB>().Subscribe(Fun);
        }

        private void Fun(string str)
        {
            Console.WriteLine("Module A:" + str);
        }
    }

    public class ModuleB
    {
        public ModuleB()
        {
            IEventAggregator eventAggregator = EventAggregationFactory.EventAggregator;
            eventAggregator.GetEvent<EventB>().Subscribe(Fun);
        }

        private void Fun(string str)
        {
            Console.WriteLine("Module B:" + str);
        }
    }

    public class ModuleC
    {
        public void Raise()
        {
            IEventAggregator eventAggregator = EventAggregationFactory.EventAggregator;
            eventAggregator.GetEvent<EventB>().Publish("Caller: Module C");
        }
    }
}
