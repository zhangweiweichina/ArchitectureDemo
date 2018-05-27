using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Pls.Prototype.Contract;

namespace Pls.Prototype.Implementation
{
    [Serializable]
    public class MailEx : Mail, IMailEx
    {
        public override object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return formatter.Deserialize(ms);
        }
    }
}
