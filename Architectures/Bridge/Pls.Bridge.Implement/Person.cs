using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Pls.Bridge.Contract;

namespace Pls.Bridge.Implement
{
    public class Person : IPerson
    {
        public IColor Color { get; set; }

        public IPen Pen { get; set; }

        public void Draw()
        {
            if(Color != null && Pen != null)
                Console.WriteLine("Using pen <{0}> & color <{1}> to draw. ", Pen.Name, Color.Name );
        }
    }
}
