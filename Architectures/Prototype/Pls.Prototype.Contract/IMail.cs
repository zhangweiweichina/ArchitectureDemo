using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Prototype.Contract
{
    public interface IMail
    {
        IList<string> Tos { get; set; }
        string From { get; set; }
        
        string Content { get; set; }

    }
}
