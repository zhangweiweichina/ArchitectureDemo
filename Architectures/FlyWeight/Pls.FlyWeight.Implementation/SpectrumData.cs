using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pls.FlyWeight.Implementation
{
    public class SpectrumData
    {
        private static Int32 _MaxLength = 1024*1024*2; 
        private byte[] _data = new byte[_MaxLength];

        public byte[] Data
        {
            get
            {
                return _data;
            }
        }

        public override bool Equals(object obj)
        {
            SpectrumData data = obj as SpectrumData;
            if (data == null)
                return false;

            //for (Int32 index = 0; index < _MaxLength; index++)
            //{
            //    if (data.Data[index] != Data[index])
            //        return false;
            //}

            //return true;
            return string.Compare(Convert.ToBase64String(data.Data), Convert.ToBase64String(Data), false) == 0;
        }
    }
}
