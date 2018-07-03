using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Chain.Contract
{
    public interface IHandler
    {
        IHandler Next { get; set; }

        void Handle(double dbvalue);
    }
}
