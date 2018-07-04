using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Memento.Implementation
{
    public class Person
    {
        public Int32 Age { get; set; }

        public string Name { get; set; }

        public string Appearance { get; set; }

        public string Work { get; set; }
        
        public Memo Save()
        {
            Memo memo = new Memo();
            memo.Age = Age;
            memo.Appearance = Appearance;
            memo.Work = Work;
            return memo;
        }

        public void Load(Memo memo)
        {
            Age = memo.Age;
            Appearance = memo.Appearance;
            Work = memo.Work;
        }

        public void Display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Appearance:" + Appearance);
            Console.WriteLine("Work:" + Work);
        }
    }
}
