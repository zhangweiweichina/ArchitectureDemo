using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Adapter.Implementation
{
    public class Ancient
    {
        private string _strDisplayName = "Ancient";
        public string DisplayName
        {
            get { return _strDisplayName; }
            set { _strDisplayName = value; }
        }
    }
}
