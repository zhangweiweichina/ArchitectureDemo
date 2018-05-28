using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Builder.Contact
{
    public interface INoteBook
    {
        string CPU { get; set; }
        
        string Mainboard { get; set; }

        string Moniter { get; set; }

        string Disk { get; set; }

        string Memory { get; set; }

        void Display();
    }
}
