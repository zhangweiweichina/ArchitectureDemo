using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.Prototype.Contract;
using Pls.Prototype.Implementation;

namespace Pls.Prototype.Factory
{
    public class ProtoTypeFactory
    {
        static readonly IDictionary<Type, Type> _dicTypes = new Dictionary<Type, Type>
        {
            {typeof(IMail), typeof(Mail) },
            {typeof(IMailEx), typeof(MailEx) }
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
