using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.FlyWeight.Implementation
{
    public class SpectrumDataManager
    {
        private static SpectrumDataManager _manager = null;

        public static SpectrumDataManager Instance
        {
            get
            {
                if (_manager == null)
                {
                    _manager = new SpectrumDataManager();
                    _manager.FlyWeight = true;
                }
                return _manager;
            }
        }

        private List<SpectrumData> _datas = new List<SpectrumData>();

        public SpectrumData StoreData(SpectrumData data)
        {
            if (FlyWeight)
            {
                foreach (SpectrumData spectrum in _datas)
                {
                    if (spectrum.Equals(data))
                        return spectrum;
                }
            }

            if(data != null)
                _datas.Add(data);
            return data;
        }

        public bool FlyWeight { get; set; }
    }
}
