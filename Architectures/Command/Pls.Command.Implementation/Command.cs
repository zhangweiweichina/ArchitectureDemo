using Pls.Command.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Command.Implementation
{
    class Command : ICommand
    {
        private string _strkey = string.Empty;
        public Command(string strKey)
        {
            _strkey = strKey;
        }

        public void Execute(IList<string> arrList)
        {
            arrList.Add(_strkey);
        }

        public void Undo(IList<string> arrList)
        {
            arrList.RemoveAt(arrList.Count - 1);
        }
    }

    public class DisplayCommand : ICommand
    {
        public void Execute(IList<string> arrList)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string str in arrList)
            {
                sb.Append(str);
            }
            Console.WriteLine(sb.ToString());
        }

        public void Undo(IList<string> arrList)
        {
            throw new NotImplementedException();
        }
    }
}
