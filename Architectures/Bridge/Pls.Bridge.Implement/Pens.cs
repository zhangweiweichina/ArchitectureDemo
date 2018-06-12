using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Bridge.Contract;

namespace Pls.Bridge.Implement
{
    public class Pencil : IPen
    {
        public string Name
        {
            get { return "Pencil"; }
        }
    }

    public class BallPen : IPen
    {
        public string Name
        {
            get { return "Ball Pen";  }
        }
    }
}
