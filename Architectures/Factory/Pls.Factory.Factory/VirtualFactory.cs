using Pls.Factory.Contract;
using Pls.Factory.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Factory.Factory
{
    //虚拟工厂模式
    //优点： 
    //  1.实现调用者和具体实现的解耦
    //  2.需要创建一套对象才能正确使用时 [例如数据库用的Command/Connect/...必须配套才能使用]
    //缺点
    //  1. 当基类增加新的对象（虚函数）的时候，对所有的子类都有影响

    public abstract class VirtualFactoryBase
    {
        public virtual IPhone CreatePhone()
        {
            return null;
        }

        public virtual ITV CreateTV()
        {
            return null;
        }
    }

    public class XiaoMiFactory : VirtualFactoryBase
    {
        public override IPhone CreatePhone()
        {
            return new MiPhone();
        }

        public override ITV CreateTV()
        {
            return new MITV();
        }
    }


    public class HWFactory : VirtualFactoryBase
    {
        public override IPhone CreatePhone()
        {
            return new HwPhone();
        }

        public override ITV CreateTV()
        {
            return new HWTV();
        }
    }
}
