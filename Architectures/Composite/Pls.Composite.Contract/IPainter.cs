using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Composite.Contract
{
    public interface IPainter
    {
        IList<IDraw> Items { get; }

        void Draw();
    }
}
