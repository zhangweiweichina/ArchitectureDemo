using Pls.Adapter.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Adapter.Implementation
{
    public class ClsAdapter : Ancient, ITelescope
    {
        public string Look()
        {
            return "Class Adapter Model :" + DisplayName;
        }
    }

    public class ObAdapter : ITelescope
    {
        private Ancient _ancient;

        public ObAdapter() : this(null)
        {
        }

        public ObAdapter(Ancient ancient)
        {
            if (ancient == null)
                _ancient = new Ancient();//Composition
            else
                _ancient = ancient;     //Aggregation
        }

        public string Look()
        {
            return "Object Adapter Model :" + _ancient.DisplayName;
        }
    }
}
