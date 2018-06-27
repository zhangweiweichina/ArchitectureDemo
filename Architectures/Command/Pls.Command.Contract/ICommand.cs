using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Command.Contract
{
    public interface ICommand
    {
        void Execute(IList<string> arrList);

        void Undo(IList<string> arrList);
    }
}
