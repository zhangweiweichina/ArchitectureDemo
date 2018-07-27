using Pls.EventAggregation.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.EventAggregation.Implementation
{
    public class EventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, EventBase> _events = new Dictionary<Type, EventBase>();
        private EventAggregator() { }

        public TEventType GetEvent<TEventType>() where TEventType : EventBase,  new()
        {
            if(_events.ContainsKey(typeof(TEventType)))
            {
                return _events[typeof(TEventType)] as TEventType;
            }
            else
            {
                TEventType e = Activator.CreateInstance<TEventType>();
                _events.Add(typeof(TEventType), e);
                return e;
            }
        }
    }
}
