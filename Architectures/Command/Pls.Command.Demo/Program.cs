using Pls.Command.Contract;
using Pls.Command.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Command.Demo
{
    class Program
    {
        //命令模式
        //用于调用者、接收者(要处理的对象）、及处理的方法三者之间的解耦。
        //命令模式使调用者直接调用接受者变换成了调用者通过命令对象来处理接受者。
        //命令模式实际上使处理方法和处理数据之间的解耦。
        //通过命令方式在外部很轻松的扩展数据的处理方法。
        //具体应用如下：
        //MVC模式下会根据用户输入的URL地址创建不同的Handler(Command)
        //通过Handler处理用户的数据，返回给用户需要的HTML
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            List<ICommand> cmds = new List<ICommand>();
            cmds.Add(Factory.CreateCommand("a"));
            cmds.Add(Factory.CreateCommand("b"));
            cmds.Add(Factory.CreateCommand("c"));
            cmds.Add(Factory.CreateCommand("d"));


            ICommand cmdDisplay = Factory.CreateCommand("display");
            IList<string> items = new List<string>();

            while(true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.KeyChar == 'q' || key.KeyChar == 'Q')
                    break;
                else if(key.KeyChar == 'd' || key.KeyChar == 'D')
                {
                    if(items.Count < cmds.Count)
                    {
                        cmds[items.Count].Execute(items);
                    }
                }
                else if(key.KeyChar == 'u' || key.KeyChar == 'U')
                {
                    if (items.Count > 0)
                    {
                        cmds[items.Count-1].Undo(items);
                    }
                }
                cmdDisplay.Execute(items);
            }
        }
    }
}
