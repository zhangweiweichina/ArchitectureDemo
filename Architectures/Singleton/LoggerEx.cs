using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LoggerEx : ILogger
    {
        private LoggerEx()
        {
            Console.WriteLine("LoggerEx Contruction.");
        }
        public static ILogger Instance
        {
            get
            {
                return SingletonBase<LoggerEx>.Instance;
            }
        }

        public void WriteLine(string strLine)
        {
            Console.WriteLine(strLine);
        }
    }
}
