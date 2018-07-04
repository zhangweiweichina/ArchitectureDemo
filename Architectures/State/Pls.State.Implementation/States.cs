using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.State.Contract;

namespace Pls.State.Implementation
{
    public class SleepState : IPerson
    {
        public void Drive()
        {
            Console.WriteLine("Sleep : Cannot drive");
        }

        public void Eat()
        {
            Console.WriteLine("Sleep : Cannot Eat");
        }

        public void Look()
        {
            Console.WriteLine("Sleep : Cannot Look");
        }

        public void Talk()
        {
            Console.WriteLine("Sleep : Cannot Talk");
        }
    }

    public class DrinkState : IPerson
    {
        public void Drive()
        {
            Console.WriteLine("Drink : Cannot drive");
        }

        public void Eat()
        {
            Console.WriteLine("Drink : Can Eat");
        }

        public void Look()
        {
            Console.WriteLine("Drink : Can Look");
        }

        public void Talk()
        {
            Console.WriteLine("Drink : Can Talk");
        }
    }

    public class WorkState : IPerson
    {
        public void Drive()
        {
            Console.WriteLine("Work : Can drive");
        }

        public void Eat()
        {
            Console.WriteLine("Work : Cannot Eat");
        }

        public void Look()
        {
            Console.WriteLine("Work : Can Look");
        }

        public void Talk()
        {
            Console.WriteLine("Work : Can Talk");
        }
    }

}
