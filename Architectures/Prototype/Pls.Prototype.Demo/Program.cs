using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Pls.Prototype.Contract;
using Pls.Prototype.Factory;

namespace Pls.Prototype.Demo
{
    //原型模式用于
    //1. 需要多个实例，且不想重复之前复杂的逻辑操作。例如，发邮件时，仅需要修改发送的地址，不想再重新写邮件的相关内容。
    //2. 调用者仅知道对象的接口，并不知道对象属于哪个类时时。
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            Console.WriteLine("Shallow Clone.");
            ShallowClone();
            Console.ReadKey();
            Console.WriteLine("Deep Clone Clone.");
            DeepClone();
            Console.ReadKey();
        }

        private static void ShallowClone()
        {
            IMail mail = ProtoTypeFactory.Create<IMail>();
            mail.From = "zhang.w.w@foxmail.com";
            mail.Content = "This is prototype pattern demo mail.";
            
            List<string> lstMainAddress = new List<string>
            {
                "Dave.Cui@foxmail.com",
                "Yang.Yang@foxmail.com"
            };
            mail.Tos = lstMainAddress;

            ICloneable originallMail = mail as ICloneable;
            if (originallMail == null)
            {
                Console.WriteLine("Main cannot clone");
            }

            IProvider provider = mail as IProvider;
            if (provider != null)
            {
                provider.SetValue("My Value");
            }
            
            IMail newMail = originallMail.Clone() as IMail;
            lstMainAddress.Add("Ryan.Tang@foxmail.com");

            Console.WriteLine(string.Format("From : {0}", newMail.From));
            foreach (var strMailAddressTo in newMail.Tos)
            {
                Console.WriteLine(string.Format("To : {0}", strMailAddressTo));
            }
            Console.WriteLine(string.Format("Content : {0}", newMail.Content));
            
            provider = newMail as IProvider;
            if(provider != null)
                Console.WriteLine(string.Format("Value : {0}", provider.GetValue()));
        }

        private static void DeepClone()
        {
            IMailEx mail = ProtoTypeFactory.Create<IMailEx>();
            mail.From = "zhang.w.w@foxmail.com";
            mail.Content = "This is prototype pattern demo mail.";

            List<string> lstMainAddress = new List<string>
            {
                "Dave.Cui@foxmail.com",
                "Yang.Yang@foxmail.com"
            };
            mail.Tos = lstMainAddress;


            ICloneable originallMail = mail as ICloneable;
            if (originallMail == null)
            {
                Console.WriteLine("Main cannot clone");
                return;
            }

            IMailEx newMail = originallMail.Clone() as IMailEx;
            lstMainAddress.Add("Ryan.Tang@foxmail.com");
            if (newMail != null)
            {
                Console.WriteLine(string.Format("From : {0}", newMail.From));
                Console.WriteLine(string.Format("Content : {0}", newMail.Content));
                foreach (var strMailAddress in newMail.Tos)
                {
                    Console.WriteLine(string.Format("To : {0}", strMailAddress));
                }
            }
        }
    }
}
