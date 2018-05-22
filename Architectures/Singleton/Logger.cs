using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger : SingletonBase<Logger>, ILogger
    {
        protected Logger()
        {
        }

        public void WriteLine(string strLine)
        {
            Console.WriteLine(strLine);
        }
    }
}
