using Pls.Chain.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Chain.Implementation
{
    public class Handler : IHandler
    {
        public IHandler Next { get; set; }

        public void Handle(double dbvalue)
        {
            if(!HandleValue(dbvalue) && Next != null)
                Next.Handle(dbvalue);
        }

        protected virtual bool HandleValue(double dbValue)
        {
            return false;
        }
    }

    public class Leader : Handler
    {
        protected override bool HandleValue(double dbValue)
        {
            if (dbValue <= 1000)
            {
                Console.WriteLine("Leader has handled this value");
                return true;
            }
            return false;
        }
    }

    public class Manager : Handler
    {
        protected override bool HandleValue(double dbValue)
        {
            if (dbValue > 1000 && dbValue <= 10000)
            {
                Console.WriteLine("Manager has handled this value");
                return true;
            }
            return false;
        }
    }

    public class Director : Handler
    {
        protected override bool HandleValue(double dbValue)
        {
            if (dbValue > 10000)
            {
                Console.WriteLine("Director has handled this value");
                return true;
            }
            return false;
        }
    }
}
