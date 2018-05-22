using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonBaseHungry<T> : SingletonBase<T> where T: class
    {
        static SingletonBaseHungry()
        {
            _tInstance = Activator.CreateInstance(typeof(T), true) as T;
        }
    }
}
