using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.FlyWeight.Implementation
{
    public class Experiment
    {
        public DateTime CreateTime { get; set; }

        private SpectrumData _spectrum = null;

        public SpectrumData Spectrum
        {
            get
            {
                return _spectrum;
            }
            set
            {
                _spectrum = SpectrumDataManager.Instance.StoreData(value);
            }
        }
    }
}
