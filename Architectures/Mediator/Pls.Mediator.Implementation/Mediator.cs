using Pls.Mediator.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Mediator.Implementation
{
    public class Mediator : IMediator
    {
        protected Dictionary<string, IUser> _users = new Dictionary<string, IUser>();
        public void Register(IUser user)
        {
            if(!_users.ContainsKey(user.Name))
            {
                _users.Add(user.Name, user);
                user.Mediator = this;
            }
        }

        public void SendTo(string from, string to, string strMessage)
        {
            if(_users.ContainsKey(to))
            {
                _users[to].Receive(from, strMessage);
            }
        }
    }
}
