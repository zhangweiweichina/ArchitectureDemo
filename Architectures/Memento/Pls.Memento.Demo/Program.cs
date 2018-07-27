using Pls.Memento.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Memento.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            Int32 nIndex = -1;
            List<Memo> memos = new List<Memo>();
            Person person = new Person();
            person.Name = "Jacky";
            while (true)
            {
                char key = Convert.ToChar(Console.Read());
                if (key == 'q')
                    break;

                if (key == 'i')
                {
                    person.Age++;
                    Console.WriteLine("Age:" +  person.Age);
                    Console.WriteLine("Please input Appearance: ");
                    person.Appearance = Console.ReadLine();
                    Console.WriteLine("Please input work: ");
                    person.Work = Console.ReadLine();
                    memos.RemoveRange(nIndex + 1, memos.Count - nIndex - 1);
                    memos.Add(person.Save());
                    nIndex = memos.Count - 1;
                }
                else if (key == 'u')
                {
                    if (nIndex < memos.Count)
                    {
                        person.Load(memos[nIndex]);
                        person.Display();

                        if (nIndex < memos.Count - 1)
                            nIndex++;
                    }
                }
                else if(key == 'd')
                {
                    if (nIndex < memos.Count)
                    {
                        person.Load(memos[nIndex]);
                        person.Display();

                        if (nIndex > 0)
                            nIndex--;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
