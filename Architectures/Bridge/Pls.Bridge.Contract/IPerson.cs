using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Bridge.Contract
{
    public interface IPerson
    {
        IColor Color { get; set; }

        IPen Pen { get; set; }

        void Draw();
    }
}
