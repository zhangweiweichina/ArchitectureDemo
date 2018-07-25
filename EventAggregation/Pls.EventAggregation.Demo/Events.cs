using Pls.EventAggregation.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.EventAggregation.Demo
{
    public class EventA : PubSubEvent
    {
    }

    public class EventB : PubSubEvent<string>
    {
    }
}
