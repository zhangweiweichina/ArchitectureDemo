using Pls.Mediator.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Mediator.Implementation
{
    public class User : IUser
    {
        public IMediator Mediator { get; set; }
        public string Name { get; set; }

        public User(string strName)
        {
            Name = strName;
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine(string.Format("{0} Receive a message from {1} : {2}", Name, from, message));
        }

        public void SendMessage(string to, string message)
        {
            if (Mediator != null)
                Mediator.SendTo(Name, to, message);
        }
    }
}
