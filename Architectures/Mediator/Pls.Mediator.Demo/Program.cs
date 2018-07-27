using Pls.Mediator.Contract;
using Pls.Mediator.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Mediator.Demo
{
    class Program
    {
        //中介者
        //中介者将网状结构转化成了星形的结构
        //所有的对象都通过中介者对象进行通讯
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            List<IUser> users = new List<IUser>(){
             new User("User 1"),
             new User("User 2"),
             new User("User 3"),
             new User("User 4")
            };

            IMediator mediator = new Pls.Mediator.Implementation.Mediator();
            foreach(IUser user in users)
            {
                mediator.Register(user);
            }

            Random rd = new Random();
            Int32 nMax = users.Count - 1;
            for (Int32 i = 0; i< 20; i++)
            {
                Int32 nFrom = rd.Next(nMax);
                Int32 nTo = rd.Next(nMax);
                users[nFrom].SendMessage(users[nTo].Name, "Say Hello. " + i);
            }

            Console.ReadKey();
        }
    }
}
