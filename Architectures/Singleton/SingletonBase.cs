using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonBase<T> where T : class
    {
        private static object _obLock = new object();
        protected static T _tInstance = null;

        public static T Instance
        {
            get
            {
                if (_tInstance == null)
                {
                    lock (_obLock)
                    {
                        if (_tInstance == null)
                            _tInstance = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }

                return _tInstance;
            }
        }
    }
}
