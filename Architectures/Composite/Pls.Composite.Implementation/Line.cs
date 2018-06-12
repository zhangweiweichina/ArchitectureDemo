﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Composite.Contract;

namespace Pls.Composite.Implementation
{
    public class Line : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("Draw Line");
        }
    }
}
