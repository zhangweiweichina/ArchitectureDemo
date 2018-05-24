using Pls.Factory.Contract;
using Pls.Factory.Implementation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Factory.Factory
{
    //简单工厂模式
    //优点：实现了调用者和实现对象的解耦
    //缺点：每次扩展都要重新修改SimpleFactory的代码，不符合对修改关闭，对扩展开发的原则。
    public class SimpleFactory
    {
        static readonly IDictionary<Type, Type> _dicTypes = new Dictionary<Type, Type>
        {
            {typeof(IMiPhone), typeof(MiPhone) },
            {typeof(IHWPhone), typeof(HwPhone) }
        };

        public static T Create<T>()
        {
            var type = typeof(T);
            Type domainObjectType;

            if (!_dicTypes.TryGetValue(type,
                out domainObjectType))
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Type '{0}' can't be created!", type.Name);
                throw new Exception(message);
            }

            return (T)Activator.CreateInstance(domainObjectType);
        }
    }
}
