using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.TemplateMethod.Implementation
{
    public abstract class DbAccess
    {
        protected DataAdapter _dataAdapter;
        protected virtual void Connect()
        {
            Console.WriteLine("DBAccess::Connect Database");
        }

        protected abstract void Select();

        protected abstract void Display();

        protected virtual void Disconnect()
        {
            Console.WriteLine("DBAccess::Disconnect Database");
        }

        public void Run()
        {
            Connect();
            Select();
            Display();
            Disconnect();
        }
    }
}
