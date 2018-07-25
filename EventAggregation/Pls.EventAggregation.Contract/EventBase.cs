using Pls.EventAggregation.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.EventAggregation.Contract
{
    public class EventBase
    {
    }

    public class PubSubEvent<T> : EventBase
    {
        protected event Action<T> subEvent;
        public void Publish(T t)
        {
            if (subEvent != null)
                subEvent(t);
        }

        public void Subscribe(Action<T> action)
        {
            subEvent += action;
        }

        public void Unsubscribe(Action<T> action)
        {
            subEvent -= action;
        }
    }

    public class PubSubEvent : EventBase
    {
        protected event Action subEvent;
        public void Publish()
        {
            if (subEvent != null)
                subEvent();
        }

        public void Subscribe(Action action)
        {
            subEvent += action;
        }

        public void Unsubscribe(Action action)
        {
            subEvent -= action;
        }
    }
}
