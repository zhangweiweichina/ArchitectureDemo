using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.TemplateMethod.Implementation
{
    public class DbAccessUser : DbAccess
    {
        protected override void Select()
        {
            Console.WriteLine("DbAccessUser::Fill Db Adapter");
        }

        protected override void Display()
        {
            Console.WriteLine("DbAccessUser::Display");
        }
    }

    public class DbAccessGroup : DbAccess
    {
        protected override void Select()
        {
            Console.WriteLine("DbAccessGroup::Fill Db Adapter");
        }

        protected override void Display()
        {
            Console.WriteLine("DbAccessGroup::Display");
        }
    }
}
