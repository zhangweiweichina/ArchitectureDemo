using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pls.Builder.Contact;
using Pls.Builder.Factory;

namespace Pls.Builder.Demo
{
    class Program
    {
        //建造者模式实现了具体构造过程（业务逻辑）和显示（最终数据）的解耦。
        //建造者模式主要适用于
        //1.建造的对象有统一的外部接口
        //2.可以分模块初始化，且初始化顺序固定
        //3.初始化工作比较复杂
        //4.建造的对象比较单一（一个建造者只能创造出一类对象，不过可以组合不同的建造者组件进行扩展）
        //将不同的建造步骤封装到不同的建造类中，再由Director根据不同的情况决定调用对应的建造者类创造对象。
        //扩展新的建造者对象时，仅需要添加对应的建造者类即可。
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            IDirector director = BuilderFactory.Create<IDirector>();
            IBuilder intelBuilder = BuilderFactory.Create<IIntelBuilder>();
            IBuilder amdBuilder = BuilderFactory.Create<IAMDBuilder>();

            INoteBook nbIntel = director.BuildNoteBook(intelBuilder);
            INoteBook nbAMD = director.BuildNoteBook(amdBuilder);

            Console.WriteLine("--------------");
            nbIntel.Display();
            Console.WriteLine("--------------");
            nbAMD.Display();

            Console.ReadKey();
        }
    }
}
