using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Prototype.Contract
{
    public interface IProvider
    {
        string GetValue();
        void SetValue(string strValue);
    }
}
