using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.EventAggregation.Contract
{
    public interface IEventAggregator
    {
        //
        // Summary:
        //     Gets an instance of an event type.
        //
        // Type parameters:
        //   TEventType:
        //     The type of event to get.
        //
        // Returns:
        //     An instance of an event object of type TEventType.
        TEventType GetEvent<TEventType>() where TEventType : EventBase, new();
    }
}
