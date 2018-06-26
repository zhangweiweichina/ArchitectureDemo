using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Pls.FlyWeight.Implementation;

namespace Pls.FlyWeight.Demo
{
    //享元模式
    //在对象太多以至于系统不能承受内存开销的情况下使用
    //字符串的实现就是享元模式的具体应用。
    //相同的字符串实际的引用地址是一样的，字符串被修改以后，会在托管堆上重新分配
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            
            DateTime dtBegin = DateTime.Now;
            List<Experiment> experiments = new List<Experiment>();
            for(Int32 i =0 ; i< 4000; i++)
            {
                Experiment ex = new Experiment();
                ex.Spectrum = new SpectrumData();
                experiments.Add(ex);
            }

            DateTime dtEnd = DateTime.Now;
            
            Console.WriteLine(dtEnd -dtBegin);

            SpectrumDataManager.Instance.FlyWeight = false;
            experiments = new List<Experiment>();
            try
            {
                for (Int32 i = 0; i < 4000; i++)
                {
                    Experiment ex = new Experiment();
                    ex.Spectrum = new SpectrumData();
                    experiments.Add(ex);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);//Out of Memroy
            }
            Console.ReadKey();
        }
    }
}
