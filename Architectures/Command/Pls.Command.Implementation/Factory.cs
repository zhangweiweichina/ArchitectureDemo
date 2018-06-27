using Pls.Command.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Command.Implementation
{
    public class Factory
    {
        public static ICommand CreateCommand(string key)
        {
            if(string.Compare(key,"display", true) == 0)
                return new DisplayCommand();
            else
                return new Command(key);
        }
    }
}
