using Pls.EventAggregation.Contract;
using Pls.EventAggregation.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.EventAggregation.Factory
{
    public class EventAggregationFactory
    {
        private static IEventAggregator _eventAggregator = null;
        public static IEventAggregator EventAggregator
        {
            get
            {
                if (_eventAggregator == null)
                    _eventAggregator = Activator.CreateInstance(typeof(EventAggregator), true) as IEventAggregator;
                return _eventAggregator;
            }
        }
    }
}
