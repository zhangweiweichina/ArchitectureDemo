using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Composite.Contract;

namespace Pls.Composite.Implementation
{
    public class Painter : IPainter
    {
        private IList<IDraw> _lstItems = new List<IDraw>();

        public IList<IDraw> Items
        {
            get { return _lstItems; }
        }

        public void Draw()
        {
            foreach (IDraw draw in _lstItems)
            {
                draw.Draw();
            }
        }
    }
}
