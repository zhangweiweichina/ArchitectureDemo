using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Mediator.Contract
{
    public interface IMediator
    {
        void Register(IUser user);

        void SendTo(string from, string to, string strMessage);
    }
}
