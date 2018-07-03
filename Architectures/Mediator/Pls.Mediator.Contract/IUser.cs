using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Mediator.Contract
{
    public interface IUser
    {
        IMediator Mediator { get; set; }

        string Name { get; set; }

        void Receive(string from, string message);

        void SendMessage(string to, string message);
    }
}
