using Pls.Factory.Contract;
using Pls.Factory.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Factory.Factory
{
    //工厂方法模式
    //优点： 
    //  1.实现调用者和具体实现的解耦
    //  2.通过扩展工厂类产生不同的对象
    //缺点
    //  1. 类增加比较快，代码维护性比较差

    public abstract class FactroyMethodBase
    {
        public virtual IPhone CreatePhone()
        {
            return null;
        }
    }

    public class MiPhoneFactoryMethod : FactroyMethodBase
    {
        public override IPhone CreatePhone()
        {
            return new MiPhone();
        }
    }

    public class HwPhoneFactoryMethod : FactroyMethodBase
    {
        public override IPhone CreatePhone()
        {
            return new HwPhone();
        }
    }
}
