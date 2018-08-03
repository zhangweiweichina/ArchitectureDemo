using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Dynamic.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Namespace);

            //DynamicObject
            DemoDynamicObject();

            //DynamicObjct
            DemoExpandObject();


            Console.ReadKey();
        }

        private static void RunPython()
        {
            ScriptRuntime script = new ScriptRuntime();
        }

        private static void DemoDynamicObject()
        {
            Console.Write(":::::::::::::::DemoDynamicObject::::::::::::::::::::::::::::::");
            dynamic myDynamicObject = new MyDynamicObject();
            myDynamicObject.Name = "Polaris";
            myDynamicObject.Age = 22;

            Console.WriteLine(myDynamicObject.GetType());
            Console.WriteLine(myDynamicObject.Name);

            Console.WriteLine("Properties:");
            foreach (PropertyInfo pi in myDynamicObject.GetType().GetProperties())
                Console.WriteLine(pi.Name);

            Console.WriteLine("Methods:");
            foreach (MethodInfo mi in myDynamicObject.GetType().GetMethods())
                Console.WriteLine(mi.Name);
        }

        private static void DemoExpandObject()
        {
            //ExpandoObject
            Console.Write(":::::::::::::::ExpandoObject::::::::::::::::::::::::::::::");
            ExpandoObject eo1 = new ExpandoObject();
            IDictionary<string, object> acc = eo1 as IDictionary<string, object>;
            if (acc != null)
                acc.Add("Name", "Polaris");
            Console.WriteLine(eo1.GetType());

            dynamic eo = new ExpandoObject();
            eo.Name = "Polaris";
            eo.Age = 10;
            eo.Telephone = new List<string>() { "15800543106", "15618061039" };
            Console.WriteLine(eo.GetType());

            Console.WriteLine("Properties:");
            foreach (PropertyInfo pi in eo.GetType().GetProperties())
                Console.WriteLine(pi.Name);

            Console.WriteLine("Methods:");
            foreach (MethodInfo mi in eo.GetType().GetMethods())
                Console.WriteLine(mi.Name);
        }
    }

    public class MyDynamicObject : DynamicObject
    {
        Dictionary<string, object> _dicMembers = new Dictionary<string, object>();
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_dicMembers.Keys.Contains(binder.Name))
            {
                result = _dicMembers[binder.Name];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_dicMembers.Keys.Contains(binder.Name))
                _dicMembers[binder.Name] = value;
            else
                _dicMembers.Add(binder.Name, value);
            return true;
        }
    }
}
