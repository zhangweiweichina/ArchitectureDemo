using Pls.Prototype.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Prototype.Implementation
{
    [Serializable]
    public class Mail : IMail, ICloneable, IProvider
    {
        public string _strValue = string.Empty;
        public IList<string> Tos { get; set; }
        public string From { get; set; }

        public string Content { get; set; }
        
        public void SetValue(string strValue)
        {
            _strValue = strValue;
        }

        public string GetValue()
        {
            return _strValue;
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
